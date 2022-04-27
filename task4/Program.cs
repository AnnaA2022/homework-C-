//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*using System;
Console.Clear();

int num=new Random().Next(100,1000);
string numS=num.ToString();
int a = Convert.ToInt32(numS[1].ToString());

Console.WriteLine($"{num}->{a}");*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*using System;
Console.Clear();
Console.Write("Введите число: ");
int num=int.Parse(Console.ReadLine());
if (num/100 == 0)
{
    Console.WriteLine($"{num}->третьего числа нет");
}
else
{
    string numS=num.ToString();
    int a = Convert.ToInt32(numS[2].ToString());
    Console.WriteLine($"{num}->{a}");
}*/

//Задача 15: Напишите программу,
// которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
using System;
Console.Clear();
Console.Write("Введите порядковый номер дня недели: ");
int num=int.Parse(Console.ReadLine());

string answer = (num==6)? $"{num} день недели - выходной":(num==7)? $"{num} день недели - выходной": $" {num} день недели - не выходной";
Console.WriteLine(answer);
