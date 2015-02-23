using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RedditCrawler
{
    /// <summary>
    /// Contains all of the volatile data structures that are used to collect data 
    /// from the crawlers.
    /// </summary>
    class MasterControl
    {
        public static volatile Queue<string> subsToExplore      = new Queue<string>();
        public static volatile List<string> subsAlreadyExplored = new List<string>();
        public static volatile List<string> failedToExploreSubs = new List<string>();
        public static volatile List<SubredditConnection> connectedSubs = 
            new List<SubredditConnection>();
        public static volatile bool stopRequested;
    }
}
