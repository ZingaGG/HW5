int TakeDigit(string a)
{
    System.Console.WriteLine(a);
    int b = Int32.Parse(System.Console.ReadLine());
    return b;
}

int[] CreateArray(int Length, int Min, int Max)
{
    int[] array = new int[Length];
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

void PrintArray(int[] a)
{
    System.Console.WriteLine("Your array = [{0}]", string.Join(", ", a));
}

// Task 1

int[] array = CreateArray(3, TakeDigit("Input Min = "), TakeDigit("Input Max = "));
PrintArray(array);
System.Console.WriteLine("Result = " + CountEvenInArray(array));

