// Задайте значение N. Напишите программу, которая выведет все натуральные числа от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"

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

string GetValues(int n)
    {
        if (n == 1)
        {
            return n.ToString();
        }
        return GetValues(n-1) + $", {n}";
    }

int n = GetNumber("Введите число N больше 1: ");

GetValues(n);
Console.WriteLine(GetValues(n));
