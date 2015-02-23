using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace RedditCrawler
{
    public partial class Form1 : Form
    {
        Crawler c1;
        Crawler c2;
        Crawler c3;
        Crawler c4;
        Thread t1;
        Thread t2;
        Thread t3;
        Thread t4;
        
        public Form1()
        {
            InitializeComponent();
            c1 = new Crawler(1);
            c2 = new Crawler(2);
            c3 = new Crawler(3);
            c4 = new Crawler(4);
            t1 = new Thread(c1.Main);
            t2 = new Thread(c2.Main);
            t3 = new Thread(c3.Main);
            t4 = new Thread(c4.Main);

            lock (MasterControl.subsToExplore)
            {
                // default subs
                string[] subs = { "pics",
                                    "funny",
                                    "politics",
                                    "adviceanimals",
                                    "announcements",
                                    "askreddit",
                                    "atheism",
                                    "aww",
                                    "bestof",
                                    "blog",
                                    "gaming",
                                    "iama",
                                    "movies",
                                    "music",
                                    "science",
                                    "technology",
                                    "todayilearned",
                                    "videos",
                                    "worldnews",
                                    "news",
                                    "wtf" };
                foreach (string s in subs)
                {
                    MasterControl.subsToExplore.Enqueue(s);
                }
            }
        }      

        private void inputRTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ProcessCommand(inputRTB.Text);
                inputRTB.Clear();
            }
        }

        private void ProcessCommand(string cmd)
        {
            char[] seperators = { ' ' };
            string[] args = cmd.Split(seperators);
            for (int i = 0; i < args.Length; i++)
            {
                args[i] = args[i].Replace("\n", "");
            }
            if (args[0].Equals("echo", StringComparison.CurrentCultureIgnoreCase))
            {
                if (args.Length < 2)
                    return;
                StringBuilder sb = new StringBuilder();
                for (int i = 1; i < args.Length; i++)
                {
                    sb.Append(args[i] + " ");
                }
                mainConsoleRTB.AppendText(sb.ToString() + "\n");
            }
            else if (args[0].Equals("start", StringComparison.CurrentCultureIgnoreCase))
            {
                mainConsoleRTB.AppendText("Starting the crawling!\n");
                t1.Start();
                t2.Start();
                t3.Start();
                t4.Start();
                timer1.Start();
            }
            else if (args[0].Equals("stop", StringComparison.CurrentCultureIgnoreCase))
            {
                mainConsoleRTB.AppendText("Ending the crawling!\n");
                MasterControl.stopRequested = true;
            }
            else
            {
                mainConsoleRTB.AppendText("Command not recognized\n");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainConsoleRTB.AppendText("Welcome to RedditCrawler\n");
        }

        private void inputRTB_Leave(object sender, EventArgs e)
        {
            // only add text if user defocuses without adding input
            if (inputRTB.Text.Length == 0)
            {
                inputRTB.Clear();
                inputRTB.Text = "<Enter Commands Here>";
            }
        }

        private void inputRTB_Enter(object sender, EventArgs e)
        {
            if (inputRTB.Text.Equals("<Enter Commands Here>"))
            {
                inputRTB.Clear();
            }
        }

        public void WriteLineToThreadBox(string arg, int box)
        {
            try
            {
                RichTextBox rtb = (RichTextBox)this.Controls["thread" + box.ToString() + "RTB"];
                rtb.AppendText(arg + "\n");
            }
            catch (Exception ex)
            {
                mainConsoleRTB.AppendText("ERROR! Could not write to thread RichTextBox." +
                    "\nAttempted to write to box number: " + box.ToString() + "\n");
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            ProcessCommand(inputRTB.Text);
            inputRTB.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MasterControl.stopRequested = true;
            DialogResult dr = MessageBox.Show("Write progress to file?", "Before you leave...", MessageBoxButtons.YesNo);
            if (dr.Equals(DialogResult.Yes))
            {
                lock (MasterControl.connectedSubs)
                {
                    DotWriter dw = new DotWriter(MasterControl.connectedSubs);
                    dw.WriteToFile(@"C:\Users\Erik\Documents\Visual Studio 2010\Projects\CS\RedditCrawler\result.gv");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MasterControl.stopRequested)
            {
                timer1.Stop();
            }
            else
            {
                thread1RTB.Text = "Crawler 1 Status:\n" + c1.Status;
                thread2RTB.Text = "Crawler 2 Status:\n" + c2.Status;
                thread3RTB.Text = "Crawler 3 Status:\n" + c3.Status;
                thread4RTB.Text = "Crawler 4 Status:\n" + c4.Status;
                //if (c1.Status.Equals("Starting new sub search"))
                //{
                //  TODO: Include logic to end program after all crawlers are "waiting" for 5 min
                //}
            }
        }

    }
}
