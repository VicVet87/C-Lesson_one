/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
string error = string.Empty;
int number = 0;
string temp;

while (error != "exit")
{
    temp = string.Empty;
    Console.WriteLine("Получение всех натуральных чисел от N до 1");
    number  = GetIntNumberRequest("Введите число N: ", out error);
    if(error == "exit") continue;    
    temp = "\"" + GetNaturalNumber(number);
    temp += "1\"";
    Console.WriteLine(temp); 
}

string GetNaturalNumber(int n)
{
   temp += n + ", ";
   n--;
   if(n > 1)
    GetNaturalNumber(n);
    return temp;
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