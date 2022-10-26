/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/
string error = string.Empty;

while (error != "exit")
{
    int [] A = GetСoordinates("Введите через запятую координаты(x,y,z) точки А (для выхода введите exit)", out error);
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
      
    int [] B = GetСoordinates("Введите через запятую координаты(x,y,z) точки B ", out error);
    if (error == string.Empty)
    {
        double d = Math.Sqrt(Math.Pow(B[0]-A[0], 2) + Math.Pow(B[1]-A[1], 2) + Math.Pow(B[2]-A[2], 2));
        Console.WriteLine(Math.Round(d, 2));
    }
    else
    {
        Console.WriteLine(error);
    }
}

int [] GetСoordinates(string message, out string error)
{
    int [] result = new int[3];
    string? temstring;
    error = string.Empty;   

    try
    {
        Console.WriteLine(message);
        temstring = Console.ReadLine();
        if(temstring is null)
        {
            error = "Введите координаты точки";            
        }
        else if (temstring.ToLower() == "exit")
        {
            error = "exit";            
        }
        else
        {
            string [] s = temstring.Split(',');
            if(s.Length>3)
                error = "Неверный формат";            
            result = new int[] { Convert.ToInt32(s[0]), Convert.ToInt32(s[1]), Convert.ToInt32(s[2]) };
        }       
    }
    catch (System.Exception ex) 
    {        
       error = "GetСoordinates: " + ex.Message;
    }
    return result;
}