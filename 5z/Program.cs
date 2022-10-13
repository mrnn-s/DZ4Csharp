// Найти сумму чисел одномерного массива стоящих на нечетной позиции
void FillArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
      Random N = new Random();
      array [i] = N.Next(min, max);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]} ");
  }
}

Console.WriteLine("enter length array");
int n = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[n];

Console.WriteLine("enter  min, max");
Console.WriteLine("enter min");
int min = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("enter max");
int max = int.Parse(Console.ReadLine() ?? "0");
FillArray( array, min, max);
PrintArray(array);

int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i%2==1)
    {
       sum = sum + array[i];
    }
}
Console.WriteLine();
Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях, равна  {sum}");