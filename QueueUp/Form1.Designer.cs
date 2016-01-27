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
            this.currGrid = new System.Windows.Forms.DataGridView();
            this.queueStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queueTwitch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queueSteam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currTwitch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currSteam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.queueGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 595);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Channel";
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
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
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Current Group";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // queueGrid
            // 
            this.queueGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queueGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.queueStatus,
            this.queueTwitch,
            this.queueSteam});
            this.queueGrid.Location = new System.Drawing.Point(302, 62);
            this.queueGrid.Name = "queueGrid";
            this.queueGrid.Size = new System.Drawing.Size(284, 553);
            this.queueGrid.TabIndex = 11;
            this.queueGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // currGrid
            // 
            this.currGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.currStatus,
            this.currTwitch,
            this.currSteam});
            this.currGrid.Location = new System.Drawing.Point(12, 62);
            this.currGrid.Name = "currGrid";
            this.currGrid.Size = new System.Drawing.Size(284, 286);
            this.currGrid.TabIndex = 12;
            // 
            // queueStatus
            // 
            this.queueStatus.HeaderText = "Status";
            this.queueStatus.Name = "queueStatus";
            this.queueStatus.Width = 40;
            // 
            // queueTwitch
            // 
            this.queueTwitch.HeaderText = "Twitch Name";
            this.queueTwitch.Name = "queueTwitch";
            // 
            // queueSteam
            // 
            this.queueSteam.HeaderText = "Steam Name";
            this.queueSteam.Name = "queueSteam";
            // 
            // currStatus
            // 
            this.currStatus.HeaderText = "Status";
            this.currStatus.Name = "currStatus";
            this.currStatus.Width = 40;
            // 
            // currTwitch
            // 
            this.currTwitch.HeaderText = "Twitch Name";
            this.currTwitch.Name = "currTwitch";
            // 
            // currSteam
            // 
            this.currSteam.HeaderText = "Steam Name";
            this.currSteam.Name = "currSteam";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 645);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn queueStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn queueTwitch;
        private System.Windows.Forms.DataGridViewTextBoxColumn queueSteam;
        private System.Windows.Forms.DataGridView currGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn currStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn currTwitch;
        private System.Windows.Forms.DataGridViewTextBoxColumn currSteam;
    }
}

