//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1


int numberA = ReadInt("Введите трехзначное число: ");
int numberB = (numberA %100)/10;
Console.WriteLine(numberB);

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}