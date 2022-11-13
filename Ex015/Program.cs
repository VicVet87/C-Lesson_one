/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/


string error = string.Empty;
long result = 1;
for (int A = GetIntNumberRequest("Введите число A", false), B = GetIntNumberRequest("Введите натуральное число B", true), i = 1;
     error == string.Empty && i <= B;
     i++ )
{
    result *= A;
}
Console.WriteLine(result);

int GetIntNumberRequest(string message, bool isNaturalNumber)
 {
    int result = 0;
    string? temstring;
    //error = string.Empty;
    do
    {
        error = string.Empty;
        try
        {
            Console.WriteLine(message);
            temstring = Console.ReadLine();
            if(temstring is null)
            {
                error = "Необходимо ввести число"; 
                Console.WriteLine(error);           
            }            
            else
            {
                result = Convert.ToInt32(temstring);
                if (isNaturalNumber && result <= 0)
                {
                    error = "Число должно быть натуральным";
                    Console.WriteLine(error); 
                }                    
            }       
        }   
        catch (System.Exception ex)
        {
            error = ex.Message;
            Console.WriteLine(error); 
        }
    } 
    while (error != string.Empty);   
    return result;
 }