string message = "Вам письмо!";
string password = "12345@";
int i = 0;
while(i < 3)
{
    i++;
  Console.WriteLine("Введте пароль");
  if(Console.ReadLine()!=password)
  {
     Console.WriteLine("Пароль не верный");
     continue;
  }
  else
  {
    Console.WriteLine(message);
    i=0;
    break;
  }  
}
if (i==3)
    Console.WriteLine("Доступ запрещен!");

