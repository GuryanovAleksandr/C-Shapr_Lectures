// Найти факториал числа n с помощью рекурсии
// вариант 1:

// int Fact(int n)
// {
//     if(n == 1 || n == 0)
//     {
//         return 1;
//     }
//     return n * Fact(n-1);
// }
// Console.Write(Fact(10));

//Вариант 2:
int Fact(int n)
{
    int result = 1;
    for(int i = 2; i <= n; i++)
    {
        result *=i;
    }
    return result;
}

Console.Write(Fact(11));