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

void UpsideDown (int[] array)
{
    int len=array.Length;
    int y = 0;
    int temp;
    while (y < (len/2))
    
    {
        temp = array[y];
        array[y]=array[len - y - 1];
        array[len-y - 1]=temp;
        Console.Write(" " + array[y]);
        y++;

    }
}

Console.WriteLine(" ");

UpsideDown(array);