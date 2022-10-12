Напишите программу, которая принимает на вход координаты х у и выдает номер четверти в плоскости , в которой находится эта точка
Console.WriteLine("Введите координату по оси ОХ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату по оси ОY");
int y = Convert.ToInt32(Console.ReadLine());
 if (x > 0 && y > 0) Console.WriteLine("I четверть");
 if (x > 0 && y < 0) Console.WriteLine("IV четверть");
 if (x < 0 && y > 0)Console.WriteLine("II четверть");
  if (x < 0 && y < 0)Console.WriteLine("III четверть");
else
{
    Console.WriteLine("Ошибка");
}

Напишите программу, которая по номеру четверти показывает диапозон возможных координатных точек
Console.WriteLine("Введите номер четверти");

int a = Convert.ToInt32(Console.ReadLine());
 if (a == 1) Console.WriteLine("Диапазон точек x > 0, y > 0");
 if (a == 2) Console.WriteLine("Диапазон точек x < 0, y > 0");
 if (a == 3) Console.WriteLine("Диапазон точек x < 0, y < 0");
 if (a == 4) Console.WriteLine("Диапазон точек x > 0, y < 0");
 else
 {
    Console.WriteLine("Нет такой четверти, введите число от 1 до 4");
 }

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2д пространстве

Console.WriteLine("ВВедите координаты первой точки ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите координаты воторой точки ");

int c = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());

double result = Math.Round(Math.Sqrt(Math.Pow(c - a, 2) + Math.Pow(d - b, 2)), 2);
Console.WriteLine($"Расстояие между точками составляет: {result}");

Напишите программу, которая принимает на вход число и выдает таблицу кввадратов от 1 до числа
 Console.WriteLine("Введите число: ");
 int n = Convert.ToInt32(Console.ReadLine());
 int number = 1;

 while (number <= n)
 {
    double pow = Math.Pow(number, 2);
    number++;
  
    Console.WriteLine($"Вот квадраты : {pow}");

 }
Решение через цикл for
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++) Console.WriteLine(Math.Pow(i, 2));

Напишите программу, которая принимает на вход число N и выдает таблицу кубов 
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++) Console.WriteLine(Math.Pow(i, 3));

Напишите программу, которая приниммает на вход число А и выдвет сумму чисел от 1 до А
Console.WriteLine("Введите число");
 int number = Convert.ToInt32(Console.ReadLine());
int sum =0;
for (int i = 1; i <= number; i++) 
{
    sum +=i;
}
 Console.WriteLine(sum);
 
  Решение через метод
     Console.WriteLine("Введите число");
     int number = Convert.ToInt32(Console.ReadLine());

     int SummaNumber(int n)
     {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum+=i;
        }
        return sum;
     }
     Console.WriteLine($"Сумма чисел от 1 до {number} = {SummaNumber(number)}");
  
 
Напишите программу, которая принимает на вход число и выдает количество цифр в числе
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

int AmountDivision(int n)
{
    int count=0;
    while (n % 10 != 0)
    {
        n = n / 10;
        count++;
    }
    return count;
}
Console.WriteLine($"Ваше число - {a}, количество цифр в нем {AmountDivision(a)}");
Напишите программу, которая выдает число N  и выдает произведение чисел от 1 до N
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int FactorialNumber(int n)
{
    int fact=1;
    for (int i = 1; i <= n; i++)
    {
        fact *=i;
    }
    return fact;
}
Console.WriteLine($"Произведение чисел от 1 до {number} = {FactorialNumber(number)}");
  
Напишите программу, которая выводит массив из 8 жлементов , заполненый нулями и единицами в рандомном порядке

int[] array = new int [8];
for (int i = 0; i < 8; i++)
{
    array [i] = new Random().Next(2);
    Console.Write($"{array [i]}  ");
}

Напишите цикл, который принимает на вход два числа (А и В) и возводит число в натуральную степень В
Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

void NumberPov(int c, int d)
{
    int result = 1;
    for (int i = 1; i <= d; i++)
    {
        result *=c;
    }
    Console.WriteLine(result);
}
NumberPov(a, b);
Напишите программу, которая принимает на вход число и выдает сумму цифр в числе
Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
 int SumNumbers (int n)
 {
    int sum=0;
    while (n % 10 != 0)
    {
       int rem = n % 10;
        sum =sum + rem;
        
        
    }
    return sum;
 }
 Console.WriteLine($"Ваше число - {a}, сумма цифр = {SumNumbers(a)}");

Напишите программу, которая задает массив из 8 чисел и выводит их на экран.

int[] array = new int [8];
for (int i = 0; i < 8; i++)
{
    array [i] = new Random().Next();
    Console.Write($"{array [i]}  ");
}