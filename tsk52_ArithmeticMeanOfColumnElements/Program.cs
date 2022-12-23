// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = FillArray();

PrintArray(array);
Console.WriteLine($"{array.GetLength(1)} - the number of columns");
for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    Console.Write($"{ sum / array.GetLength(0)} ");
}
// Console.ReadLine();

// Методы
int[,] FillArray() // Метод заполнения массива случайными вещеcтвенными числами
{
    int x = new Random().Next(5);
    int y = new Random().Next(5);
    int[,] matrix = new int[x,y];
    for(int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            matrix[i,j] = new Random().Next(-100,100);
        }        
    }
    return matrix;
}

void PrintArray(int[,] arr) // Метод печати массива
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// int OutIn(string message) // Метод вывода сообщения и чтения с экрана
// {
//     Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }