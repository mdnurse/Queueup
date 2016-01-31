using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
   

    public partial class Form1 : Form
    {
    
        //LinkedList<string> nameList = new LinkedList<string>();
        BindingList<User> blank = new BindingList<User>();
        BindingList<User> nameList = new BindingList<User>();
        BindingList<User> currentgroup = new BindingList<User>();
        int count = 0;
        int groupcount = 0;
        int groupmax = 0; //temp until we make it variable
        bool connected = false;

        public void ircthread()
        {
            int port;
            string buf, nick, pw, server, chan, user, uname, msg, queueList;
            bool flag = false;
            User temp = null;

            System.Net.Sockets.TcpClient sock = new System.Net.Sockets.TcpClient();
            System.IO.TextReader input;
            System.IO.TextWriter output;

            nick = "queueupchat";
            pw = "oauth:mwhpwsgzsohz1ltvj9wtwnkwn0aqzq";    //oauth is password for IRC, Dont touch it
            server = "irc.twitch.tv";
            port = 6667;
            chan = "#" + textBox1.Text.ToLower();
            sock.Connect(server, port);

            input = new System.IO.StreamReader(sock.GetStream());
            output = new System.IO.StreamWriter(sock.GetStream());

            //Starting USER and NICK login commands
            output.Write(
               "PASS " + pw + "\r\n" +
               "NICK " + nick + "\r\n" +
               "USER " + nick + " 8 * :" + nick + "\r\n" +   //this is
               "CAP REQ :twitch.tv/membership" + "\r\n " +   //the new magic
               "JOIN " + chan + "\r\n"                       //dont touch it
                                                            //EVER!

            );
            output.Flush();

            textBox2.Invoke((Action)delegate
            {
                textBox2.AppendText(DateTime.Now.ToShortTimeString() + "Connection Established \r\n\r\n"); //this should probably be in a try catch or something...
            });

            //Process each line received from irc server
            for (buf = input.ReadLine(); ; buf = input.ReadLine())
            {
                if (buf.Contains("PRIVMSG"))
                {
                    string[] split = buf.Split(new Char[] { ':' });   //all the shit for cutting up the raw IRC string into easily readable text
                    user = split[1];                                   //we need to edit this so if someone types sends a message with colons it doesnt split it again
                    string[] unamesplit = user.Split(new Char[] { '!' });
                    uname = unamesplit[0];
                    msg = split[2];
                    
                    if (msg.Equals("!join", StringComparison.Ordinal))
                    {
                        queueGrid.Invoke((Action)delegate
                        {
                            foreach (User u in nameList) //checking if user is already queued.
                            {
                                if (u.twitchname.Equals(uname, StringComparison.Ordinal))
                                {
                                    temp = u;
                                    flag = true;
                                    output.Write("PRIVMSG " + chan + " :@" + uname + " You are already in queue\r\n");
                                    output.Flush(); //does not work everytime, works 1st instance or if !queue is called but not others. LOW PRIORITY
                                }
                            }

                            if (!flag)
                            {
                                User newusr = new User();
                                newusr.twitchname = uname;
                                nameList.Add(newusr);
                                queueGrid.DataSource = nameList;
                                count++;
                                output.Write("PRIVMSG " + chan + " :@" + uname + " Has successfully joined the queue!\r\n");
                                output.Flush(); //does not work everytime, works 1st instance or if !queue is called but not others. LOW PRIORITY
                            }
                            flag = false;
                        });
                       
                    }

                    if (msg.Equals("!leave", StringComparison.Ordinal))
                    {
                        queueGrid.Invoke((Action)delegate
                        {
                            foreach (User u in nameList)
                            {
                                if (u.twitchname.Equals(uname, StringComparison.Ordinal))
                                {
                                    temp = u;
                                    flag = true;                                 
                                }
                            }
                            if (flag)
                            {
                                nameList.Remove(temp);
                                count--;
                                flag = false;
                                output.Write("PRIVMSG " + chan + " :@" + uname + " You have successfully left the queue!\r\n");
                                output.Flush(); //does not work everytime, works 1st instance or if !queue is called but not others. LOW PRIORITY
                            }
                        });
                    } // actually functioning now

                    string[] steamnamesplit = msg.Split(new Char[] { ' ' });
                    if (steamnamesplit[0].Equals("!steam", StringComparison.Ordinal))
                    {
                        flag = false;
                        queueGrid.Invoke((Action)delegate
                        {
                            foreach (User u in nameList)
                            {
                                if (u.twitchname.Equals(uname, StringComparison.Ordinal))
                                {
                                    temp = u;
                                    flag = true;
                                }
                            }
                            if (flag)
                            {
                                //need to figure out how to check if there's actually a steamnamesplit[1]
                                temp.steamname = steamnamesplit[1];
                                queueGrid.DataSource = blank; // used to fix problem of names not appearing until another action occurs
                                queueGrid.DataSource = nameList; // rebound to display all info
                                output.Write("PRIVMSG " + chan + " :@" + uname + " Your steam name has been successfully updated!\r\n");
                                output.Flush(); //does not work everytime, works 1st instance or if !queue is called but not others. LOW PRIORITY
                            }
                        });

                        currGrid.Invoke((Action)delegate
                        {
                            foreach (User u in currentgroup)
                            {
                                if (u.twitchname.Equals(uname, StringComparison.Ordinal))
                                {
                                    temp = u;
                                    flag = true;
                                }
                            }
                            if (flag)
                            {
                                temp.steamname = steamnamesplit[1];
                                currGrid.DataSource = blank; // used to fix problem of names not appearing until another action occurs
                                currGrid.DataSource = currentgroup; // rebound to display all info
                            }
                        });

                        if (!flag)
                        {
                            output.Write("PRIVMSG " + chan + " :@" + uname + " You can't add your steam name if you're not in the queue!\r\n");
                            output.Flush(); //does not work everytime, works 1st instance or if !queue is called but not others. LOW PRIORITY
                        }
                    }

                    if (msg.Equals("!queue",StringComparison.Ordinal))
                    {
                        queueList = "";
                        foreach (User u in nameList)
                        {
                            queueList += " @" + u.twitchname  + ",";
                        }
                        output.Write("PRIVMSG " + chan + " :CURRENT QUEUE: " + queueList + "\r\n");
                        output.Flush();
                    }

                    textBox2.Invoke((Action)delegate //puts the chat into the ircbox
                    {

                        //int s = textBox2.Text.Length - textBox2.Height;
                        //if (s < 0) s = 0;
                        //textBox2.Text = textBox2.Text.Substring(s);
                        //textBox2.Text += DateTime.Now.ToShortTimeString() + " " + uname + ": " + msg + "\r\n";
                        textBox2.AppendText(DateTime.Now.ToShortTimeString() + " " + uname + ": " + msg + "\r\n\r\n");
                        textBox2.Enabled = false;
                        textBox2.WordWrap = true;
                        textBox2.AcceptsReturn = true;
                    });

                    this.Invoke((Action)delegate
                    {
                        this.TopMost = true;

                    });

                }


                //Send pong reply to any ping messages to prevent timeouts (#JustIrcThings)
                if (buf.StartsWith("PING ")) { output.Write(buf.Replace("PING", "PONG") + "\r\n"); output.Flush(); }
                if (buf[0] != ':') continue;

                /* IRC commands come in one of these formats:
                 * :NICK!USER@HOST COMMAND ARGS ... :DATA\r\n
                 * :SERVER COMAND ARGS ... :DATA\r\n
                 */

                

            }
        }
        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            bool flag = false;
            int temp = groupcount;
            currGrid.Invoke((Action)delegate
            {
                if (groupcount >= groupmax)
                {
                    currentgroup = new BindingList<User>();
                    groupcount = 0;
                    flag = true;
                   
                }
            });
            
            queueGrid.Invoke((Action)delegate
            {
                foreach (User u in nameList)
                {
                    if (groupmax == 0) break;
                    currentgroup.Add(u);
                    groupcount++;

                    if (groupcount >= groupmax)
                    {
                        break;
                    }
                }
              
                    for (int i = 0; i < groupcount; i++)
                    {
                        if(count == 0) break;
                        nameList.RemoveAt(0);
                        count--;
                    }

            });

            currGrid.Invoke((Action)delegate
            {
                
                    currGrid.DataSource = currentgroup;
                
            });
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                ThreadStart ircth = new ThreadStart(ircthread);
                Thread chatthread = new Thread(ircth);
                chatthread.Start();
                textBox2.Invoke((Action)delegate
                {
                    textBox2.AppendText(DateTime.Now.ToShortTimeString() + "Connecting to channel: " + textBox1.Text.ToLower() + "\r\n\r\n");
                });
                connected = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //webBrowser1.Dock = DockStyle.Fill;
            noFilter.Checked = true;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e) //makes it so when you hit enter it executes the connect button
        {
            
            
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs()); //need to fix the windows ding sound  -Can "fix" mean make it loop 500 times at max volume? --
                
            }
        }

        private void currGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void queueGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public class User // these are the users we will put inside the list
        {
            public string twitchname { get; set; }
            public string steamname { get; set; }
            public string status { get; set; }
        }

        private void teamSizeNumeric_ValueChanged(object sender, EventArgs e)
        {
            groupmax = (int)teamSizeNumeric.Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int removeindex;
            currGrid.Invoke((Action)delegate
            {
                if (groupcount > 0)
                {
                    removeindex = currGrid.CurrentCell.RowIndex;
                    currentgroup.RemoveAt(removeindex);
                    groupcount--;
                    button1_Click(this, new EventArgs());
                    
                }
            });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int removeindex;
            queueGrid.Invoke((Action)delegate
            {
                if (count > 0)
                {
                    removeindex = queueGrid.CurrentCell.RowIndex;
                    nameList.RemoveAt(removeindex);
                    queueGrid.DataSource = blank; // used to fix problem of names not appearing until another action occurs
                    queueGrid.DataSource = nameList; // rebound to display all info
                    count--;
                }
            });
        }

        private void button5_Click(object sender, EventArgs e) // generate a random queue :O
        {
            Random r = new Random();
            int temp = 0;
            int rand = 0;
            currGrid.Invoke((Action)delegate
            {

                if (groupcount >= groupmax)
                {
                    currentgroup = new BindingList<User>();
                    groupcount = 0;
                } 
                else
                {
                    temp = groupcount;
                }

                for (int i = temp; i < groupmax; i++)
                {
                    if (count == 0) break;
                    rand = r.Next(0, count - 1);
                    currentgroup.Add(nameList[rand]);
                    groupcount++;
                    queueGrid.Invoke((Action)delegate
                    {
                        nameList.RemoveAt(rand);
                        count--;
                        queueGrid.DataSource = nameList;
                    });
                }

                currGrid.DataSource = currentgroup;
            });
        }
    }
}
