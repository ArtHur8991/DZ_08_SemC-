// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

int colCount = 2;
int rowCount = 2;
int[,] arrA = GenerateArray(rowCount, colCount);
PrintArray(arrA);
Console.WriteLine();
int[,] arrB = GenerateArray(rowCount, colCount);
PrintArray(arrB);
Console.WriteLine();
int[,] arrC = new int [rowCount,colCount];
for (int i = 0; i < arrC.GetLength(0); i++)
{
    for (int j = 0; j < arrC.GetLength(1); j++)
    {
        for (int k = 0; k < colCount; k++)
        {
            arrC[i,j] += arrA[i,k] * arrB[k,j];
        }
    Console.Write(arrC[i,j] + "\t");
    }
    Console.WriteLine();
}