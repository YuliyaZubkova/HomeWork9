/* Напишите программу, которая будет принимать на вход число 
и возвращать сумму его цифр. Например, 
453 -> 12;
*/

// 1. Функция получения числа.
int GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;

    while (!isCorrect)
    {
        Console.WriteLine(message);

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
// 2. Функция вычисления суммы цифр числа. 
int GetSum(int number)
{
    int result = 0;
    if (number < 10)
    {
        result = number;
    }
    else 
    {
        result = GetSum(number/10) + number%10;
    }
    return result;
}

int number = GetNumber("Введите число N больше 1: ");
Console.WriteLine(GetSum(number));
