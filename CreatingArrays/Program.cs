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

 Console.WriteLine(" ");

void upside(int[] array)
{
    int len=array.Length;
    int ind=0;
    int[] antiarray = new int[10];
    while (ind < len)
    {
        antiarray[ind] = array[len - ind -1];
        Console.Write(antiarray[ind]+ " ");
        ind++;
    }
  
}

upside(array);