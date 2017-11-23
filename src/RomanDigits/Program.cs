using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanDigits
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var Arabic = new int[16];
            var Roman = new string[16];
            using (TextReader reader = File.OpenText("Data.txt"))
            {
                string line;
                for (int i=0; ;i++)
                {
                    line = reader.ReadLine();
                    if (line == null) break;
                    var bits = line.Split(' ');
                    Arabic[i] = int.Parse(bits[0]);
                    Roman[i] = bits[1];

                }
            }
            var output = new StringBuilder("");
            var l = Roman.Length;
            var input = Console.ReadLine();
            var num = int.Parse(input);
            for (var i = l-1; i>=0; i--)
            {
                if (num < Arabic[i]) continue;
                output.Append(Roman[i]);
                num -= Arabic[i];
                i = l;
                continue;
            }
            Console.WriteLine(input+ " in Roman is " + output);
            Console.ReadKey();
        }
    }
}
