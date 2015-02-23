namespace RedditCrawler
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
            this.components = new System.ComponentModel.Container();
            this.thread1RTB = new System.Windows.Forms.RichTextBox();
            this.thread2RTB = new System.Windows.Forms.RichTextBox();
            this.thread3RTB = new System.Windows.Forms.RichTextBox();
            this.thread4RTB = new System.Windows.Forms.RichTextBox();
            this.mainConsoleRTB = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputRTB = new System.Windows.Forms.RichTextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.remainingTxtBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // thread1RTB
            // 
            this.thread1RTB.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thread1RTB.Location = new System.Drawing.Point(478, 68);
            this.thread1RTB.Name = "thread1RTB";
            this.thread1RTB.ReadOnly = true;
            this.thread1RTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.thread1RTB.Size = new System.Drawing.Size(281, 182);
            this.thread1RTB.TabIndex = 10;
            this.thread1RTB.TabStop = false;
            this.thread1RTB.Text = "";
            // 
            // thread2RTB
            // 
            this.thread2RTB.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thread2RTB.Location = new System.Drawing.Point(765, 68);
            this.thread2RTB.Name = "thread2RTB";
            this.thread2RTB.ReadOnly = true;
            this.thread2RTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.thread2RTB.Size = new System.Drawing.Size(281, 182);
            this.thread2RTB.TabIndex = 11;
            this.thread2RTB.TabStop = false;
            this.thread2RTB.Text = "";
            // 
            // thread3RTB
            // 
            this.thread3RTB.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thread3RTB.Location = new System.Drawing.Point(478, 375);
            this.thread3RTB.Name = "thread3RTB";
            this.thread3RTB.ReadOnly = true;
            this.thread3RTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.thread3RTB.Size = new System.Drawing.Size(281, 182);
            this.thread3RTB.TabIndex = 12;
            this.thread3RTB.TabStop = false;
            this.thread3RTB.Text = "";
            // 
            // thread4RTB
            // 
            this.thread4RTB.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thread4RTB.Location = new System.Drawing.Point(765, 375);
            this.thread4RTB.Name = "thread4RTB";
            this.thread4RTB.ReadOnly = true;
            this.thread4RTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.thread4RTB.Size = new System.Drawing.Size(281, 182);
            this.thread4RTB.TabIndex = 13;
            this.thread4RTB.TabStop = false;
            this.thread4RTB.Text = "";
            // 
            // mainConsoleRTB
            // 
            this.mainConsoleRTB.BackColor = System.Drawing.SystemColors.MenuText;
            this.mainConsoleRTB.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainConsoleRTB.ForeColor = System.Drawing.Color.Chartreuse;
            this.mainConsoleRTB.Location = new System.Drawing.Point(12, 12);
            this.mainConsoleRTB.Name = "mainConsoleRTB";
            this.mainConsoleRTB.ReadOnly = true;
            this.mainConsoleRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.mainConsoleRTB.Size = new System.Drawing.Size(384, 610);
            this.mainConsoleRTB.TabIndex = 99;
            this.mainConsoleRTB.TabStop = false;
            this.mainConsoleRTB.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(521, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Crawler One";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(810, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Crawler Two";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(506, 558);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Crawler Three";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(801, 558);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Crawler Four";
            // 
            // inputRTB
            // 
            this.inputRTB.BackColor = System.Drawing.SystemColors.MenuText;
            this.inputRTB.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputRTB.ForeColor = System.Drawing.Color.Chartreuse;
            this.inputRTB.Location = new System.Drawing.Point(12, 628);
            this.inputRTB.Name = "inputRTB";
            this.inputRTB.Size = new System.Drawing.Size(384, 53);
            this.inputRTB.TabIndex = 0;
            this.inputRTB.Text = "";
            this.inputRTB.Enter += new System.EventHandler(this.inputRTB_Enter);
            this.inputRTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputRTB_KeyPress);
            this.inputRTB.Leave += new System.EventHandler(this.inputRTB_Leave);
            // 
            // sendBtn
            // 
            this.sendBtn.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.Location = new System.Drawing.Point(402, 628);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(234, 53);
            this.sendBtn.TabIndex = 100;
            this.sendBtn.Text = "Send (Enter key)";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(660, 648);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(306, 19);
            this.label5.TabIndex = 101;
            this.label5.Text = "Remaining Subs to Explore: ";
            // 
            // remainingTxtBox
            // 
            this.remainingTxtBox.Location = new System.Drawing.Point(960, 646);
            this.remainingTxtBox.Name = "remainingTxtBox";
            this.remainingTxtBox.ReadOnly = true;
            this.remainingTxtBox.Size = new System.Drawing.Size(112, 22);
            this.remainingTxtBox.TabIndex = 102;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 60000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 695);
            this.Controls.Add(this.remainingTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.inputRTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainConsoleRTB);
            this.Controls.Add(this.thread4RTB);
            this.Controls.Add(this.thread3RTB);
            this.Controls.Add(this.thread2RTB);
            this.Controls.Add(this.thread1RTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "RedditCrawler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox thread1RTB;
        private System.Windows.Forms.RichTextBox thread2RTB;
        private System.Windows.Forms.RichTextBox thread3RTB;
        private System.Windows.Forms.RichTextBox thread4RTB;
        private System.Windows.Forms.RichTextBox mainConsoleRTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox inputRTB;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox remainingTxtBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

