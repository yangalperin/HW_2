//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

int numberA = ReadInt("Введите число от одного до семи: ");

if(8 > numberA && numberA > 5)
{
    Console.WriteLine("Ура - выходной");
}
else if(0 < numberA && numberA < 6)
{
    Console.WriteLine("No");
}
else
{
    Console.WriteLine("Нет такого дня недели");
}
int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}