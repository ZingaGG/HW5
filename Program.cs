int[] CreateArray(int Length, int Min, int Max)
{
    int [] array = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        array[i] = Random.Shared.Next(Min, Max + 1);
    }

    return array;
}

int CountEvenInArray(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length ; i++)
    {
        if (array[i] % 2 == 0)
        {
            result++;
        }
    }

    return result;
}