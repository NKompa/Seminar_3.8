// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

int rows = 5;
int columns = 5;
 
int[,] matrix = new int[rows, columns];
 
int minValue = int.MaxValue; 
int minIndexRow = 0;        
int minIndexColumn = 0;   
 
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(11);
        Console.Write(matrix[i, j] + "\t");
        if (minValue > matrix[i, j])
        {
            minValue = matrix[i, j];
            minIndexRow = i;
            minIndexColumn = j;
        }
     }
    Console.WriteLine();
}
Console.WriteLine("Минимум:" + minValue);
System.Console.WriteLine("Результат:");
for (int i = 0; i < rows; i++) // rows = GetLength(0)
{
    if (i != minIndexRow)
    {
        for (int j = 0; j < columns; j++) //columns - GetLength(1)
        {
            if (j != minIndexColumn)
            {
                Console.Write(matrix[i,j] + "\t");
            }
        }
        System.Console.WriteLine();
    }
}