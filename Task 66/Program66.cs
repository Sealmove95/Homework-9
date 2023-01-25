// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Enter number one:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number two:");
int m = Convert.ToInt32(Console.ReadLine());
int s = 0;
for (int i = n; i <= m; i++)
{
  if (i % 1 == 0)
    s = s + i;
}
Console.WriteLine(s);