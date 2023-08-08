// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

int GetNum(string message)
{
    Console.Write(message);
	int num = int.Parse(Console.ReadLine()!);
	return num;
}

void Rekursion (int number) 
{   
    if (number != 1)
    {
        Console.Write($"{number},");
        Rekursion(number - 1);
    }
    else
    {
        if (number == 1)
        {
            Console.Write($"{number}");
        }
    
    }
}

int N = GetNum("Введите число N:");    
Rekursion(N);


