// See https://aka.ms/new-console-template for more information

void Task17()
{
    //Программа задает координаты x и y 
    //определить четверть
    int input(string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }

    int x=input("Введите X: ");
    int y=input("Введите Y: ");
     if (x > 0 && y > 0)
     {
        Console.WriteLine("Точка принадлежит первой четверти");
     }
     else if (x < 0 && y > 0)
     
     {
        Console.WriteLine("Точка принадлежит второй четверти");
     }
     else if (x < 0 && y < 0)
     {
        Console.WriteLine("Точка принадлежит третьей четверти");
     }
     else if (x > 0 && y < 0)
     {
        Console.WriteLine("Точка принадлежит четвертой четверти");
     }
     else 
     {
        Console.WriteLine("Точка лежит на осях");
     }
}

Task17();

