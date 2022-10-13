// Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел

void FillArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random(). Next(100,999);     
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
int[] array = new int [6];
FillArray(array);
PrintArray(array);

int chetnoe=0;
int nechetnoe=0;

for (int i = 0; i < array.Length; i++)
{    
    if (array[i]%2==0)
    {
       int count = 1; 
       chetnoe= chetnoe + count;
       count++;
    }
    else
    {
       int count = 1; 
       nechetnoe = nechetnoe + count;
       count++;
    }
}
Console.WriteLine();
Console.WriteLine($"Четных чисел {chetnoe}  и {nechetnoe} нечетных чисел");
