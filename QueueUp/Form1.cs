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
        public void ircthread()
        {
            int port;
            string buf, nick, pw, server, chan, user, uname, msg;

            System.Net.Sockets.TcpClient sock = new System.Net.Sockets.TcpClient();
            System.IO.TextReader input;
            System.IO.TextWriter output;

            nick = "queueupchat";
            pw = "oauth:mwhpwsgzsohz1ltvj9wtwnkwn0aqzq";
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
               "CAP REQ :twitch.tv/membership" + "\r\n " +   //the hew magic
               "JOIN " + chan + "\r\n"

            );
            output.Flush();

            //Process each line received from irc server
            for (buf = input.ReadLine(); ; buf = input.ReadLine())
            {
                if (buf.Contains("PRIVMSG"))
                {
                    string[] split = buf.Split(new Char[] { ':' });
                    user = split[1];
                    string[] unamesplit = user.Split(new Char[] { '!' });
                    uname = unamesplit[0];
                    msg = split[2];

                    textBox2.Invoke((Action)delegate
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


                //Send pong reply to any ping messages
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

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart ircth = new ThreadStart(ircthread);
            Thread chatthread = new Thread(ircth);
            chatthread.Start();

            Uri uri = new Uri("http://twitch.tv/" + textBox1.Text + "/chat");

            //set web browser here
            webBrowser1.Url = uri;
            webBrowser1.Refresh();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //webBrowser1.Dock = DockStyle.Fill;
        }
    }
}
