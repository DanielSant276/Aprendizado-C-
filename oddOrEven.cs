using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            question();

            //Console.ReadLine();
        }

        static void question()
        {
            Console.Write("Digite um número: ");
            string stringToCheck = Console.ReadLine();

            int num = validation(stringToCheck);

            int result = num % 2;

            Console.WriteLine(oddOrEven(result)+ "\n");

            question();

        }

        static int validation(string check)
        {
            int numChecked;
            bool num = int.TryParse(check, out numChecked);

            if (num)
            {
                int number = Convert.ToInt32(check);
                return number;
            }
            else
            {
                Console.WriteLine("Não foi digitado um número\n");
                question();
                return numChecked;
            }
        }

        static string oddOrEven(int result)
        {
            string answer;
            switch (result)
            {
                case 0:
                    answer = "par";
                    break;
                case 1:
                    answer = "impar";
                    break;
                default:
                    answer = "erro";
                    break;
            }

            return answer;
        }
    }
}
