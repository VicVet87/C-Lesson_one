// Есть программа с бесконечным циклом. Когда пользователь вводит exit программа заканчивается
/*
Добавить  еще 4 команды
SetName – Установить имя
Help – вывести список команд
SetPassword – Установить пароль
Exit – выход
WriteName – вывести имя после ввода пароля
*/
string? name = null;
string? password = null;
bool exit = false;
Dictionary<string, string> comands = new Dictionary<string, string>(){
    {"Help",        "вывоодит все доступные команды"},
    {"SetName",     "позволяет задать имя пользователя"},
    {"SetPassword", "позволяет задать пароль пользователя(если установлен необходимо ввести старый пароль)"},
    {"WriteName",   "вывод имени пользователя(если установлин пароль необходимо ввести его)"},
    {"Exit",        "выход из программы"}  
                                                                     };
while (!exit)
{    
    switch ((Console.ReadLine()??"").ToLower())
    {
        case "help": 
                    foreach (KeyValuePair<string, string> com in comands)
                    {
                        Console.WriteLine("{0} - {1}", com.Key, com.Value);
                    }
                    break;
        case "setname":
                       Console.WriteLine("Введите имя");
                       name = Console.ReadLine();
                       break;
        case "setpassword":
                        if (password is not null)
                        {
                            Console.WriteLine("Введите старый пароль");
                            if(password == Console.ReadLine())
                            {
                                Console.WriteLine("Введите новый пароль");
                                password = Console.ReadLine();                                
                            }                                
                            else                            
                                Console.WriteLine("Пароль не верный");
                            break;
                        } 
                       Console.WriteLine("Введите пароль");
                       password = Console.ReadLine();
                       break;
        case "writename":
                        if (name is null)
                        {
                            Console.WriteLine("Имя не задано");
                            break;
                        }
                        else if (password is not null)
                        {
                            Console.WriteLine("Введите пароль");
                            if(password == (Console.ReadLine() ?? ""))
                                Console.WriteLine(name);                                
                            else                            
                                Console.WriteLine("Пароль не верный");
                            break;
                        } 
                        else
                        {
                            Console.WriteLine(name);
                            break;
                        }
        case "exit": exit = true;
                     break;    
    }     
}
