/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
[3 7 22 2 78] -> 76
*/

double[] CreateRandomArray(int N, int start, int end)
{
    double[] RandomArray = new double[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = Math.Round(new Random().Next(start, end + 1) * new Random().NextDouble(), 2);
    }
    return RandomArray;
}

void ShowArray(double[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i] + " ");
    }
    Console.WriteLine();
}

void DifMaxMin(double[] Array)
{
    double Min = Array[0];
    double Max = Array[0];

    for (int i = 1; i < Array.Length; i++)
    {
        if (Min > Array[i])
        {
            Min = Array[i];
        }
        if (Max < Array[i])
        {
            Max = Array[i];
        }
    }
    double Dif = Math.Round(Max - Min, 2);
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {Dif}");
}

Console.Write("Введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение массива: ");
int minArray = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение массива: ");
int maxArray = Convert.ToInt32(Console.ReadLine());

double[] Array = CreateRandomArray(num, minArray, maxArray);
ShowArray(Array);

DifMaxMin(Array);