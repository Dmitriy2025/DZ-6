//Задача 1: Задайте двумерный массив символов (тип char [,]). 
//Создать строку из символов этого массива.

void InputMatrix(char [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Random random = new Random();
            char randomChar = (char)random.Next('a', 'z' + 1);
            matrix[i, j] = randomChar;
        }
    }
}

void PrintMatrix(char [,] matrix)
{
    for (int i=0; i <matrix.GetLength(0); i++)
    {
        for (int j=0; j <matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void PrintString(char [,] matrix)
{
    string res = "";
    foreach(char i in matrix)
    res += i;
    Console.WriteLine($"Матрица, записанная в одну строку: {res}");
}

Console.Clear();
Console.WriteLine("Осуществляйте ввод значений через запятую.");
Console.Write("Задайте размер маттрицы: ");

int [] size = Console.ReadLine().Split(",").Select(x => int.Parse(x)).ToArray();
char[,] matrix = new char[size[0], size[1]];


InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();

PrintString(matrix);






