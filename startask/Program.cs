Console.Clear();
int[] array = new int[10];
for (int i = 0; i <= array.Length - 1; i++)
{
    array[i] = new Random().Next(-10, 10);
    Console.Write(array[i] + " ");
}
int max = array.Max();
Console.WriteLine("Максимальное значение " + max);

