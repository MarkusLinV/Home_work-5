Console.Clear();

int[] getRandomArray(int length, int min, int max)
{
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int SumNotEven(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        result = result + array[i];
    }
    return result;
}

int[] array = getRandomArray(6, 1, 10);

Console.WriteLine(string.Join(", ", array));

int result = SumNotEven(array);

Console.WriteLine($"Сумма всех элементов массива на нечётных позициях равна: {result}");