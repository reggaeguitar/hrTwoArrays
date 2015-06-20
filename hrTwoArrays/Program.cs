using System;
using System.Linq;

namespace hrTwoArrays
{
    class Program
    {
        static void Main()
        {
            var numCases = Int32.Parse(Console.ReadLine());
            while (numCases-- > 0)
            {
                var nAndK = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
                var numInts = nAndK[0];
                var k = nAndK[1];
                var a = Console.ReadLine().Split(' ').Select(Int32.Parse).OrderBy(x => x).ToArray();
                var b = Console.ReadLine().Split(' ').Select(Int32.Parse).OrderByDescending(x => x).ToArray();
                bool good = true;
                for (int i = 0; i < numInts; ++i)
                {
                    if (a[i] + b[i] < k)
                    {
                        good = false;
                        break;
                    }
                }
                Console.WriteLine(good ? "YES" : "NO");
            }
        }
    }
}
