// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (a<b)
{
    Console.WriteLine($"наименьшее число {a }");
    Console.WriteLine($"наибольшее число {b }");
}
else 
{
    Console.WriteLine($"наименьшее число {b }");
    Console.WriteLine($"наибольшее число {a }");
}