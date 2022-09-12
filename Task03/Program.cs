// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

int rows = 5;
int columns = 5;
 
int[,] matrix = new int[rows, columns];
 
int minValue = int.MaxValue; 
int minIndexRows = 0;        
int minIndexColumns = 0;   
 
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(11);
        Console.Write(matrix[i, j] + "\t");
        if (minValue > matrix[i, j])
                {
            minValue = matrix[i, j];
            minIndexRows = i;
            minIndexColumns = j;
        }
     }
    Console.WriteLine();
}
Console.WriteLine("Минимум:" + minValue);
System.Console.WriteLine("Результат:");
for (int i = 0; i < rows; i++) // rows = GetLength(0)
{
    if (i != minIndexRows)
    {
        for (int j = 0; j < columns; j++) //columns - GetLength(1)
        {
            if (j != minIndexColumns)
            {
                Console.Write(matrix[i,j] + "\t");
            }
        }
        System.Console.WriteLine();
    }
}