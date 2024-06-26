﻿//==========================================================================================================
// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

//==========================================================================================================

// Вводим длину 1-го массива
Console.WriteLine("Введите целое число (количество слов в массиве): ");
int n = int.Parse(Console.ReadLine());

// Создаем и заполняем первый массив
string[] FirstArray = new string[n];
for (int i = 0; i < n; i++)
{
    // Заполнение массива из консоли с проверкой на пустоту
    Console.WriteLine($"Добавьте словo № {i + 1}");
    FirstArray[i] = Console.ReadLine();
    while (string.IsNullOrEmpty(FirstArray[i]))
    {
        Console.WriteLine("Пожалуйста, введите слово еще раз и нажмите Enter: ");
        FirstArray[i] = Console.ReadLine();
    }
}

// Создание второго массива
string[] SecondArray = new string[n];
int secondArrayIndex = 0;

// Сортировка 3 и меньше, добавление во второй массив
for (int i = 0; i < n; i++)
{
    if (FirstArray[i].Length <= 3)
    {
        SecondArray[secondArrayIndex] = FirstArray[i];
        secondArrayIndex++;
    }
}

// Печать второго массива
Console.WriteLine("");
Console.Write("Слова, содержащие 3 или менее символов: ");
Console.Write("[");
for (int i = 0; i < secondArrayIndex; i++)
{
    if (i < secondArrayIndex - 1)
        Console.Write($"{SecondArray[i]}, ");
    else
        Console.Write($"{SecondArray[i]}");
}
Console.Write("]");