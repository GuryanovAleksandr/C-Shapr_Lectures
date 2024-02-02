int n = 5;
int[] array = { 7,2,9,5, 12 };
int i = 0;
int max = array[0]; 
while (i < n)
{
    if ( array[i] > max)
    {
        max = array [i];
    }
    i++;
}
Console.WriteLine(max);
