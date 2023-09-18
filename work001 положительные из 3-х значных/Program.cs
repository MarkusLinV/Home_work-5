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

int LookEven(int[] arrey)
{
    int count = 0;
    for (int i = 0; i < arrey.Length; i++)
    {
        if (arrey[i] % 2 == 0)
        {
            count = count + 1;
        }
    }
    return count;
}

int[] array = getRandomArray(5, 100, 999);

Console.WriteLine(string.Join(", ", array));

int result = LookEven(array);

Console.WriteLine($"Колл-во чётных числе в массиве: {result}");























