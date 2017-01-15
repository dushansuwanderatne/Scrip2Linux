using System;

namespace SCRIPAU.Automation.Subtests
{
    public static class GeneralUtility
    {
        /// <summary>
        /// Used to check if a string contains a substring of text
        /// for example:
        /// string myString = "Hello World";
        /// Bool result = myString.Contains("hello", StringComparison.CurrentCultureIgnoreCase);
        /// </summary>
        /// <param name="source"></param>
        /// <param name="toCheck"></param>
        /// <param name="comp"></param>
        /// <returns></returns>
        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source.IndexOf(toCheck, comp) >= 0;
        }

        public static TimeSpan ConvertToTimeSpan(this string timeSpanAsString)
        {
            //Assumes its in the formaat of HH:MMM:SS
            string[] myTimeArr = timeSpanAsString.Split(':');
            TimeSpan myReturnValue = new TimeSpan(Convert.ToInt32(myTimeArr[0]), Convert.ToInt32(myTimeArr[1]), Convert.ToInt32(myTimeArr[2]));

            return myReturnValue;
        }
    }

    /// <summary>
    /// A stop which can be used to mark differences between time
    /// and provide timeout functionality
    /// </summary>
    public class StopClock
    {
        private DateTime timeStarted;

        public StopClock()
        {
            timeStarted = DateTime.Now;
        }

        /// <summary>
        /// Checks if the specified time limit has been reached based on the time started
        /// </summary>
        /// <param name="timeLimit"></param>
        /// <param name="timeStarted"></param>
        /// <returns></returns>
        public bool CheckTime(TimeSpan timeLimit)
        {
            bool withinTimeLimit = false;
            DateTime now = DateTime.Now;

            DateTime limit = timeStarted + timeLimit;

            if (now < limit)
            {
                withinTimeLimit = true;
            }
            else
            {
                withinTimeLimit = false;
            }

            return withinTimeLimit;
        }

        /// <summary>
        /// Start the StopClock
        /// </summary>
        public void Start()
        {
            timeStarted = DateTime.Now;
        }
    }
}