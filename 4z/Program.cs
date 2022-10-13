// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
void FillArray(int[] array, int min, int max)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next (min,max);
    }
}
void PrintArray(int[]array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
int[] array = new int[123];
FillArray(array, -999, 999);
PrintArray(array);
int number = 0;
for (int i = 0; i < array.Length; i++)
{
    if  (array[i]>=10 && array[i]<=99)                                 
        {
            int count = 1;
            number = number+ count;
        }
    
}
Console.WriteLine();
Console.Write($"В массиве {number} чисел  из диапазона от 10 до 99");