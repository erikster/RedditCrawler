using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

using HtmlAgilityPack;

namespace RedditCrawler
{
    /// <summary>
    /// Crawling class, downloads webpages from Reddit, searches them, then collects 
    /// and cleans the data. 
    /// </summary>
    class Crawler
    {
        private int num; // TODO: delete this var and verify this isn't used
                         // anywhere else in the program.
        private string status;

        public Crawler(int num)
        {
            this.num = num;
            status = "Not Started";
        }

        /// <summary>
        /// Don't make fun of this method. It works, even though it's messy.
        /// It calls the task method after checking to see if there are more 
        /// subreddits to explore.
        /// </summary>
        public void Main()
        {
            while (!MasterControl.stopRequested)
            {
                status = "Starting new sub search";
                try
                {
                    string subreddit = null;
                    lock (MasterControl.subsToExplore)
                    {
                        if (MasterControl.subsToExplore.Count > 0)
                        {
                            try
                            {
                                subreddit = MasterControl.subsToExplore.Dequeue();
                                lock (MasterControl.subsAlreadyExplored)
                                {
                                    if (MasterControl.subsAlreadyExplored.Contains(subreddit))
                                    {
                                        continue;
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                subreddit = null;
                            }
                        }
                    }
                    if (subreddit == null)
                    {
                        Thread.Sleep(1000 * 5); // 5 second sleep
                    }
                    else
                    {
                        lock (MasterControl.subsAlreadyExplored)
                        {
                            MasterControl.subsAlreadyExplored.Add(subreddit);
                        }
                        Task(subreddit);
                    }
                }
                catch (Exception ex)
                {
                    // crawling failed
                    status = "Top level failure! Crawling terminated!\n\n" + ex.Message;
                }
            }
            // End
        }

        /// <summary>
        /// Downloads a subreddit's front page, isolates the div containing the 
        /// sidebar of the subreddit, and then searches for links to other 
        /// subreddits. It then adds those connections to the volatile List of 
        /// SubredditConnections.
        /// </summary>
        /// <param name="subreddit"></param>
        private void Task(string subreddit)
        {
            status = "Exploring /r/" + subreddit;
            HtmlNode rootDiv;
            try
            {
                HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc = web.Load("http://www.reddit.com/r/" + subreddit);
                var root = from foo in doc.DocumentNode.SelectNodes("//div[@class='titlebox']")
                               select foo;
                rootDiv = root.ToArray<HtmlNode>()[0];
            }
            catch (Exception ex)
            {
                // could not find or load or isolate the required <div>
                return;
            }
            List<string> subs = exploreRoot(rootDiv);
            subs = filteredLinks(subs);
            lock (MasterControl.subsToExplore)
            {
                foreach (string s in subs) // these are filtered subreddit names
                {
                    MasterControl.subsToExplore.Enqueue(s);
                }
            }
            addListToConnectionList(subreddit, subs);
        }

        /// <summary>
        /// Recursive method that searches for the "a" html tag and returns a 
        /// list of all links that are inside the sidebar.
        /// </summary>
        /// <param name="root">
        /// The div element containing the sidebar of a subreddit
        /// </param>
        /// <returns></returns>
        private List<string> exploreRoot(HtmlNode root)
        {
            List<string> results = new List<string>();
            if (root.HasChildNodes)
            {
                foreach (HtmlNode hn in root.ChildNodes)
                {
                    results.AddRange(exploreRoot(hn)); // recursion
                }
            }
            // still want to explore root, even if it has children
            if (root.Name.Equals("a"))
            {
                results.Add(root.Attributes["href"].Value);
            }
            return results;
        }

        /// <summary>
        /// Filters links using Regex to detect subreddit names. Still not 
        /// perfected, as it will allow subreddit names that have 
        /// link anchors (subname#anchor) or query strings (link?querystr)
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        private List<string> filteredLinks(List<string> list)
        {
            List<string> results = new List<string>();
            foreach (string s in list)
            {
                Regex r = new Regex(@"(http://)?(www\.)?(reddit\.com)?/r/([A-Za-z0-9]{1,20})", RegexOptions.IgnoreCase);
                if (r.IsMatch(s))
                {
                    int startOfSubName = s.IndexOf("/r/") + 3;
                    string str = s.Substring(startOfSubName); // str is formatted string
                    int endOfSubName = str.IndexOf('/');
                    if (endOfSubName > 0)
                        str = str.Substring(0, endOfSubName);
                    if (str.Contains("+"))
                        continue; // ignore multi-reddits
                    lock (MasterControl.subsAlreadyExplored)
                    {
                        if (MasterControl.subsAlreadyExplored.Contains(str))
                            continue;
                    }
                    if (!results.Contains(str.ToLower())) // eliminates repetition
                        results.Add(str.ToLower());
                }
            }
            return results;
        }

        /// <summary>
        /// locks the volatile connectedSubs list and adds the new 
        /// subredditconnection
        /// </summary>
        /// <param name="baseSub"></param>
        /// <param name="subs"></param>
        private void addListToConnectionList(string baseSub, List<string> subs)
        {
            lock (MasterControl.connectedSubs)
            {
                foreach (string s in subs)
                {
                    SubredditConnection sc = new SubredditConnection(baseSub, s);
                    MasterControl.connectedSubs.Add(sc);
                }
            }
        }

        public string Status
        {
            get { return status; }
            set { }
        }
    }
}
