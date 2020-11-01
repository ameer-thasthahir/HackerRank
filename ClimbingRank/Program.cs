using System;
using System.Collections.Generic;
using System.Linq;

namespace ClimbingRank
{
    class Program
    {
        public int FindTheIndex(List<int> array, int k, int ls, int re)
        {
            if (re >= ls)
            {

                int m = (re + ls) / 2;

                if (array[m] == k)
                {
                    return m + 1;
                }
                if (array[m] < k)
                {
                    return m + 2;
                }

                if (array[m] > k)
                {
                    return FindTheIndex(array, k, m + 1, re);

                }
                return FindTheIndex(array, k, m - 1, ls);
            }
            return array.Count + 1;
        }

        public List<int> climbingLeaderboard(List<int> ranked, List<int> player)
        {
            var value = ranked.Distinct().ToList();

            List<int> rank = new List<int>();

            foreach (var i in player)
            {
                rank.Add(FindTheIndex(value, i, 0, value.Count - 1));
            }
            return rank;
        }

        public int BinarySearch(List<int> array, int k, int l, int r)
        {
            if (l <= r)
            {
                int m = (l + r) / 2;
                if (array[m] == k)
                {
                    return m;
                }
                if (array[m] > k)
                {
                    return BinarySearch(array, k, l, m - 1);
                }

                return BinarySearch(array, k, m + 1, r);
            }

            return -1;
        }
        static void Main(string[] args)
        {
            var ranked = new List<int>() { 10, 20, 40, 50, 60, 70 };
            var player = new List<int>() { 70,50,40,30};
           
            List<int> temp = new List<int>();
            foreach(var rank in player)
            {
                var value = new Program().BinarySearch(ranked,rank, 0, ranked.Count - 1);
                Console.WriteLine(value);
            }            

        }
    }
}
