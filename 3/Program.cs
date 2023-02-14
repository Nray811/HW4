using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入您的生日，格式請使用: yyyy/mm/d");
            string[] s = Console.ReadLine().Split('/');
            int result = 0; //給訂初始值
            int[] numbers = Array.ConvertAll(s, n => int.Parse(n));
            Console.WriteLine("妳的生日為:" + "西元" + numbers[0]+ "年" + numbers[1] + "月" + numbers[2] + "日");
            for (int i = 0; i < s.Length; i++)
            {
                if (numbers[i] > 1000) //千位數
                {
                    numbers[i] = numbers[i] % 10 + (numbers[i] / 10 % 10) + (numbers[i] / 100 % 10) +(numbers[i] / 1000 % 10);
                }       
                
                else if (numbers[i] > 10) //十位數
                {
                    numbers[i] = numbers[i] % 10 + (numbers[i] / 10 % 10);
                }

                else if (numbers[i] < 10)  //個位數
                {
                    numbers[i] = numbers[i] % 10;
                }
                    result = result + numbers[i];

                if (result >10)  // 總和>10 result = 十位數字+個位數字
                {
                    result = (result / 10 % 10) + (result % 10);
                    if (result == 10)   //如加起來剛好又是10的話，result直接設定1 (生命靈數為1~9)
                        {
                        result = 1;
                    }
                }                      
                else if (result == 10) //總和剛好為10  result直接設定1
                {
                    result = 1;
                }
                else   
                {
                    result = (result % 10);    //總和<10  result=個位數字
                }

            }
         
            Console.WriteLine($"生命靈數為：{result} ");
            Console.ReadKey();





        }


    }
}


