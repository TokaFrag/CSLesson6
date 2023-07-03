// Развернуть массив

string PrintArr(int[] array)
{
    return string.Join(", ", array);
}

void Print(string text)
{
    Console.WriteLine(text);
}

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

void Reverse(int[] array)
{
    int size = array.Length;

    for (int i = 0, j = size - 1; i < j; i++, j--)
    {
        (array[i], array[j]) = (array[j], array[i]);
    }
}

int[] array = CreateArray(9, -9, 9);
Print($"{PrintArr(array)}");
Reverse(array);
Print($"{PrintArr(array)}");