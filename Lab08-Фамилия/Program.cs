//задание 1

// PrintLine();
// Console.WriteLine("Привет!");
// PrintLine();

// static void PrintLine() {
//     Console.WriteLine("`_`");
// }

// PrintLine();

// static void PrintHeader(string title)
//     {
//         PrintLine();
//         Console.WriteLine(title);
//         PrintLine(); 
//     }

// PrintHeader("Заголовок 1");
// PrintHeader("Заголовок 2");


//Задание 2.1

// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());
// Console.WriteLine("Максимум: " + Max(a, b));    

// static int Max(int a, int b)
// {
//     if (a > b)
//     {
//         return a;
//     }
//     else
//     {
//         return b;
//     }
// }

//Задание 2.2
// Console.WriteLine(IsEven(4));
// Console.WriteLine(IsEven(7));
// Console.WriteLine(IsEven(0));

// static bool IsEven(int n)
// {
//     return n % 2 == 0;
// }

//задание 3
// int[] arr = { 120, 45, 300, 80, 15, 210 };

// Console.WriteLine("Среднее: " + Average(arr));
// Console.WriteLine("limit: " + CountGreater(arr, 100));


// static double Average(int[] arr)
// {
//     int sum = 0;
//     foreach (int x in arr)
//     {
//         sum += x;
//     }
//     return (double)sum / arr.Length;
// }

// static int CountGreater(int[] arr, int limit)
// {
//     int count = 0;
//     foreach (int x in arr)
//     {
//         if (x > limit)
//         {
//             count++;
//         }
//     }
//     return count;
// }

