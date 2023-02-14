using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Run 數字1~300 對應不同的水果");

            for (int i = 1; i <= 300; i++)
            {

                if (i % 2 == 0 && i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("peach");
                }

                else if (i % 2 == 0 && i % 3 == 0 )
                {
                    Console.WriteLine("watermelon");
                }
                else if (i % 2 == 0) 
                {
                    Console.WriteLine("apple");
                }
                else if (i % 3 == 0) 
                {
                    Console.WriteLine("banana");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("grape");
                }


                else
                {
                    Console.WriteLine(i);
                }
            }

                Console.ReadLine();

        }
    }
}
