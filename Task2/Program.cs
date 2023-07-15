void Task()
{
    // напишите программу которая выводи случайное числдо из
    // отрезка 10 99 и показывает наибольшую цыфру числа
    Random rnd = new Random();

    int number = rnd.Next(10, 100);
    // можно объединить в одну строку

    //int number = new Random().Next(10, 100); 

    Console.WriteLine($"выпало случайное число {number}");

    int f_digit = number / 10;
    int s_digit = number % 10;

    Console.WriteLine($"первая цифра {f_digit}");

    Console.WriteLine($"вторая цифра {s_digit}");


    int max;
    if (f_digit > s_digit) max = f_digit;
    else max = s_digit;

    Console.WriteLine($"максимальная цифра {max}");
}

