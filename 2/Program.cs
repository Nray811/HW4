using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("以字串的方式輸入一個用逗號區隔的整數數列，將其中的數字依照奇偶數分成兩個數列後，以字串的方式輸出");
            string[] s = Console.ReadLine().Split(',');           
            int[] numbers = Array.ConvertAll(s, n => int.Parse(n));           
            List<int> oddList = new List<int> { };
            List<int> evenList = new List<int> { };            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenList.Add(numbers[i]);
                }
                else
                {
                    oddList.Add(numbers[i]);
                }               
            }

            Console.WriteLine($"奇數：{string.Join(",", oddList)}");
            Console.WriteLine($"偶數：{string.Join(",", evenList)}");
            Console.ReadKey();
        }

    }
}