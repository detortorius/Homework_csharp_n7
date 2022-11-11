

/*
Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int[,] InitMatrixArray(int a, int b)
{
    int[,] resultMatrixArray = new int[a, b];
    Random rnd = new Random();

    for (int v = 0; v < a; v++)
    {
        for (int h = 0; h < b; h++)
        {
            resultMatrixArray[v, h] = rnd.Next(0, 999);
        }
    }
    return resultMatrixArray;
}

void PrintMatrix(int[,] matrix)
{
    for (int v = 0; v < matrix.GetLength(0); v++)
    {
        for (int h = 0; h < matrix.GetLength(1); h++)
        {
            Console.Write($"{matrix[v, h],5:f0} |");
        }
        Console.WriteLine();
    }
}
double[] GetAverage(int[,] resultAverage)
{
    double[] arrayAvg = new double[resultAverage.GetLength(1)];
    int summ = 0;
    for (int h = 0; h < resultAverage.GetLength(1); h++)
    {
        for (int v = 0; v < resultAverage.GetLength(0); v++)
        {
            summ += resultAverage[v, h];
        }
        arrayAvg[h] = (double)summ / resultAverage.GetLength(0);
        summ = 0;
    }
    return arrayAvg;
}   


int a = GetNumber("Введите кол-во строк в двумерном массиве: ");
int b = GetNumber("Введите кол-во столбцов в двумерном массиве: ");
int[,] resultAverage = InitMatrixArray(a, b);
PrintMatrix(resultAverage);
double[] avg = GetAverage(resultAverage);
Console.WriteLine();
Console.WriteLine($"Среднее арифметическое значение столбцов {string.Join(";   ",avg)}");