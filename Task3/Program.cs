// void Task9()
// {
// напишите программу которая выводи случайное число из
// отрезка 10 1000 и и сделайте из него двухзначное убрав посередине цифру

//     int number = new Random().Next(10, 1000); 

//     Console.WriteLine($"выпало случайное число {number}");

//     int f_digit = number / 100;
//     int s_digit = number % 100;
//     int t_digit = number % 10;

//     Console.WriteLine($"первая цифра {f_digit}");

//     Console.WriteLine($"вторая цифра {s_digit}");

//      Console.WriteLine($"третья цифра {t_digit}");


//     Console.WriteLine($"двухзначное число {f_digit}{t_digit}");
// }

// Task9();

// void Task10()
// {
//     // напишите программу которая принимает на вход число и проверяет кратно ли 
//     // оно 7 и 23 одновременно

//     Console.WriteLine ("Введите число  ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     if (number % 7 == 0)
//     {
//         if (number % 23 == 0)
//         {
//            Console.WriteLine ("Да, данное число кратно 7 и 23 одновременно"); 
//         }
//     }
//         else Console.WriteLine ("Нет,данное число не кратно 7 и 23 одновременно");
// }


// Task10 ();

// void Task11()
// {
//     // напишите программу которая принимает на вход число и проверяет кратно ли 
//     // первое число второму

//     Console.WriteLine ("Введите первое число  ");
//     int number_a = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine ("Введите второе число  ");
//     int number_b = Convert.ToInt32(Console.ReadLine());
//     if (number_a % number_b == 0)
//     {
//         Console.WriteLine ($"Число {number_a} кратно числу {number_b}");
//     }
//     else Console.WriteLine ($"Число {number_a} не кратно числу {number_b}");
// }

// Task11();

// void Task12()
// {
// // напишите программу которая принимает на вход число и проверяет кратно ли
// // первое число второму новый  способ

// int input(string text)
// //переменную создаем так как дважды одно и то же действие
//     {
//         Console.WriteLine(text);
//         return Convert.ToInt32(Console.ReadLine());
//     }

//     int num_a = input("Введите первое число ");
//     int num_b = input("Введите второе число ");
//     int div = num_a % num_b;

// if (div == 0)
//     {
//         Console.WriteLine($"Число {num_a} кратно числу {num_b}");
//     }
//     else 
//     {
//         Console.WriteLine($"Число {num_a} НЕ кратно числу {num_b}."
//                      + $" Остаток от деления равен {div}");
//        }
    

//}



 void Task14()
 // другой способ решения
 {
    int input(string text)
     {
         Console.WriteLine(text);
         return Convert.ToInt32(Console.ReadLine());
     }

    int number = input("Введите число   ");

        if (number % 7 == 0 & number % 23 == 0)
    {
        Console.WriteLine ($"Да, данное число {number} кратно 7 и 23 одновременно");
    }
    // & и
    // I или
        else 
    {
        Console.WriteLine ($"Нет,данное число {number} НЕ кратно 7 и 23 одновременно");
    }
 }

 void Task15()
 // Является ли одно число квадратом другого
 {
    int input(string text)
     {
         Console.WriteLine(text);
         return Convert.ToInt32(Console.ReadLine());
     }

    int num_f = input("Введите первое число   ");
    int num_s = input("Введите второе число   ");
     if (num_f * num_f == num_s || num_s * num_s == num_f)
     {
        Console.WriteLine ("Является кврадартом");
     }
    
    // & и
    // | или
    // && краткое и
    // || красткое или
     else
    {
        Console.WriteLine ("Не является кврадартом");
    }
 }

Console.Clear();
Task15();