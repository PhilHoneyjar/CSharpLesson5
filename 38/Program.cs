// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

int size = 5;
int[] array = GetFillArray(size);


int[] GetFillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)

        array[i] = new Random().Next(-100, 101);
    return array;
}


int MaxAndMinDifference(int[] array)
{
    int MinNumber = 0;
    int MaxNumber = 0;
    int result = 0;

    for (int i = 0; i < array.Length; i++)
    
        if (array[i] < array[MinNumber])
            MinNumber = i;
        else if (array[i] > array[MaxNumber])
            MaxNumber = i;
    
        result = array[MaxNumber] - array[MinNumber];
    return result;
}


System.Console.WriteLine(String.Join(", ", array));
System.Console.WriteLine(MaxAndMinDifference(array));