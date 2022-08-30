Console.Clear();
Console.WriteLine("Напишите число A ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Напишите число B ");
int b = int.Parse(Console.ReadLine());
int result = a;
for (int i = 0; i < b - 1; i++)
{
    result = result * a;
}
 Console.WriteLine(result);
