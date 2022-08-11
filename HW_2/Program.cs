//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int numberA = ReadInt("Введите число: ");

if (numberA >999)
{
while (numberA > 999)
{
    numberA = numberA / 10;
}

}
if (numberA < 100)
{
    Console.WriteLine(" третьей цифры нет ");
}
else
{
    Console.WriteLine(numberA %10);
}

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}