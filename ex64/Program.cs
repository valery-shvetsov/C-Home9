// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

//Ввод числа
int GetNumber(string line)
{
Console.WriteLine(line);
int number = int.Parse(Console.ReadLine() ?? "");
return number;
}

// Вывод натуральных чисел от числа N до1
void RecursionNumer(int n)
{
if (n < 1)
return;
Console.Write(n + ", ");
RecursionNumer(n-1);
//Console.Write(n + ", ");
}

//main
int num = GetNumber("Введите число:");
RecursionNumer(num);
