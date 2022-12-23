// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.Write("Enter the number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of colomns: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[m,n];

// Методы
void FillArray(double[,] array) // Метод заполнения массива случайными веще твенными числами
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Convert.ToDouble (new Random().Next(-1000,1000))/10;
        }        
    }
}

void PrintArray(double[,] array) // Метод печати массива
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int OutIn(string message) // Метод вывода сообщения и чтения с экрана
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

FillArray(matrix);
PrintArray(matrix);