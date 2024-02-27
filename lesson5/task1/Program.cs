// Создадиим рекурсивную фунцию открытия матрешки
// void OpenMatryoshka(int size)
// {
//     if (size == 0)
//     {
//         Console.WriteLine("Smallest!");
//         return;
//     }
//     Console.WriteLine($"Opening matryoshka of size {size}...");
//     OpenMatryoshka(size - 1);
// }
// OpenMatryoshka(5);

void OpenMatryoshka(int size)
{
    if (size == 1)
    {
        Console.WriteLine("Smallest!");
        return;
    }
    OpenMatryoshka(size - 1);
    Console.WriteLine($"Opening matryoshka of size {size}...");
}
OpenMatryoshka(5);
