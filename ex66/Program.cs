//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N.
//M = 1; N = 5 -> "1, 2, 3, 4, 5"
//M = 4; N = 8 -> "4, 6, 7, 8"

//ввод числа
int GetNumber(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

// Нахождение суммы в интервале от M до N
int RecursionSum(int m, int n)
{
    //int sum=0;    
    if (m == n)
        return n;
    return n + RecursionSum(m, n - 1);
    //Console.Write(n + ", ");
}

//Вывод числа
void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}

//main
int m = GetNumber("Введите число M");
int n = GetNumber("Введите число N");
int summa = RecursionSum(m, n);
PrintData("Сумма чисел от M до N: ", summa.ToString());
