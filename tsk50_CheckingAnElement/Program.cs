// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

double[,] array = FillArray();
int r = OutIn("Enter the horizontal position: ");
int c = OutIn("Enter the vertical position: ");

if (r < array.GetLength(0))
{
    if (c < array.GetLength(1))
    {
        Console.WriteLine("The desired array element is equal to "+ array[r-1,c-1]);
    }
    else Console.WriteLine("there is no such element");
}
else Console.WriteLine("There is no such element");

// Методы
double[,] FillArray() // Метод заполнения массива случайными вещеcтвенными числами
{
    int x = new Random().Next(100);
    int y = new Random().Next(100);
    double[,] matrix = new double[x,y];
    for(int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            matrix[i,j] = new Random().Next(-100,100);
        }        
    }
    return matrix;
}

// void PrintArray(double[,] arr) // Метод печати массива
// {
//     for(int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

int OutIn(string message) // Метод вывода сообщения и чтения с экрана
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

// PrintArray(array);