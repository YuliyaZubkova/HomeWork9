// // Задайте значение M и N. 
// Напишите программу, которая выведет все натуральные числа от M до N.

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
            return n.ToString();
        }
        return GetValues(n-1, m) + $", {n}";
    }

//int n = GetNumber("Введите число N больше M: ");
int m = GetNumber("Введите число M больше 1: ");
int n = GetNumber("Введите число N больше M: ");

GetValues(n, m);
Console.WriteLine(GetValues(n, m));
