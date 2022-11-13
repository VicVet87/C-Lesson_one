/*Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/
string error = string.Empty;
uint size;
while (error != "exit")
{
    size = GetUIntRequest("Введтие размер массива(для выхода введите exit): ");    
    if (error == string.Empty)
    {
        if(size == 0)
        {
            Console.WriteLine("В массиве должен быть хотябы 1 элемент");
            continue;
        }
        int[] numbers = new int[size];
        FillArrayRundomNumbers(numbers);
        WriteArray(numbers);
    }
    else
    {
        if(error == "exit")
            continue;
        Console.WriteLine(error);
    }
}



void FillArrayRundomNumbers(int[] array, int min = 1, int max = 99)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
}

void WriteArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[size - 1] +  "]");
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


