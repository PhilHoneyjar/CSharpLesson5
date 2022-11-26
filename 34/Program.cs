// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int size = 5;
int[] array = GetFillArray(size);


int[] GetFillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    
        array[i] = new Random().Next(100, 1000);
    
    return array;
}


int GetCountEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    
        if (array[i] % 2 == 0)
        count++;
    
    return count;
}


System.Console.WriteLine(String.Join(", ", array));
System.Console.WriteLine(GetCountEvenNumbers(array));