using System;

namespace Number_swap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter First Number:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Second Number:");

            int n2 = int.Parse(Console.ReadLine());

            n1 = n1 + n2;
            n2 = n1 - n2;
            n1 = n1 - n2;
            Console.WriteLine("Swaping of Entered Number:" +n1+", " +n2);

        }
    }
}
