using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_3001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.1");
            Console.WriteLine(opg1_1(7, 5, 3));
            Console.WriteLine();
            Console.WriteLine("1.2");
            try
            {
                Console.WriteLine(opg1_2(new string[] { "test", "lul", "ooops", "oger" }));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
            Console.WriteLine("1.3");
            foreach (var item in opg1_3(new int[] { 1, 5, 7, 4, 2, }))
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        static int opg1_1(int n1, int n2, int n3)
        {
            int highest = 0;

            if (n1 > highest)
            {
                highest = n1;
            }
            if (n2 > highest)
            {
                highest = n2;
            }
            if (n3 > highest)
            {
                highest = n3;
            }

            return highest;
        }

        static string opg1_2(string[] arr)
        {
            string returner = string.Empty;


            foreach (var item in arr)
            {
                if (char.IsLetter(item[0]))
                {
                    returner += char.ToUpper(item[0]) + item.Substring(1) + " ";
                }
                else
                {
                    throw new Exception("Word doesn't start with a letter yo");
                }
            }
            return returner;
        }

        static List<int> opg1_3(int[] arr)
        {
            return arr.OrderBy(p => p).ToList();
        }
    }
}

