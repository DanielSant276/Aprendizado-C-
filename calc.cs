using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Coloque um número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Coloque outro número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(num1 + num2);

            //Console.ReadLine();
        }
    }
}
