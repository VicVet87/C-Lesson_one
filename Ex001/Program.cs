// Есть программа с бесконечным циклом. Когда пользователь вводит exit программа заканчивается
while (true)
{     
    if((Console.ReadLine()??"").ToLower()=="exit") break;
}
