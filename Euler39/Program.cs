using System;
using System.Collections.Generic;
using System.Linq;

namespace Euler39
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> results = new Dictionary<int, int>();
            foreach(int a in Enumerable.Range(1, 1000))
            {
                foreach(int b in Enumerable.Range(a, 1000 - a))
                {
                    int c = (int) Math.Truncate(Math.Sqrt(a * a + b * b));
                    if((a + b + c <= 1000) && (a * a + b * b - c * c == 0))
                    {
                        if (results.ContainsKey(a + b + c))
                            results[a + b + c]++;
                        else
                            results.Add(a + b + c, 1);
                    }
                }
            }

            Console.WriteLine(results.Keys.Where(x => results[x] == results.Values.Max()).First());
            Console.ReadLine();
        }
    }
}
