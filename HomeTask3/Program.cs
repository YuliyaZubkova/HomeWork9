/*
Задача 68: Напишите программу вычисления 
функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.Clear();

// Функция добавления числа с консоли
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

// функция Аккермана
int A(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
      if ((m != 0) && (n == 0))
        return A(m - 1, 1);
    else
        return A(m - 1, A(m, n - 1));
}

int m = GetNumber(" Введите число M больше 0: ");
int n = GetNumber("\n Введите число N больше 0: ");
Console.WriteLine($"\n m = {m}, n = {n} -> A(m,n) = {A(m, n)} \n");



