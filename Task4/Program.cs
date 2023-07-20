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



int input(string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }

void Task18()
{
   int input(string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }
    //Программа задает координаты x и y 
    //определить четверть
    
    int quater = input("номер четверти ");
    
     if (quater == 1)
     {
        Console.WriteLine("x > 0, y > 0");
     }
     else if (quater == 2)
     
     {
        Console.WriteLine("x < 0, y > 0");
     }
     else if (quater == 3)
     {
        Console.WriteLine("x < 0, y < 0");
     }
     else if (quater == 4)
     {
        Console.WriteLine("x > 0, y < 0");
     }
     else 
     {
        Console.WriteLine("Номер четверти введен неверно");
     }
}




// задача по нахождению середины отрезка в системе координат
// по теореме пифагора как гипотинузу
// если методы 

void Task21()
{
   int input(string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }

    double number(int x1, int x2, int y1, int y2)
   // метод, позволяющий внести сразу 4 переменных и вернуть их с формулой 
    {
      return Math.Round((Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2))), 2);
    }


      int x1 = input("Введите координаты X первой точки  ");
      int y1 = input("Введите координаты Y первой точки  ");
      int x2 = input("Введите координаты X второй точки  ");
      int y2 = input("Введите координаты Y второй точки  ");

      Console.WriteLine("Расстояние между точками ");
      Console.WriteLine(number(x1, x2, y1, y2));
        
     
}


// задача по нахождению середины отрезка в системе координат
// по теореме пифагора как гипотинузу
// если методы 

void Task21_1()
{
   int input(string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }

    
      int x1 = input("Введите координаты X первой точки  ");
      int y1 = input("Введите координаты Y первой точки  ");
      int x2 = input("Введите координаты X второй точки  ");
      int y2 = input("Введите координаты Y второй точки  ");

      double result = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));
      // т. к. квадратный корень то используется переменная
      // double а не int
      result = Math.Round(result, 2);
      // округление до каког знака

     
     Console.WriteLine($"Расстояние между точками равно {result}");
     
}

Console.Clear();
Task21_1();

