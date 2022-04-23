// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int max = 0;
if (a<b)
{
    max = b ;
}
else 
{
    max = a ; 
}
if (c<max)
{
    Console.WriteLine($"наибольшее число {max}");
}
else
{
  Console.WriteLine($"наибольшее число {c}");
} 