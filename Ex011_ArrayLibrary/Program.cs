
Console.Clear();

void FillArray(int[] collection)  // создаем Метод заполнение массива псевдослучайными числами
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) // создаем Метод печати массива
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]}\t");
        position++;
    }
}

int IndexOf(int[] collection, int find) // создаем Метод поиска индекса числа в массиве
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[20];

FillArray(array);
PrintArray(array);

Console.WriteLine();

int pos = IndexOf(array, 1); // Запускаем поиск индекса искомого элемента
Console.WriteLine(pos);

Console.WriteLine();


