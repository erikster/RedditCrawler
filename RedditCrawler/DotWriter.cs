using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RedditCrawler
{
    /// <summary>
    /// Utility class to create .dot or .gv files that can be read as graphs in 
    /// GraphViz or Gephi.
    /// </summary>
    class DotWriter
    {
        private List<SubredditConnection> list;
        public DotWriter(List<SubredditConnection> list)
        {
            this.list = list;
        }

        public bool WriteToFile(string path)
        {
            try
            {
                File.Create(path); // overwrites old data, if any
                StreamWriter sw = new StreamWriter(path);
                sw.WriteLine("digraph {");
                foreach (SubredditConnection s in list)
                {
                    sw.WriteLine("\t" + s.ToString() +";");
                }
                sw.WriteLine("}");
                sw.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
