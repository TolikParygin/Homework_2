﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
Console.Write("Введите день недели от 1 до 7: ");
int number = int.Parse(Console.ReadLine());
if (number >= 1 && number <= 5)
{
    Console.Write($"{number} -> будни");
}
else if (5 < number && number < 8)
{
    Console.Write($"{number} -> выходной");
}
else
{
    Console.Write($"{number} -> ТАКОГО ДНЯ НЕДЕЛИ НЕ СУЩЕСТВУЕТ!!!!!!!!");
}