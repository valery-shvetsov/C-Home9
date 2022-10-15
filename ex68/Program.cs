// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

//ввод числа
int GetNumber(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}
//нахождение функции Аккермана
int Akkerman (int n, int m)
{
  //int A;  
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akkerman(n - 1, 1);
    else
      return Akkerman(n - 1, Akkerman(n, m - 1));
}

//Вывод числа
void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}

//main
int m = GetNumber("Введите число M");
int n = GetNumber("Введите число N");
int akkerman = Akkerman(m, n);
PrintData("Значение функции Аккермана: ", akkerman.ToString());
