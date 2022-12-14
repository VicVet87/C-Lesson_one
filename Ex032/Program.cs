/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4  2*3 + 4*3 = 6 +12 = 18 2*4 + 4*3 = 8+12 = 20
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
string error = string.Empty;
int rows;
int columns;
int minR = 0;
int maxR = 10;

while (error != "exit")
{
    Console.WriteLine("Умножение матриц - для упрощения будем брать квадратные матрицы одного и того же порядка(для выхода введите exit)");
    rows  = GetIntNumberRequest("Введите размерность матриц: ", out error);
    if(error == "exit") continue;
    columns = rows;    
    int[,] matrixA = new int[rows, columns];
    FillRandomArray(matrixA);
    Print2DArray(matrixA);
    Console.WriteLine("x");
    int[,] matrixB = new int[rows, columns];
    FillRandomArray(matrixB);
    Print2DArray(matrixB); 
    Console.WriteLine("=");
    int[,] matrixC = new int[rows, columns];    
    matrixC = GetMultiplicationMatrix(matrixA, matrixB);
    Print2DArray(matrixC);        
}

int[,] GetMultiplicationMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[rows, columns];
    for(int row = 0; row < matrixC.GetLength(0); row++)
    {
        for(int col = 0; col < matrixC.GetLength(1); col++)
        {
            int temp = 0;
            for (int i = 0; i < rows; i++)
            {
                temp += matrixA[row,i] * matrixB[i,col];
            }            
            matrixC[row,col] = temp;
        }
    } 
    return matrixC;
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