/* Напишите программу, которая на вход принимает два числа А и В и возводит число 
А в целую степень В с помощью рекурсии.
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
// 2. Функция вычисления степени числа.
int GetSum(int numberOne, int numberTwo)
{
    if (numberTwo == 1)
    {
        return numberOne;
    }
    else
    {
        return GetSum(numberOne, numberTwo-1)*numberOne;
    }
}

Console.WriteLine(GetSum(GetNumber("Введите первое число: "), GetNumber("Введите второе число: ")));

