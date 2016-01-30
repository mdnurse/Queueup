namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.queueGrid = new System.Windows.Forms.DataGridView();
            this.queueStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queueTwitch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queueSteam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currGrid = new System.Windows.Forms.DataGridView();
            this.currStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currTwitch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currSteam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamSizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.noFilter = new System.Windows.Forms.RadioButton();
            this.followers = new System.Windows.Forms.RadioButton();
            this.subs = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.queueGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamSizeNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 595);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Channel";
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 592);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(592, 62);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 553);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(676, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "IRC Chat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Queue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Current Group";
            // 
            // queueGrid
            // 
            this.queueGrid.AllowUserToAddRows = false;
            this.queueGrid.AllowUserToDeleteRows = false;
            this.queueGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queueGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.queueStatus,
            this.queueTwitch,
            this.queueSteam});
            this.queueGrid.Location = new System.Drawing.Point(302, 62);
            this.queueGrid.Name = "queueGrid";
            this.queueGrid.Size = new System.Drawing.Size(284, 553);
            this.queueGrid.TabIndex = 11;
            this.queueGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.queueGrid_CellContentClick);
            // 
            // queueStatus
            // 
            this.queueStatus.DataPropertyName = "status";
            this.queueStatus.HeaderText = "Status";
            this.queueStatus.Name = "queueStatus";
            this.queueStatus.ReadOnly = true;
            this.queueStatus.Width = 40;
            // 
            // queueTwitch
            // 
            this.queueTwitch.DataPropertyName = "twitchname";
            this.queueTwitch.HeaderText = "Twitch Name";
            this.queueTwitch.Name = "queueTwitch";
            this.queueTwitch.ReadOnly = true;
            // 
            // queueSteam
            // 
            this.queueSteam.DataPropertyName = "steamname";
            this.queueSteam.HeaderText = "Steam Name";
            this.queueSteam.Name = "queueSteam";
            this.queueSteam.ReadOnly = true;
            // 
            // currGrid
            // 
            this.currGrid.AllowUserToAddRows = false;
            this.currGrid.AllowUserToDeleteRows = false;
            this.currGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.currStatus,
            this.currTwitch,
            this.currSteam});
            this.currGrid.Location = new System.Drawing.Point(12, 62);
            this.currGrid.Name = "currGrid";
            this.currGrid.Size = new System.Drawing.Size(284, 286);
            this.currGrid.TabIndex = 12;
            this.currGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.currGrid_CellContentClick);
            // 
            // currStatus
            // 
            this.currStatus.DataPropertyName = "status";
            this.currStatus.HeaderText = "Status";
            this.currStatus.Name = "currStatus";
            this.currStatus.Width = 40;
            // 
            // currTwitch
            // 
            this.currTwitch.DataPropertyName = "twitchname";
            this.currTwitch.HeaderText = "Twitch Name";
            this.currTwitch.Name = "currTwitch";
            // 
            // currSteam
            // 
            this.currSteam.DataPropertyName = "steamname";
            this.currSteam.HeaderText = "Steam Name";
            this.currSteam.Name = "currSteam";
            // 
            // teamSizeNumeric
            // 
            this.teamSizeNumeric.AccessibleDescription = "";
            this.teamSizeNumeric.AccessibleName = "";
            this.teamSizeNumeric.Location = new System.Drawing.Point(257, 354);
            this.teamSizeNumeric.Name = "teamSizeNumeric";
            this.teamSizeNumeric.Size = new System.Drawing.Size(39, 20);
            this.teamSizeNumeric.TabIndex = 13;
            this.teamSizeNumeric.ValueChanged += new System.EventHandler(this.teamSizeNumeric_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Team Size";
            // 
            // noFilter
            // 
            this.noFilter.AutoSize = true;
            this.noFilter.Location = new System.Drawing.Point(211, 415);
            this.noFilter.Name = "noFilter";
            this.noFilter.Size = new System.Drawing.Size(51, 17);
            this.noFilter.TabIndex = 15;
            this.noFilter.TabStop = true;
            this.noFilter.Text = "None";
            this.noFilter.UseVisualStyleBackColor = true;
            // 
            // followers
            // 
            this.followers.AutoSize = true;
            this.followers.Location = new System.Drawing.Point(211, 438);
            this.followers.Name = "followers";
            this.followers.Size = new System.Drawing.Size(69, 17);
            this.followers.TabIndex = 16;
            this.followers.TabStop = true;
            this.followers.Text = "Followers";
            this.followers.UseVisualStyleBackColor = true;
            // 
            // subs
            // 
            this.subs.AutoSize = true;
            this.subs.Location = new System.Drawing.Point(211, 461);
            this.subs.Name = "subs";
            this.subs.Size = new System.Drawing.Size(80, 17);
            this.subs.TabIndex = 17;
            this.subs.TabStop = true;
            this.subs.Text = "Subscribers";
            this.subs.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(237, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Filters";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 36);
            this.button2.TabIndex = 19;
            this.button2.Text = "Queue Group";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 436);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 38);
            this.button3.TabIndex = 20;
            this.button3.Text = "Remove User From Group";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(102, 436);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 38);
            this.button4.TabIndex = 21;
            this.button4.Text = "Remove User From Queue";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 396);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(176, 36);
            this.button5.TabIndex = 22;
            this.button5.Text = "Random Queue";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 645);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.subs);
            this.Controls.Add(this.followers);
            this.Controls.Add(this.noFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.teamSizeNumeric);
            this.Controls.Add(this.currGrid);
            this.Controls.Add(this.queueGrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.queueGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamSizeNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView queueGrid;
        private System.Windows.Forms.DataGridView currGrid;
        private System.Windows.Forms.NumericUpDown teamSizeNumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton noFilter;
        private System.Windows.Forms.RadioButton followers;
        private System.Windows.Forms.RadioButton subs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn queueStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn queueTwitch;
        private System.Windows.Forms.DataGridViewTextBoxColumn queueSteam;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn currStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn currTwitch;
        private System.Windows.Forms.DataGridViewTextBoxColumn currSteam;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

