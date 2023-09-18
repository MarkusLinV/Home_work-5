Console.Clear();

double[] getRandomDoubleArray(int length, int min, int max, int round)
{
    double[] array = new double[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().Next(min, max) + new Random().NextDouble(), round);
    }
    return array;
}

double LookMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double LookMin(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double[] array = getRandomDoubleArray(5, 0, 5, 1);
double max = LookMax(array);
double min = LookMin(array);
Console.WriteLine(string.Join(", ", array));
// System.Console.WriteLine(max);
// System.Console.WriteLine(min);
System.Console.WriteLine($"Разница максимального и минимального чисел массива {max} - {min} = {max - min}");