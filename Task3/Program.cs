﻿// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

void ReverseString(char[] str)
{
    int left = 0;
    int right = str.Length - 1;

    while (left < right)
    {
        char temp = str[left];
        str[left] = str[right];
        str[right] = temp;

        left++;
        right--;
    }
}

bool IsPalindrome(char[] str)
{
    int left = 0;
    int right = str.Length - 1;

    while (left < right)
    {
        if (str[left] != str[right])
            {
                return false;
            }

        left++;
        right--;
    }

    return true;
}

void Condition(char [] str)
{
    if (IsPalindrome(str))
    {
        Console.WriteLine("Данная строка является палиндромом.");
    }
    else
    {
        Console.WriteLine("Данная строка НЕ является палиндромом.");
    }
}

Console.Clear();
Console.Write("Введите строку для проверки на палиндром: ");
string input = Console.ReadLine();
char[] str = input.ToCharArray();


ReverseString(str);
IsPalindrome(str);
Condition(str);


