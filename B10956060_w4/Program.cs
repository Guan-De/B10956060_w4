using System;

namespace B10956060_w4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("請輸入一個整數：");
            string user = Console.ReadLine();
            int num = Convert.ToInt32(user);
            if(num % 2 == 1)
            {
                Console.WriteLine("Weird");
            }else if(num % 2 == 0){
                if (num >= 2 && num <= 5 || num > 20)
                {
                    Console.WriteLine("Not Weird");
                }
                if(num >= 6 && num <= 20)
                {
                    Console.WriteLine("Weird");
                }
            }
            */
            /*
            Console.Write("請輸入一個整數：");
            string user = Console.ReadLine();
            int num = Convert.ToInt32(user);

            int i, j;
            for (i = 1; i <= num; i++)
            {
                for (j = 0; j < i ; j++)
                    Console.Write("*");
                Console.WriteLine("");
            }
            Console.WriteLine("---------------");
            for (i = 1; i <= num; i++)
            {
                Console.WriteLine(num + "*" + i + "=" + num * i);
            }

            Console.WriteLine("---------------");
            Console.WriteLine("99乘法表");
            for (i = 1; i <= 9; i++)
            {
                for (j = 1; j <= 9; j++)
                {
                    Console.Write(i + "*" + j + "=" + i * j + "\t");
                }
                Console.WriteLine("");
            }
            */

            string[,] StuScore = new string[5, 5] { { "1", "Jack", "80", "75", "60" },
                { "2", "Mary", "65", "67", "62" },
                { "3", "Tom", "100", "93", "91" },
                { "4", "Grace", "98", "25", "50" },
                { "5", "Alice", "83", "82", "87" }
            };

            Console.Write("請輸入座號(1-5)：");
            string user = Console.ReadLine();
            int num = Convert.ToInt32(user);
            if (num >= 1 && num <= 5)
            {
                string name = StuScore[num - 1, 1];
                string cp = StuScore[num - 1, 2];
                string pr = StuScore[num - 1, 3];
                string ani = StuScore[num - 1, 4];

                Console.WriteLine("1.姓    名：" + name);
                Console.WriteLine("2.電腦概論：" + cp);
                Console.WriteLine("3.程式設計：" + pr);
                Console.WriteLine("4.動畫設計：" + ani);
            }
            else
            {
                Console.WriteLine("座號超出範圍");
            }
        }
    }
}

