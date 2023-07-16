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
   
//     Console.WriteLine ("Введите первое число  ");
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

void Task11()
{
    // напишите программу которая принимает на вход число и проверяет кратно ли 
    // оно 7 и 23 одновременно
   
    Console.WriteLine ("Введите первое число  ");
    int number_a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Введите второе число  ");
    int number_b = Convert.ToInt32(Console.ReadLine());
    if (number_a % number_b == 0)
    {
        Console.WriteLine ($"Число {number_a} кратно числу {number_b}");
    }
    else Console.WriteLine ($"Число {number_a} не кратно числу {number_b}");
}


Task11 ();