// // Найти факториал числа n с помощью рекурсии
// // вариант 1:
int Fact(int n)
{
    if(n == 1 || n == 0)
    {
        Console.WriteLine($"Stop recurson: n={n}");
        return 1;
    }
    Console.WriteLine(n);
    return Fact(n-1) * n;
}
Console.Write("Введите число для вычисления его факториала: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Результат:");
Console.WriteLine(Fact(n));


// //Вариант 2:
// // int Fact(int n)
// // {
// //     int result = 1;
// //     for(int i = 2; i <= n; i++)
// //     {
// //         result *=i;
// //     }
// //     return result;
// // }
// // Console.Write(Fact(11));

