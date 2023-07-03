// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

string PrintArr(int[] array)
{
    return string.Join(", ", array);
}

int GetNumber(string description)
{

    int number;
    Print($"{description} => ");

    while (true)
    {
        string temp = Console.ReadLine();
        if (int.TryParse(temp, out number))
        {
            return number;
        }
        Print($"This number \"{temp}\" is not correct. Try again. => ");
    }
}

void Print(string text)
{
    Console.WriteLine(text);
}

int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = GetNumber($"Input number {i + 1}");
    }
    return array;
}

bool TriangleInequalityTheorem(int[] array)
{
    int i = 0;
    if (array[i] < (array[i + 1] + array[i + 2]) && array[i + 1] < (array[i] + array[i + 2]) && array[i + 2] < (array[i] + array[i + 1]))
    {
        return true;
    }
    else
    {
        return false;
    }
}

Print("Enter the three sides of the triangle");
int[] array = CreateArray(3);
Print($"{PrintArr(array)}");
Print($"{TriangleInequalityTheorem(array)}");