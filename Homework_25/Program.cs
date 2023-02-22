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
        static void Main()
        {
            Print("Возвести число A в натуральную степень B.");

            Print("Введите число A:");
            int numberA = Convert.ToInt32(Console.ReadLine());
            Print("Введите натуральную степень B.:");
            int degreeB = Convert.ToInt32(Console.ReadLine());
            
           Degree(numberA, degreeB);
           
            
        }
        public static void Print(string word)
        {
            Console.WriteLine(word);
        } 

           static void Degree (int numberA, int degreeB)
        {          
            double  result =  Math.Pow(numberA, degreeB);
            System.Console.WriteLine(result);
        }

        
        
    }
}
