// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

using System;

int N =int.Parse(Console.ReadLine());
int b = 2;

while (b<=N)
{
   if (b % 2 == 0) 
   {
       Console.Write($"{b} ");
       b++;
   }
   else
   {
       b++;
   }
}
