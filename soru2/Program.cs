using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input:");
           
            string input = Console.ReadLine();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0)
                {
                    dict.Add(input[i], 0);
                }
                else if (input[i] == input[i-1])
                {
                    dict.Remove(input[i]);
                    dict.Add(input[i], 2);
                }
                else
                {
                    if (!dict.ContainsKey(input[i]))
                    {
                        dict.Add(input[i], 1);
                    }
                }
            }

            Console.WriteLine("Output:");
            foreach (var item in dict)
            {
                for (int i = 0; i < item.Value; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine(item.Key);
            }

            Console.Read();
        }
    }

}
