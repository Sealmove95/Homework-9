// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintArray(int N)
{
    if (N > 0)
    {
        Console.Write("{0} ", N);
        PrintArray(N - 1);
    }
}
Console.WriteLine("Enter number:");
int N = Convert.ToInt32(Console.ReadLine());
PrintArray(N);

