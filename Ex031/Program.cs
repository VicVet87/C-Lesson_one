/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/
string error = string.Empty;
int rows;
int columns;
int minR = 0;
int maxR = 10;
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
    Console.WriteLine();
    SortRowArray(numbers);
    Print2DArray(numbers);    
        
}

void SortRowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int b = 0; b < array.GetLength(1); b++)
            {
                if (array[i, b] < array[i, j])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, b];
                    array[i, b] = temp;
                }
            }
            
        }
    } 
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