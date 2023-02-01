// // Задайте массив заполненный случайными положительными трёхзначными числами. 
// // Напишите программу, которая покажет количество чётных чисел в массиве.
// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + "; ");
//     }
//     Console.WriteLine();
// }
// int[] myArray = CreateRandomArray(13, 100, 999);
// ShowArray(myArray);

// int sum2 = 0;

// for (int i = 0; i < myArray.Length; i++)
// {
//     if (myArray[i] % 2 == 0)
//     {
//         sum2++;
//     }
// }
// Console.WriteLine($"количество чётных чисел в массиве = {sum2}");

// // Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + "; ");
//     }
//     Console.WriteLine();
// }
// int[] myArray = CreateRandomArray(13, 0, 10);
// ShowArray(myArray);

// int sum = 0;

// for (int i = 0; i < myArray.Length; i++)
// {
//     if (i % 2 == 0) sum = sum;
//     else sum = sum + myArray[i];
// }
// Console.WriteLine($"сумма элементов, стоящих на нечётных позициях = {sum}");

// // Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + "; ");
//     }
//     Console.WriteLine();
// }
// int[] myArray = CreateRandomArray(7, -3, 10);
// ShowArray(myArray);

// int min = 0;
// int max = 0;
// int dif = 0;

// for (int i = 0; i < myArray.Length; i++)
// {
//     if (myArray[i] < min) min = myArray[i];
//     if (myArray[i] > max) max = myArray[i];
// }

// dif = max - min;
// Console.WriteLine($"максимальный элемент = {max}, минимальный элемент = {min}, разница = {dif}");