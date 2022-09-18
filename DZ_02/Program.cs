// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int colCount = 6;
int rowCount = 5;
int[,] arr = GenerateArray(rowCount, colCount);
PrintArray(arr);
Console.WriteLine("Сумма элементов строки");
int [] sumArr = new int [rowCount];
for (int i=0;i<rowCount;i++)
{
    for(int j=0;j<colCount;j++)
    {
        sumArr[i]+=arr[i,j];
    }        
} 
Console.WriteLine(string.Join("\t", sumArr));   
int minValue = sumArr[0];
int minValuei = 1;
for (int i = 0; i < rowCount; i++)
{
    if(sumArr[i] < minValue)
   {
    minValue = sumArr[i];
    minValuei = i+1;
    }
}
Console.WriteLine();
Console.WriteLine("Минимальное значение - " + minValue + "  Находится в строке - " + minValuei);
Console.WriteLine();


