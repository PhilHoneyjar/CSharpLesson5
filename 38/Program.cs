// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.

int GetintFromConsole(string message)
{
    System.Console.Write(message);
    return System.Convert.ToInt32(System.Console.ReadLine());
}


double[] FillArray(int L, int Min, int Max)
{
    double[] result = new double[L];
    for (int i = 0; i < L; i++)
    {
        result[i] = Math.Round(new Random().NextDouble() * (Max - Min) + Min, 2);
    }
    return result;
}


void PrintArray(double[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        if (i == Array.Length - 1)
            System.Console.Write($"{Array[i]} ");
        else
            System.Console.Write($"{Array[i]}, ");
    }
}


double FindMin(double Max, double[] Array)
{
    double min = Max;

    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] < min)
            min = Array[i];
    }
    return min;
}


double FindMax(double Min, double[] Array)
{
    double max = Min;

    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > max)
            max = Array[i];
    }
    return max;
}


void PrintMaxMinusMin(double a, double b)
{
    double Minus = a - b;
    System.Console.Write(Minus);
}


int message1 = GetintFromConsole("Input array length = ");
int message2 = GetintFromConsole("Input array min value = ");
int message3 = GetintFromConsole("Input array max value = ");


double[] Arr = FillArray(message1, message2, message3);
PrintArray(Arr);
double Res1 = FindMin(message3, Arr);
double Res2 = FindMax(message2, Arr);
System.Console.WriteLine();
PrintMaxMinusMin(Res2,Res1);