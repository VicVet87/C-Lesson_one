// Есть программа с бесконечным циклом. Когда пользователь вводит exit программа заканчивается
/*
Добавить  еще 4 команды
SetName – Установить имя
Help – вывести список команд
SetPassword – Установить пароль
Exit – выход
WriteName – вывести имя после ввода пароля
*/
string name = "";
string? password = null;
bool exit = false;
List<String> comands = new List<string> {"Help", "SetName", "SetPassword", "WriteName", "Exit"};
while (true)
{    
    switch ((Console.ReadLine()??"").ToLower())
    {
        case "help": 
                    foreach (string com in comands)
                    {
                        Console.WriteLine(com);
                    }
                    break;
        case "setname":
                       Console.WriteLine("Введите имя");
                       name = Console.ReadLine() ?? "";
                       break;
        case "setpassword":
                       Console.WriteLine("Введите пароль");
                       password = Console.ReadLine();
                       break;
        case "writename":
                        if (password is not null)
                        {
                            Console.WriteLine("Введите пароль");
                            if(password == (Console.ReadLine() ?? ""))
                                Console.WriteLine(name);                                
                            else                            
                                Console.WriteLine("Пароль не верный");
                            break;
                        } 
                        Console.WriteLine(name); break;
        case "exit": exit = true; break;    
    } 
    if(exit) break;
}
