/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4*/
string error = string.Empty;
while(error != "exit")
{    
    int count = 0;
    int [] arr = GetNubers("Введите целые числа через запятую", out error);
    if(error != string.Empty)
    {
        if(error == "exit")
            break;
        else
        {
            Console.WriteLine(error);
            continue;
        }
    }
    else
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if(arr[i] > 0)
                count++; 
        }
        Console.WriteLine(count);
    } 
    
}

int [] GetNubers(string message, out string error)
{
    int [] result = new int[1];
    string? temstring;
    error = string.Empty;   

    try
    {
        Console.WriteLine(message);
        temstring = Console.ReadLine();
        if(temstring is null)
        {
            error = "Введите числа";            
        }
        else if (temstring.ToLower() == "exit")
        {
            error = "exit";            
        }
        else
        {
            string [] s = temstring.Split(',');
            result = new int[s.Length];            
            for (int i = 0; i < s.Length; i++)
            {
                result [i] = Convert.ToInt32(s[i]);
            }
        }       
    }
    catch (System.Exception ex) 
    {        
       error = "GetNubers: " + ex.Message;
    }
    return result;
}