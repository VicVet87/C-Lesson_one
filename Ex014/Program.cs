/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.*/
string error = string.Empty;
uint tempNumber;
string result;
while (error != "exit")
{
    tempNumber = GetIntNumberRequest("Введите положительное число(для выхода введите exit)", out error);
    
    if (error == string.Empty)
    {
        result = string.Empty;
        for (int i = 1; i < tempNumber; i++)
        {
            result += Math.Pow(i,3) + ", ";
        }
        Console.WriteLine(result + Math.Pow(tempNumber,3));
    }
    else
    {
        Console.WriteLine(error);
    }
}

uint GetIntNumberRequest(string message, out string error)
 {
    uint result = 0;
    string? temstring;
    error = string.Empty;
    try
    {
        Console.WriteLine(message);
        temstring = Console.ReadLine();
        if(temstring is null)
        {
            error = "Введите число";            
        }
        else if (temstring.ToLower() == "exit")
        {
            error = "exit";            
        }
        else
        {
            result = Convert.ToUInt32(temstring);
        }       
    }
    catch (System.Exception ex)
    {
       error = "GetIntNumberRequest:" + ex.Message;
    }
    return result;
 }