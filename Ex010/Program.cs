/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
 (Использовать только математические операции, нельзя использовать число как строку по типу number[2])*/
string error = string.Empty;
int thirdDigitNumber;
int tempNumber;
while (error != "exit")
{
    tempNumber = GetIntNumberRequest("Введите число", out error);
    
    if (error == string.Empty)
    {
        if (Math.Abs(tempNumber) < 100)
        {
            Console.WriteLine("третьей цифры нет");
        }
        else
        {
            thirdDigitNumber = GetThirdDigitNumber(tempNumber, out error);
            Console.WriteLine(error == string.Empty ? "Третья цифра " + thirdDigitNumber : error);
        }
    }
    else
    {
        Console.WriteLine(error);
    }
}


 int GetIntNumberRequest(string message, out string error)
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
            error = "Необходимо ввести число";            
        }
        else if (temstring.ToLower() == "exit")
        {
            error = "exit";            
        }
        else
        {
            result = Convert.ToInt32(temstring);
        }       
    }
    catch (System.Exception ex)
    {
       error = "GetIntNumberRequest:" + ex.Message;
    }
    return result;
 }

 int GetThirdDigitNumber(int number, out string error)
 {
    int result = 0;
    try
    {
        error = string.Empty;
        int numberDigit = 0;
        result = number;
        while(result%10 != 0)
        {
            result/=10;
            numberDigit++;
        }        
        result = number/Convert.ToInt32(Math.Pow(10, numberDigit-3))%10;
        result = Math.Abs(result);
    }
    catch (System.Exception ex)
    {
        error = "GetThirdDigitNumber:" + ex.Message;
    }    
    return result;
 }
