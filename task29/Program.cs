Console.Clear();
Console.Write("Введите количество элементов массива ");
int n = int.Parse(Console.ReadLine());
int [] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i} ");
    array[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}