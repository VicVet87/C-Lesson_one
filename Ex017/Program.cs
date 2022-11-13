/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
string error = string.Empty;
int tempNumber;
int result;
while (error != "exit")
{
    tempNumber = GetIntAbsNumberRequest("Введите число(для выхода введите exit)", out error);
    
    if (error == string.Empty)
    {
        result = 0;
        for (;tempNumber > 0; tempNumber /= 10)
        {
            result += tempNumber % 10;            
        }        
        Console.WriteLine("Сума цифр в числе равна " + result);
    }
    else
    {
        if(error == "exit")
            continue;
        Console.WriteLine(error);
    }
}

int GetIntAbsNumberRequest(string message, out string error)
 {
    int result = 0;
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
            result = Math.Abs(Convert.ToInt32(temstring));
        }       
    }
    catch (System.Exception ex)
    {
       error = "GetIntNumberRequest:" + ex.Message;
    }
    return result;
 }