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
        }
    }
}
