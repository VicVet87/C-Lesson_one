/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
 значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
x=(b2-b1)/(k1-k2)
*/
string error = string.Empty;
int k1, k2, b1, b2;
double x, y;
while (error != "exit")
{
    Console.WriteLine("Найдем точку пересеченя двух прямых, заданных уравнениями(для выхода введите exit):");
    Console.WriteLine("y = k1 * x + b1");
    Console.WriteLine("y = k2 * x + b2");
    k1 = GetIntNumberRequest("Введите k1", out error);
    if(error == "exit") continue;
    b1 = GetIntNumberRequest("Введите b1", out error);
    if(error == "exit") continue;
    k2 = GetIntNumberRequest("Введите k2", out error);
    if(error == "exit") continue;    
    b2 = GetIntNumberRequest("Введите b2", out error);
    if(error == "exit") continue;
    
    if (k1 == k2 && b1 == b2)
        Console.WriteLine("Прямые совпадают");
    else if(k1 == k2)
        Console.WriteLine("Прямые паралельны");
    else
    {
        x = (double)(b2 - b1)/(k1 - k2);
        y =  k1 * x + b1;
        Console.WriteLine($"Координаты точки пересечения ({x}; {y})");        
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