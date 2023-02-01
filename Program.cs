// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "; ");
    }
    Console.WriteLine();
}
int[] myArray = CreateRandomArray(7, -3, 10);
ShowArray(myArray);

int min = 0;
int max = 0;
int dif = 0;

for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] < min) min = myArray[i];
    if (myArray[i] > max) max = myArray[i];
}

dif = max - min;
Console.WriteLine($"максимальный элемент = {max}, минимальный элемент = {min}, разница = {dif}");