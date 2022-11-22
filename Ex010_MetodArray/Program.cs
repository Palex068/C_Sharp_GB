
Console.Clear();

//               0   1   2  3   4   5   6   7   
int[] array = { 11, 21, 31, 4, 18, 61, 17, 18 };

int n = array.Length;
int find = 18;
int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    // index = index +1
    index++;
}
Console.WriteLine();
