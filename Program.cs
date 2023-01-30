using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = new FizzBuzz();

            Console.WriteLine("Witaj w grze FizzBuzz!");

            while (true)
            {
                Console.WriteLine("Podaj swoją liczbę: ");

                var numberOfUser = GetNumber();

                Console.WriteLine(number.Calculate(numberOfUser));
            }
        }

        private static int GetNumber()
        {
            while (true)
            {
                if(!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Podałeś nieprawidłową liczbę, spróbuj jeszcze raz!");
                    continue;
                }

                return number;
            }
        }
    }
}
