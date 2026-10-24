// задание 1

//  PrintLine();
//  Console.WriteLine("Привет!");
//  PrintLine();

//  static void PrintLine() {
//      Console.WriteLine("`_`");
//  }

//  PrintLine();

//  static void PrintHeader(string title)
//      {
//          PrintLine();
//          Console.WriteLine(title);
//          PrintLine(); 
//      }

//  PrintHeader("Заголовок 1");
//  PrintHeader("Заголовок 2");


// Задание 2.1

//  int a = int.Parse(Console.ReadLine());
//  int b = int.Parse(Console.ReadLine());
//  Console.WriteLine("Максимум: " + Max(a, b));    

//  static int Max(int a, int b)
//  {
//      if (a > b)
//      {
//          return a;
//      }
//      else
//      {
//          return b;
//      }
//  }

// Задание 2.2
//  Console.WriteLine(IsEven(4));
//  Console.WriteLine(IsEven(7));
//  Console.WriteLine(IsEven(0));

//  static bool IsEven(int n)
//  {
//      return n % 2 == 0;
//  }

// задание 3
//  int[] arr = { 120, 45, 300, 80, 15, 210 };

//  Console.WriteLine("Среднее: " + Average(arr));
//  Console.WriteLine("limit: " + CountGreater(arr, 100));


//  static double Average(int[] arr)
//  {
//      int sum = 0;
//      foreach (int x in arr)
//      {
//          sum += x;
//      }
//      return (double)sum / arr.Length;
//  }

//  static int CountGreater(int[] arr, int limit)
//  {
//      int count = 0;
//      foreach (int x in arr)
//      {
//          if (x > limit)
//          {
//              count++;
//          }
//      }
//      return count;
//  }


// Задание 4. 

//  using System;

//  class Program
//  {
//      static double ToFahrenheit(double celsius)
//      {
//          return celsius * 9 / 5 + 32;
//      }

//      static void Main()
//      {
//          double c1 = 0;
//          double f1 = ToFahrenheit(c1);
//          Console.WriteLine($"{c1} °C = {f1} °F");

//          double c2 = 100;
//          double f2 = ToFahrenheit(c2);
//          Console.WriteLine($"{c2} °C = {f2} °F");

//          double c3 = 37;
//          double f3 = ToFahrenheit(c3);
//          Console.WriteLine($"{c3} °C = {f3} °F");
//      }
//  }


// Задание 5.


//  Console.WriteLine(Factorial(5));

//  for (int i = 2; i <= 50; i++)
//  {
//      if (IsPrime(i))
//      {
//          Console.Write(i + " ");
//      }
//  }
//  Console.WriteLine();

//  static long Factorial(int n)
//  {
//      long result = 1;
//      for (int i = 2; i <= n; i++)
//      {
//          result *= i;
//      }
//      return result;
//  }

//  static bool IsPrime(int n)
//  {
//      if (n < 2) return false;
//      for (int i = 2; i * i <= n; i++)
//      {
//          if (n % i == 0) 
//          {
//              return false;
//          }
//      }
//      return true;
//  }


//

//  int a = ReadPositive("Введите первое положительное число: ");
//  int b = ReadPositive("Введите второе положительное число: ");
//  Console.WriteLine($"Сумма: {a + b}");
//  static int ReadPositive(string message)
//  {
//      int number;
//      do
//      {
//          Console.Write(message);
//          string input = Console.ReadLine();

//          if (!int.TryParse(input, out number))
//          {
//              Console.WriteLine("Ошибка: нужно ввести целое число.");
//              number = -1;
//          }
//          else if (number <= 0)
//          {
//              Console.WriteLine("Ошибка: число должно быть положительным.");
//          }

//      } while (number <= 0);
//      return number;
//  }

//  Меню-калькулятор

// static int ReadPositive(string message)
// {
//     int number;
//     do
//     {
//         Console.Write(message);
//         number = int.Parse(Console.ReadLine());
//     } while (number <= 0);
//     return number;
// }

// static int Sum(int a, int b)
// {
//     return a + b;
// }

// static int Max(int a, int b)
// {
//     if (a > b)
//         return a;
//     else
//         return b;
// }


// static long Factorial(int n)
// {
//     long result = 1;
//     for (int i = 2; i <= n; i++)
//         result *= i;
//     return result;
// }

// int choice;
// do
// {
//     Console.WriteLine("\n1 — сумма двух чисел");
//     Console.WriteLine("2 — большее из двух чисел");
//     Console.WriteLine("3 — факториал");
//     Console.WriteLine("0 — выход");
//     Console.Write("Ваш выбор: ");

//     choice = int.Parse(Console.ReadLine());
//     switch (choice)
//     {
//         case 1:
//             int a1 = ReadPositive("Первое число: ");
//             int b1 = ReadPositive("Второе число: ");
//             Console.WriteLine($"Сумма: {Sum(a1, b1)}");
//             break;
//         case 2:
//             int a2 = ReadPositive("Первое число: ");
//             int b2 = ReadPositive("Второе число: ");
//             Console.WriteLine($"Большее: {Max(a2, b2)}");
//             break;
//         case 3:
//             int n = ReadPositive("Число: ");
//             Console.WriteLine($"Факториал: {Factorial(n)}");
//             break;
//         case 0:
//             Console.WriteLine("Выход.");
//             break;
//     }
// } while (choice != 0);


//Дополнительное задание ★★★
// Console.WriteLine(Gcd(48, 18));
// Console.WriteLine(Lcm(4, 6));
// static int Gcd(int a, int b)
// {
//     while (b != 0)
//     {
//         int temp = a % b;
//         a = b;
//         b = temp;
//     }
//     return a;
// }

// static int Lcm(int a, int b)
// {
//     return a / Gcd(a, b) * b;
// }