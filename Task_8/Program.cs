//Задача 8: Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Введите 1 число диапозона: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите 2 число диапозона: ");
int m = int.Parse(Console.ReadLine());
for (int i = n; i <= m; i++)
{
    if (i % 2 == 0) 
    {
        Console.Write(i + ", ");
    }
}
Console.WriteLine("Четные числа дапозона");