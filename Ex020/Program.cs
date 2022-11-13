/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным значениями элементов массива.
[3 7 22 2 78] -> 76*/

string error = string.Empty;
uint size;
double min = -99;
double max = 99;
double minNumber;
double maxNumber;
while (error != "exit")
{
    size = GetUIntRequest("Введтие размер массива(для выхода введите exit): ");    
    if (error == string.Empty)
    {
        if(size < 2)
        {
            Console.WriteLine("В массиве должно быть хотябы 2 элемента");
            continue;
        }
        double[] numbers = new double[size];        
        FillArrayRundomNumbers(numbers,  min, max);
        WriteArray(numbers);
        minNumber = numbers[0];
        maxNumber = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if(numbers[i] > maxNumber)
                maxNumber = numbers[i];
            else if(numbers[i] < minNumber)
                minNumber = numbers[i];
        }
        Console.WriteLine("Разница между максимальным и минимальным элемнтами массива равна " + Math.Round(maxNumber - minNumber, 2));
    }
    else
    {
        if(error == "exit")
            continue;
        Console.WriteLine(error);
    }
}



void FillArrayRundomNumbers(double[] array, double min = 1, double max = 99)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * (max - min) + min;
    }
}

void WriteArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(Math.Round(array[i], 2) + ", ");
    }
    Console.Write(Math.Round(array[size - 1], 2) +  "]");
    Console.WriteLine();
}

uint GetUIntRequest(string message)
{
    uint result = 0;
    string? temstring;
    error = string.Empty;
    try
    {
        Console.Write(message);
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
       error = "GetUIntRequest: " + ex.Message;
    }
    return result;
}


