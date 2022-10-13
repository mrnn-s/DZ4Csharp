// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
// В Указанном массиве вещественных чисел найдите 
// разницу между максимальным и минимальным элементом
void PrintArray (double[] array)
{
   for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]}| ");
}
double [] array = {51, 4, -2.2, -33, 0.7};
double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
  if (array[i]>max) max = array[i];
}
for (int i = 0; i < array.Length; i++)
{
  if (array[i]<min) min = array[i];
}

double result = max-min;
Console.WriteLine("Ваш массив:");
PrintArray(array);
Console.WriteLine();
Console.WriteLine ($"Разница между максимальным и минимальным элементами массива |{result}|");