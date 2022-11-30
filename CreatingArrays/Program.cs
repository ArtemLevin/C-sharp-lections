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

int Find(int[] array, int find)
{
    int i = array.Length;
    int c = 0;
    int NumberPos = -1;
    while (c<i)
    {
        if (array[c] == find)
        {
            NumberPos = c;
        }
        c++; 
    }
    return NumberPos;

}

Console.WriteLine("");

Console.Write("Index of the number to find out: " + Find(array, 4));
