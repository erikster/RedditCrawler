using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RedditCrawler
{
    /// <summary>
    /// Class to record subreddit connections. The first string represents the 
    /// subreddit that has external links, while the second string represents the 
    /// subreddit that it connects to.
    /// </summary>
    class SubredditConnection
    {
        public string first;
        public string second;

        public SubredditConnection(string first, string second)
        {
            this.first = first;
            this.second = second;
        }

        public override string ToString()
        {
            return first.ToString() + " -> " + second.ToString();
        }

        /// <summary>
        /// Shameful method, please don't read.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            // not equal if not same type
            if (!obj.GetType().Equals(new SubredditConnection(null, null).GetType()))
                return false;
            // return equal if fields first and second match (works for digraphs only)
            return ((SubredditConnection)obj).first.Equals(this.first, StringComparison.CurrentCultureIgnoreCase) &&
                ((SubredditConnection)obj).second.Equals(this.second, StringComparison.CurrentCultureIgnoreCase);
        }

        public override int GetHashCode()
        {
            return first.GetHashCode();
        }
    }
}
