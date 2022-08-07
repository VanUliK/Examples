void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void FindArray(int[] find)
{
    int CountFind = find.Length;
    for (int i = 0; i < CountFind; i++)
    {
        find[0] = find.Max();
        find[1] = find.Max() - 2;
        Console.Write(i);

    }
}

void PrinArray(int[] array)
{
    int count = array.Length;
    for (int a = 0; a < count; a++)
    {
        Console.Write(array[a] + " ");
    }
}

int[] array = new int[10];
FillArray(array);
Console.WriteLine(" ");
PrinArray(array);
Console.WriteLine(" ");
FindArray(array);
Console.WriteLine(" ");
array[9] = array.Max();
array[8] = array[9] - 1;
array[7] = array[8] - 1;
array[6] = array[7] - 1;
array[5] = array[6] - 1;
array[4] = array[5] - 1;
array[3] = array[4] - 1;
array[2] = array[3] - 1;
array[1] = array[2] - 1;
array[0] = array[1] - 1;

PrinArray(array);





