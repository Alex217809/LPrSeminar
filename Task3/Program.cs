void Task9()
{
    // напишите программу которая выводи случайное число из
    // отрезка 10 1000 и и сделайте из него двухзначное убрав посередине цифру
   
    int number = new Random().Next(10, 1000); 

    Console.WriteLine($"выпало случайное число {number}");

    int f_digit = number / 100;
    int s_digit = number % 100;
    int t_digit = number % 10;

    Console.WriteLine($"первая цифра {f_digit}");

    Console.WriteLine($"вторая цифра {s_digit}");

     Console.WriteLine($"третья цифра {t_digit}");


    Console.WriteLine($"двухзначное число {f_digit}{t_digit}");
}

Task9();
