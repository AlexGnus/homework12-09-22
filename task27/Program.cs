﻿/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int SumDigit (int end)
{
  int result = 0;
  while (end >0) 
  {
    result = result + end%10;
    end = end/10;
  } 
  return result;
}
Console.WriteLine(SumDigit(number));
