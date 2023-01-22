// 6 Семинар:

// Задача 40: Напишите программу, которая принимает на
// вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

// void Treug(int A, int B, int C)
// {
// if(A < B + C && B < A + C && C < A + B)
// {
// Console.WriteLine("Треугольник существует");
// }
// else
// {
// Console.WriteLine("Треугольник не существует");
// }
// }

// Console.WriteLine("Введите длину первой стороны");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите длину второй стороны");
// int B = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите длину третьей стороны");
// int C = Convert.ToInt32(Console.ReadLine());

// Treug(A, B, C);

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// void GetBinaryView(int number)
// {
// if(number == 0) return;
// GetBinaryView(number/2);
// Console.Write(number%2);
// }

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// GetBinaryView(number);
// 2 Вариант
// void ReverseArray(int[] array)
// {
// int temp = 0;
// for(int i = 0; i < array.Length/2; i++)
// {
// temp = array[i];
// array[i] = array[array.Length - 1 - i];
// array[array.Length - 1 - i] = temp;
// }
// }

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int number2 = number;
// int length = 0;
// while(number > 0)
// {
// number/=2;
// length++;
// }

// int[] array = new int[length];

// for(int i = 0; i < array.Length; i++)
// {
// array[i] = number2%2;
// number2/=2;
// }
// Console.WriteLine(string.Join(", ", array));
// ReverseArray(array);
// Console.WriteLine(string.Join(", ", array));
// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// void PrintFib(int n)
// {
// Console.Write("0 1 ");
// int neighbour1 = 0;
// int neighbour2 = 1;
// int res = 0;
// for(int i = 0; i < n - 2; i++)
// {
// res = neighbour1 + neighbour2;
// Console.Write(res + " ");
// neighbour1 = neighbour2;
// neighbour2 = res;
// }
// }

// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// PrintFib(N);


// 2 Вариант

// int[] Fibonacci(int a)
// {
// int[] arr = new int[a];
// arr[0] = 0;
// arr[1] = 1;
// for(int i = 2; i < a; i++) {
// arr[i] = arr[i - 2] + arr[i - 1];
// }
// return arr;
// }

// System.Console.WriteLine("Введите число N:");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(string.Join(" ", Fibonacci(N)));


// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью 
// поэлементного копирования.

// void FillArrayWithRandom(int[] array)
// {
// for(int i = 0; i < array.Length; i++)
// {
// array[i] = new Random().Next(1, 10);
// }
// }

// int[] array1 = new int [5];
// FillArrayWithRandom(array1);
// int[] array2 = new int [5];
// Console.Write("Ваш случайный массив: ");
// Console.WriteLine(string.Join(", ", array1));

// for(int i = 0; i < array2.Length; i++)
// {
// array2[i] = array1[i];
// }
// Console.Write("Ваш скопированный массив: ");
// Console.WriteLine(string.Join(", ", array2));


// Домашка:

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// если число положительное, то включаем счетчик и говорим количество прогонов

// метод на заполнение с клавиатуры желаемого кол-ва элементов
// int[] FillMassByKeyBoard(int[] mass)
// {
//     Console.WriteLine("Введите через 'enter' положительные и отрицательные числа, создав массив: ");
//     for (int i = 0; i < mass.Length; i++)
//     {
//         mass[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return mass;
// }
// Console.Write("Введите длину массива: ");
// int dlina = Convert.ToInt32(Console.ReadLine());
// int[] mass = new int[dlina];
// FillMassByKeyBoard(mass);
// Console.WriteLine("Итоговый массив: " + '[' + string.Join(", ", mass) + ']');
// int count = 0;

// как можно было бы решить через while?? у меня не получилось, решил через for и условия

// for (int i = 0; i < mass.Length; i++)
// {
// if (mass[i] > 0)
//     {
//     count++;
//     }
// }
// Console.WriteLine("Количество положительных чисел: " + count); 


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

