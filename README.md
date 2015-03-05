# RedditCrawler
An application designed to discover subreddits and how they are connected.

RedditCrawler starts with the default subreddits and looks in the sidebar for that subreddit to pick up links to new subreddits. Each subreddit found is added to a queue of subreddits to search, and the four threads will continue to search for new subreddits (note that subreddits already searched are added to a set of searched subreddits). Each result is listed with a link from the searched to the discovered subreddit.

The results were then cleaned and visualized using Gephi.

TODO: This code is old (three years) and the directories are messy. Need to modify the code to clean up the results (anchor links got caught as separate subreddits). Additionally, we should take advantage of Reddit's API instead of downloading and parsing entire HTML documents.
