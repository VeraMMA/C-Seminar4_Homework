using System;

namespace homework
{
    class Program
    {
        static void Main()
        {
            Print("Напишите метод, который задаёт массив из N элементов и выводит их на экран.");
            Print("Введите количество элементов массива и заполните массив");
            int elementsCount = Convert.ToInt32(Console.ReadLine());
             Print("Заполните массив");
            int[] myArray = new int[elementsCount];

            for (int i = 0; i < myArray.Length; i++)
            {         
                 myArray[i] = Convert.ToInt32(Console.ReadLine());

            }
            Print("Вывод массива:");
            for (int j = 0; j < myArray.Length; j++)
            {
                System.Console.WriteLine(myArray[j]);
            }
        }
        public static void Print(string word)
        {
            Console.WriteLine(word);
        }

    }
}
