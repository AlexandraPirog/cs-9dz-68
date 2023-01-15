/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/
Console.Clear();
int m = InputNumber("Введите число N: ");
int n = InputNumber("Введите число M: ");
Console.WriteLine($"A({m}, {n}) = {AkkermanRec(m, n)}");

int AkkermanRec(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AkkermanRec(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return AkkermanRec(m - 1, AkkermanRec(m, n - 1));
    }
    else
    {
        return 0;
    }
}
//Проверка на число
int InputNumber(string str)
{
    int number;
    string text;
    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");

    }
    return number;
}
