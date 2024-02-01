//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//длина которых меньше, либо равна 3 символам.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//Start program
using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("------------------------------------------------------------------------------------------");
        Console.WriteLine("|   Данная программа позволяет из имеющегося массива строк                               |");
        Console.WriteLine("|   сформировать новый массив строк, длина которых меньше, либо равна 3 символам         |");
        Console.WriteLine("------------------------------------------------------------------------------------------");

        //Формируем массив строк
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Сначала введите количество строк в массиве: ");
        int arrayLen = Convert.ToInt32(Console.ReadLine());
        string[] inputArray = new string[arrayLen];
        for (int i = 0; i < arrayLen; i++)
        {
            Console.Write($"Введите строку №{i + 1}: ");
            inputArray[i] = Console.ReadLine();
        }
        //Печатаем массив пользователя
        Console.WriteLine("Исходный массив: " + "<<<" + string.Join(">>>  <<<", inputArray) + ">>>");

        string[] outputArray = new string[arrayLen]; //Создаем новый массив строк, в котором длина строк будет меньше или равнв 3 символам
        int outArrayLen = 0; //Определяем счетчик для длины нового массива
        for (int i = 0; i < arrayLen; i++)
        {
            int curStringLen = inputArray[i].Length;
            if (curStringLen <= 3)
            {
                outputArray[outArrayLen] = inputArray[i]!;
                outArrayLen++;
            }
        }
        //Создаем финальный массив
        string[] resultArray = new string[outArrayLen];
        Array.Copy(outputArray, resultArray, outArrayLen);
        //Печатаем результирующий массив
        Console.WriteLine("Результирующий массив: " + "<<<" + string.Join(">>>  <<<", resultArray) + ">>>");
        Console.WriteLine("------------------------------------------------------------------------------------------");
        Console.WriteLine("|   Программа завершила работу! До новых встреч!                                         |");
        Console.WriteLine("------------------------------------------------------------------------------------------");
    }
}