using System;

namespace B10956060_w4
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
