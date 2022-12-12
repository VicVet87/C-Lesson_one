/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
string error = string.Empty;
int rows;
int columns;
int minR = 0;
int maxR = 10;
int rowSum;
int rowNumMinSum = 0;
int rowMinSum;
while (error != "exit")
{
    Console.WriteLine("Задайте двумерный массив(для выхода введите exit)");
    rows  = GetIntNumberRequest("Введите количество строк: ", out error);
    if(error == "exit") continue;
    columns = GetIntNumberRequest("Введите количество столбцов: ", out error);
    if(error == "exit") continue;    
    int[,] numbers = new int[rows, columns];
    FillRandomArray(numbers);
    Print2DArray(numbers);
    rowMinSum = 0;
    for(int row = 0; row < numbers.GetLength(0); row++)
    {
        rowSum = 0;
        for(int col = 0; col < numbers.GetLength(1); col++)
        {
            rowSum += numbers[row,col];
        }
        if(rowMinSum == 0 || rowSum < rowMinSum) 
        {
            rowMinSum = rowSum;
            rowNumMinSum = row;
        }
    }
    Console.WriteLine(rowNumMinSum + 1 + "строка");    
}



void FillRandomArray(int[,] array)
{
    Random rnd = new Random();
    for(int row = 0; row < array.GetLength(0); row++)
    {
        for(int col = 0; col < array.GetLength(1); col++)
        {
            array[row,col] = rnd.Next(minR, maxR);
        }
    }
}

void Print2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {            
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int GetIntNumberRequest(string message, out string error)
 {
    int result = 0;
    string? tempstring;
    error = string.Empty;
    try
    {
        Console.WriteLine(message);
        tempstring = Console.ReadLine();
        if(tempstring is null)
        {
            error = "Введите число";            
        }
        else if (tempstring.ToLower() == "exit")
        {
            error = "exit";            
        }
        else
        {
            result = Convert.ToInt32(tempstring);
        }       
    }
    catch (System.Exception ex)
    {
       Console.WriteLine(ex.Message);
       GetIntNumberRequest(message, out error);
    }
    return result;
 }
