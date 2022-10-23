//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
string error = string.Empty;
int numberDay;

while (error != "exit")
{
    numberDay = GetIntNumberRequest("Введите номер дня недели(1-7)", out error);
    
    if (error == string.Empty)
    {
        if (numberDay < 1 || numberDay > 7)
        {
            Console.WriteLine("Неверное число, число должно быть от 1 до 7 ");
        }
        else
        {
            Console.WriteLine(numberDay > 5 ? "да" : "нет");
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
            error = "Необходимо ввести число от 1 до 7";            
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
