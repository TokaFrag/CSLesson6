// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

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





int number = GetNumber("Enter number");

List<int> list = new List<int>();
for (int i = 0; number > 0; i++)
{
    list.Add(number % 2);
    number /= 2;
}
list.Reverse();
Console.WriteLine($"{string.Join("", list)}");