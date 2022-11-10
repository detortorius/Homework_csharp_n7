/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

void FillArrayRandom(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToDouble(new Random().Next(-5000, 5000)) / 10;
        }
    }
}
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],0:f2} |");
        }
        Console.WriteLine();
    }
}
int y = GetNumber("Введите кол-во строк: ");
int x = GetNumber("Введите кол-во столбцов: ");
double[,] matrix = new double[y, x];
FillArrayRandom(matrix);
Console.WriteLine();
PrintMatrix(matrix);