/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет. Во вводе первая цифра - номер строки, вторая - столбца.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/
string error = string.Empty;
int rows = 4;
int columns = 5;
int minR = 0;
int maxR = 10;
int tempRows;
int tempColumns;

while (error != "exit")
{    
    int[,] numbers = new int[rows, columns];
    FillRandomArray(numbers);
    Print2DArray(numbers);
    Console.WriteLine("Задайте элемент массива(для выхода введите exit)");
    tempRows  = GetIntNumberRequest("Введите строку: ", out error);
    if(error == "exit") continue;
    tempColumns = GetIntNumberRequest("Введите столбец: ", out error);
    if(error == "exit") continue;    
    if (tempRows > rows || tempColumns > columns || tempRows < 1 || tempColumns < 1)
    {
       Console.WriteLine("такого числа в массиве нет"); 
    }
    else
        Console.WriteLine("элемент равен " + numbers[tempRows - 1, tempColumns -1]);
    Console.WriteLine();
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