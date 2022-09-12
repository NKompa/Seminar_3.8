// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// int[,] array = new int[new Random().Next(1, 10), new Random().Next(1, 10)];

int[,] array = new int[3, 3];

Console.WriteLine("Первоначальный массив:");
for(int i=0; i<array.GetLength(0); i++)
{
	for(int j=0; j<array.GetLength(1); j++)
	{
		array[i, j] = new Random().Next(0, 10);
		Console.Write(array[i, j] + "\t");
		
	}
	Console.WriteLine();
}

Console.WriteLine("Новый массив:");
if (array.GetLength(0)== array.GetLength(1))
{
	for(int i=0; i<array.GetLength(0); i++)
	{
		for(int j=0; j<array.GetLength(1); j++)
		{
			Console.Write(array[j, i] + "\t");
		}
		Console.WriteLine();
	}
}
else Console.WriteLine("Невозможно сделать замену.");
