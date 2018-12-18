using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Algorithms.Warmup
{
    public class TimeConversion
    {
        /// <summary>
        /// This is the solution only, for implementation and test cases view the below URL
        /// https://www.hackerrank.com/challenges/time-conversion/problem
        /// </summary>
        public static string timeConversion(string s)
        {
            var time = new string(s.Take(8).ToArray()).Split(':');
            if (s[8] == 'P' && time[0] != "12")
            {
                time[0] = (Convert.ToInt32(time[0]) + 12).ToString();
                if (time[0] == "24")
                    time[0] = "00";
            }
            else if (s[8] == 'A' && time[0] == "12")
            {
                time[0] = "00";
            }
            return string.Format("{0}:{1}:{2}", time[0], time[1], time[2]);
        }
    }
}
