// Задача 29: Напишите метод, который задаёт массив из N элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

using System;

namespace homework
{
    class Program
    {
        static void Main()
        {
            Print("Напишите метод, который задаёт массив из N элементов и выводит их на экран.");
            Print("Введите количество элементов массива");
             int elementsCount = Convert.ToInt32(Console.ReadLine());

            int [] myArray = new int [elementsCount ];
            
             for (int i = 0; i < myArray.Length; i++)
             {
                Print($"Заполните массив {i}:");
                myArray[i] = Convert.ToInt32(Console.ReadLine());
             }
                
              for (int i = 0; i < myArray.Length; i++)
              {
                System.Console.WriteLine(myArray[i]);
              }
        }
        public static void Print(string word)
        {
            Console.WriteLine(word);
        }
 
    }
}
