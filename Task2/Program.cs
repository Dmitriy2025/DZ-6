// Задача 2
// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

void InputString(char[] str)
{
    Random random = new Random();
    for (int i = 0; i < str.Length; i++)
    {
        char randomChar;
        if (random.Next(2) == 0)
        {
            randomChar = (char)random.Next('a', 'z' + 1);
        }
        else
        {
            randomChar = (char)random.Next('A', 'Z' + 1);
        }
        str[i] = randomChar;
    }
    Console.WriteLine();
}

void PrintString(char[] str)
{
    string print = new string(str);
    Console.WriteLine($"Сгенерированная строка: {print}");
    Console.WriteLine();
}

void ChangeSymbols(char[] str)
{   
    for (int i = 0; i < str.Length; i++)
    {
        str[i] = char.ToLower(str[i]);
    }
    string print = new string(str);
    Console.WriteLine($"Измененная строка прописью: {print}");
    Console.WriteLine();
}

Console.Clear();
Console.Write("Задайте размер строки в символах: ");

int size = int.Parse(Console.ReadLine());
char[] str = new char[size];

InputString(str);
PrintString(str);
ChangeSymbols(str);
