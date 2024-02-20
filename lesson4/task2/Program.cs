// Назовем число “интересным” если его сумма цифр четная
// Создавать двумерный массив, состоящий из целых чисел. 
//Вывести на экран “интересные” элементы массива

int[,] CreateMatrix(int rowCount, int colomsCount)  // функция создания массива из случайных чиселот 1 до 999
{
    int[,] matrix = new int[rowCount, colomsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix) // функция вывода созданного массива на экран
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} "); 
        }
        Console.WriteLine();
    }
}



int[,] matrix = CreateMatrix(3, 4); // задаем параметры двумерного массива

ShowMatrix(matrix); // выводим созданный массив на экран

foreach (int e in matrix) // цикл проверки числа на интересность и вывода такого числа в случае успеха
{
    if (IsInteresting(e) == true)
    {
        Console.Write($"{e} ");
    }
}

bool IsInteresting(int value) // функция  проверки числа на "интересность"
{
    int SumOfDigits = GetSumOfDigits(value);

    if (SumOfDigits % 2 == 0)
    {
        return true;
    }
    //else{   сокращение кода
    return false;
    // }
}

int GetSumOfDigits(int value) // функция получения суммы цифр числа
{
    int sum = 0;
    while (value > 0)
    {
        sum = sum + value % 10; // получаем самое правое число
        value = value / 10;
    }
    return sum;
}
