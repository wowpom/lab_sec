using System;

namespace lab_sec
{
    class Program
    {
        private static void Menu()
        {
            Console.WriteLine("Введите число");
            if (Palindrome.IsPalindrome(Convert.ToString(Console.ReadLine())) == true) 
            {
                Console.WriteLine("Это палиндром");
            }
            else
                Console.WriteLine("Это не палиндром\n");

            Console.WriteLine("Вы хотите ввести ещё одно число? \n Введите 1 если да");
            if (Console.ReadLine() == "1")
                Menu();

        }
        static void Main(string[] args)
        {
            Menu();
        }
    }
}
