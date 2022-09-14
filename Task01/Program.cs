// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

Console.WriteLine("Первоначальный массив:");
int[,] array = new int[new Random().Next(3, 10), new Random().Next(3, 10)];

for(int i=0; i<array.GetLength(0); i++)
{
	for(int j=0; j<array.GetLength(1); j++)
	{
		array[i, j] = new Random().Next(0, 10);
		Console.Write(array[i, j] + "\t");
	}
	Console.WriteLine();
}
int[] temp = new int[array.GetLength(1)];

for(int k=0; k<array.GetLength(1); k++)
{
	temp[k]=array[0, k];
	array[0, k]= array[array.GetLength(0)-1, k];
	array[array.GetLength(0)-1, k] = temp[k];
}
Console.WriteLine("Новый массив:");

for(int i=0; i<array.GetLength(0); i++)
{
	for(int j=0; j<array.GetLength(1); j++)
	{
		Console.Write(array[i, j] + "\t");
	}
	Console.WriteLine();
}