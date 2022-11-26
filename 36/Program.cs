// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

int size = 5;
int[] array = GetFillArray(size);


int[] GetFillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)

        array[i] = new Random().Next(0, 11);
    
    return array;
}


int SumNumbersOfOddIndexes(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    
        if (i % 2 != 0)
        sum = sum + array[i];
    
    return sum;
}


System.Console.WriteLine(String.Join(", ", array));
System.Console.WriteLine(SumNumbersOfOddIndexes(array));