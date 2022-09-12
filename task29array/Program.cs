﻿/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/
int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i=0; i< array.Length; i++)
    {
        array[i] = new Random().Next(0,1000);
    }
    return array;
}
int[] resultArray = GetArray(8);
Console.WriteLine($"Result array: [{String.Join("; ", resultArray)}]");

  