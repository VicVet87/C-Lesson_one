/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

string error = string.Empty;
uint m = 0;
uint n = 0;
uint funcA = 0;
while (error != "exit")
{    
    Console.WriteLine("Вычисление функции Аккермана A(m,n) где m и n два неотрицательных числа ");
    m  = GetUIntNumberRequest("Введите положительное число m: ", out error);
    if(error == "exit") continue;
    n  = GetUIntNumberRequest("Введите положительное число n: ", out error);
    if(error == "exit") continue; 
    if(m > 3 || n > 5)
    {
        Console.WriteLine("m должно быть меньше 4 и т должно быть меньше 6 иначе произойдет переполнение");    
    }
    funcA = A(m,n);    
    Console.WriteLine("A(m,n) = " + funcA);     
}

// функция Аккермана
static uint A(uint m, uint n)
{ 
    if (m == 0)
        return n + 1;
    else if ((m != 0) && (n == 0))
        return A(m - 1, 1);
    else
        return A(m - 1, A(m, n - 1));     
}

uint GetUIntNumberRequest(string message, out string error)
 {
    uint result = 0;
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
            result = Convert.ToUInt32(tempstring);
        }       
    }
    catch (System.Exception ex)
    {
       Console.WriteLine(ex.Message);
       GetUIntNumberRequest(message, out error);
    }
    return result;
 }
