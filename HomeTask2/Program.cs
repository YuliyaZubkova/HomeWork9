/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

*/

Console.Clear();

int m = GetNumber("Введите число M больше 0: ");
int n = GetNumber("Введите число N больше M: ");
int sum = 0;

int GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;

    while (!isCorrect)
    {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
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


void Summ(int m)
{
    sum = sum + m;
    m++;
    if (m > n)
    {
        Console.Write($"Сумма натуральных чисел от M до N равна {sum} ");
        return;
    }
    Summ(m);
}

Summ(m);

