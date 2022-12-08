/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
string error = string.Empty;
int rows = 4;
int columns = 5;
int minR = 0;
int maxR = 10;
string avg;

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
    avg = GetAvgColumns(numbers);
    Console.WriteLine("Среднее арифметическое каждого столбца: " + avg.Substring(0, avg.Length-2) + ".");
}

string GetAvgColumns(int[,] array)
{
    string temp = string.Empty;
    double tempnumber;
    for(int col = 0; col < array.GetLength(1); col++)
    {
        tempnumber = 0.0;
        for(int row = 0; row < array.GetLength(0); row++)
        {
            tempnumber += array[row,col];
        }
        temp +=  Math.Round(tempnumber/rows, 1) + "; ";
    }
    return temp;
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