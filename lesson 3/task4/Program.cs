// Заполнение массива случайными целыми числами от 1 до 10 (10 не включая)
Random rnd = new Random();

int size = 100;
int[] arr_int = new int[size];
int i = 0;
while(i<size)
{
    arr_int[i] = rnd.Next(1,10);
    i++;
}
i= 0;
while(i<size)
{
    Console.Write($"{arr_int[i]} ");
    i++;
}
