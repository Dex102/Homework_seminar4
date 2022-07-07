int[] NewArray(int size)
{
    int[] Array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Array[i] = new Random().Next(1, 1000);
    }

    return Array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

    Console.WriteLine();
}

Console.Write("Input size array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] MyArray = NewArray(size);
ShowArray(MyArray);

