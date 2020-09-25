using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            string color, noun, someone;


            Console.Write("Escolha uma cor: ");
            color = Console.ReadLine();

            Console.Write("Escolha um substantivo: ");
            noun = Console.ReadLine();

            Console.Write("Escolha uma pessoa: ");
            someone = Console.ReadLine();

            Console.WriteLine("Rosas são " + color);
            Console.WriteLine(noun + " são azuis");
            Console.WriteLine("Eu amo " + someone);

            //Console.ReadLine();
        }
    }
}
