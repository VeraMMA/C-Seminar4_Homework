// Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в 

//натуральную степень B.
// нельзя использовать Math.Pow
// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

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
            Print("Возвести число A в натуральную степень B.");

            Print("Введите число A:");
            int numberA = Convert.ToInt32(Console.ReadLine());
            Print("Введите натуральную степень B.:");
            int degreeB = Convert.ToInt32(Console.ReadLine());
             
             Rate(numberA, degreeB);
            
           
        }
           public static void  Rate (int numberA, int degreeB)
           {
                int t = numberA;

            for (int i = 1; i < degreeB; i++)
            {
                t = t * numberA;
            }
               Console.WriteLine("Число A в натуральную степень B равно:" + t);
           }
    }             
}
