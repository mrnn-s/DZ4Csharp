// Задать массив из 12 элементов, заполненных числами из [0,9]. 
//Найти сумму положительных/отрицательных элементов массива
void FillArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random(). Next(-9,10);     
    }    
}
void PrintArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine(array[i]);
    }
}
int[] array = new int [12];
FillArray(array);
PrintArray(array);

int positive=0;
int negative=0;

for (int count=0;count<array.Length;count++)
{
   if (array[count]>0)
   {
    positive=positive+array[count];
   }
   else
  {
     negative=negative+array[count];
  }
}
Console.WriteLine();
Console.WriteLine("Summary positive numbers:" + positive);
Console.WriteLine("Summary negative numbers:" + negative);
