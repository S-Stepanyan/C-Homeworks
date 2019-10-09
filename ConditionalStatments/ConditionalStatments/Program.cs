using System;

namespace ConditionalStatments
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 % 2 == 0)
                    Console.WriteLine("num1>num2 zuyg");
                else
                    Console.WriteLine("num1<num2 kent"); 
            }
            else if (num1 < num2)
            {
                if (num2 % 2 == 0)
                {
                    Console.WriteLine("num2>num1 zuyg");

                }
                else { Console.WriteLine("num2>num1 kent"); }
            }
            else
            {
                if (num2 % 2 == 0)
                    Console.WriteLine("num1=num2 zuyg");
                else
                    Console.WriteLine("num1=num2 kent");
            }
        }
    }
}
