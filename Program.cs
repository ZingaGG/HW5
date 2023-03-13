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

int SumAtOddIndex(int[] a)
{
    int result = 0;
    for (int i = 1; i < a.Length; i+=2)
    {
        result += a[i];
    }
    return result;
}

int FindMaxAndMin(int[] array, bool a)
{
    int result = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (a)
        {
            if(result < array[i])
            {
                result = array[i];
            }
        }
        else
        {
            if(result > array[i])
            {
                result = array[i];
            }
        }
    }

    return result;
}

// Task 1
/*
int[] array = CreateArray(3, 100, 999);
PrintArray(array);
System.Console.WriteLine("Result = " + CountEvenInArray(array));
*/

// Task 2
/*
int[] array = CreateArray(5, 0, 12);
PrintArray(array);
System.Console.WriteLine("Result = " + SumAtOddIndex(array));
*/

// Task 3
int[] array = CreateArray(5, 1, 100);
PrintArray(array);
int Max = FindMaxAndMin(array, true);
System.Console.WriteLine("Max = " + Max);
int Min = FindMaxAndMin(array, false);
System.Console.WriteLine("Min = " + Min);
System.Console.WriteLine("Result = " + (Max-Min));
