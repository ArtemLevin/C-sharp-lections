void FillArray(int[] collection)

{
    int count = collection.Length;
    int index = 0;
    while (index < count)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }

}

void PrintArray(int[] col)
{
    int position = col.Length;
    int pos = 0;
    while (pos < position)
    {
        Console.Write(" " + col[pos]);
        pos++;
    }
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);

int Max(int[] array)
{
    int len = array.Length;
    int p = 0;
    int max = array[0];

    while (p < len)
    {
        if (array[p] > max)
        {
            max= array[p];
        }
        p++;
    }
    return max;
}
Console.Write(" ");
Console.Write("The max number is: " + Max(array));