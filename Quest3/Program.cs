// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

int GetNum(string message)
{
    Console.Write(message);
	int num = int.Parse(Console.ReadLine()!);
	return num;
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if (n == 0)
        {
            return Akkerman(m - 1, 1);
        }
        else
        {
            return Akkerman(m - 1, Akkerman(m, n - 1));
        }
    }
}

int M = GetNum("Введите число M:");
int N = GetNum("Введите число N:");
int Res = Akkerman(M,N);
Console.Write($"Результат вычисления: {Res}");
