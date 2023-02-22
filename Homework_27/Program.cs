// Задача 27:

// 452 -> 11

// 82 -> 10

// 9012 -> 12

using System;

namespace homework
{
    class Program
    {
        public static void Print(string word)
        {
            Console.WriteLine(word);
        }
        static void Main()
        {
            Print("Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.");


            string digit = Console.ReadLine();
            int i = Convert.ToInt32(digit);

            for (i =  1; i < digit.Length; i++)
            {
                Console.Write(digit[i]%10);
            }


        }

    }



}
