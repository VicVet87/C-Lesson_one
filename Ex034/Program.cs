/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

string error = string.Empty;
int m = 0;
int n = 0;
int sum = 0;

while (error != "exit")
{    
    Console.WriteLine("Получение суммы натуральных элементов в промежутке от M до N");
    m  = GetIntNumberRequest("Введите число M: ", out error);
    if(error == "exit") continue;
    n  = GetIntNumberRequest("Введите число N: ", out error);
    if(error == "exit") continue;
    if(m > n)
    {
        Console.WriteLine("M должно быть меньше N");
        continue;   
    }    
    sum = 0;
    sum = GetSumNaturalNumber();
    Console.WriteLine(sum); 
}

int GetSumNaturalNumber()
{
   sum += m;
   m++;
   if(m <= n)
    GetSumNaturalNumber();
    return sum;
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