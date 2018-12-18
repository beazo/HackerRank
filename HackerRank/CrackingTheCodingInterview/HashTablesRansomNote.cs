using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.CrackingTheCodingInterview
{
    public class HashTablesRansomNote
    {
        /// <summary>
        /// This is the solution only, for implementation and test cases view the below URL
        /// https://www.hackerrank.com/challenges/ctci-ransom-note/problem
        /// </summary>
        public static void checkMagazine(string[] magazine, string[] note)
        {
            Array.Sort(magazine);
            Array.Sort(note);

            List<string> magList = magazine.ToList();

            var found = note.All(ransom_w => magList.Remove(ransom_w));

            Console.WriteLine(found ? "Yes" : "No");
        }
    }
}
