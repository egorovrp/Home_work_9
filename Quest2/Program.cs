// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int GetNum(string message)
{
    Console.Write(message);
	int num = int.Parse(Console.ReadLine()!);
	return num;
}

void SumNatureNum(int m, int n)
{
    int sum = 0;
    int i = m;
    while (i != n+1)
    {
        sum = sum + i;
        i++;
    }
    Console.Write($"Сумма натуральных чисел от {m} до {n} = {sum}");
}

int M = GetNum("Введите число M:");
int N = GetNum("Введите число N:");
SumNatureNum(M,N);
