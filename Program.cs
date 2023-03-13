int[] CreateArray(int Length, int Min, int Max)
{
    int [] array = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        array[i] = Random.Shared.Next(Min, Max + 1);
    }
}
