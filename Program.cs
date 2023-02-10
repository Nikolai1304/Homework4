// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
Console.WriteLine("Введите число A  ");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B  ");
int numB = int.Parse(Console.ReadLine());
Degree(numA, numB);
void Degree(int a, int b)
{
int result = 1;
for (int i =1; i<=b; i++)
{
result = result*a;
}
System.Console.WriteLine();
Console.WriteLine("A в степени B =  " +result);
}



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число  ");
int X = int.Parse(Console.ReadLine());
// int sum=0;
// while (X>0)
// {
// sum=sum+X%10;
// X=X/10;
// }
// System.Console.WriteLine(sum);

int sum (int ostatok)
{
int res = 0;
for(; ostatok>0; ostatok = ostatok/10)
// while (ostatok > 0)
  {
    res = res + ostatok % 10;
    // ostatok = ostatok / 10;
  }
  return res;
}
// Console.WriteLine($"Сумма всех цифр числа равна {sum(X)}");





// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]





System.Console.WriteLine();
Console.Write("Массив:");
System.Console.WriteLine();
int[] array = GetArray(8, -9, 9); // размер, макс и мин значения

int[]GetArray (int size, int minValue, int maxValue)
{
int[] res = new int[size];
for (int i = 0; i < size; i++)
{
    res[i] = new Random().Next(minValue, maxValue+1);
}
return res;
}
Console.WriteLine(String.Join(" ", array));