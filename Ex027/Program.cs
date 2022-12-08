/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/
string error = string.Empty;
int rows;
int columns;
int minR = -10;
int maxR = 10;

while (error != "exit")
{
    Console.WriteLine("Задайте двумерный массив(для выхода введите exit)");
    rows  = GetIntNumberRequest("Введите количество строк: ", out error);
    if(error == "exit") continue;
    columns = GetIntNumberRequest("Введите количество столбцов: ", out error);
    if(error == "exit") continue;    
    double[,] numbers = new double[rows, columns];
    FillRandomArray(numbers);
    Print2DArray(numbers);
}



void FillRandomArray(double[,] array)
{
    Random rnd = new Random();
    for(int row = 0; row < array.GetLength(0); row++)
    {
        for(int col = 0; col < array.GetLength(1); col++)
        {
            array[row,col] = Math.Round(rnd.NextDouble()*Math.Abs((minR - maxR)) + minR, 2);
        }
    }
}

void Print2DArray(double[,] array)
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