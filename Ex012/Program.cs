/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
(Использовать только математические операции, нельзя использовать число как строку по типу number[1])
14212 -> нет
12821 -> да
23432 -> да*/
bool polindrome;
string text;
string error;
while (true)
{
  Console.WriteLine("Введите пятизначное число(для выхода введите exit)");
  text = Console.ReadLine() ?? "";
  if(text.ToLower() == "exit")
  break;
  if(text.Substring(0, 1) == "-")
  text = text.Substring(1, text.Length - 1);
  if(text.Length != 5)
  {
    Console.WriteLine("Число должно быть пятизначным");
    continue;
  }
  else
  {
    polindrome = IsPolindrome(text, out error);
    if(error == string.Empty)
    Console.WriteLine(polindrome ? "да" : "нет");
    else
    Console.WriteLine(error);
  }    
}

bool IsPolindrome(string text, out string error)
{
    bool result = false;
    error = string.Empty;
    try
    {        
        int num = Convert.ToInt32(text);
        //result = num/10000 == num%10 ? num/1000%10 == num%100/10 ? true : false : false;  //можно так 1-й строкой
        if (num/10000 == num%10) //или так
        {
            if (num/1000%10 == num%100/10)
            {
                result = true;
            }
        }
    }
    catch (System.Exception ex)
    {        
       error = ex.Message;
    }
    return result;
}