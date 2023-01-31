/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Clear();

int GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            isCorrect = true;
        }
        else 
        {
            Console.WriteLine("Введите корректное число.");
        }
    }
    return result;
}

string GetValues(int n, int m)
    {
        if (n == m)
        {
            int count = m;
            return n.ToString();
        }
        return GetValues(n-1, m) + $", {count}";

    }

//int n = GetNumber("Введите число N больше M: ");
int m = GetNumber("Введите число M больше 1: ");
int n = GetNumber("Введите число N больше M: ");

GetValues(n, m);
Console.WriteLine(GetValues(n, m));