/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
(Использовать только математические операции, нельзя использовать число как строку по типу number[1])*/
int secondnum;
string text;
string error;
while (true)
{
  Console.WriteLine("Введите трехзначное число");
  text = Console.ReadLine() ?? "";
  if(text.ToLower() == "exit")
  break;
  if(text.Substring(0, 1) == "-")
  text = text.Substring(1, text.Length - 1);
  if(text.Length != 3)
  {
    Console.WriteLine("Число должно быть трехзначным");
    continue;
  }
  else
  {
    secondnum = SecondNumeral(text, out error);
    if(error == string.Empty)
    Console.WriteLine(secondnum);
    else
    Console.WriteLine(error);
  }    
}

int SecondNumeral(string text, out string error)
{
    int num = -1;
    error = string.Empty;
    try
    {        
        num = Convert.ToInt32(text);
        num = num/10%10;
    }
    catch (System.Exception ex)
    {        
       error = ex.Message;
    }
    return num;
}