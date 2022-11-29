// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (-100 < number && number < 100) Console.WriteLine($"{number} -> третьей цифры нет");
Console.Write($"{number} -> ");
while (-999 > number || number > 999)
{
    number = number / 10;
}
int number_3 = number % 10;
Console.Write(number_3);
