// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// 78 -> 8

// 12-> 2

// 85 -> 8

// void MaxDecimal (int num)
// {
//     int ed = num % 10;
//     int dec = num / 10;
//     if (ed > dec)
//     {
//         Console.WriteLine($"Большая цифра числа{num} -> {ed}");
//     }
//     else
//     {
//         Console.WriteLine($"Большая цифра числа{num} -> {dec}");
//     }
// }

// int randomnumber = new Random().Next(10, 99 + 1);

// MaxDecimal(randomnumber);

// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// 456 -> 46

// 782 -> 72

// 918 -> 98

int DeleteDecimal(int num)
{
    int sot = num / 100;
    int ed = num % 10;
    return sot * 10 + ed;

}

int randomnumber = new Random().Next(100, 1000);
Console.WriteLine(randomnumber);
// int result = DeleteDecimal(randomnumber);
// Console.WriteLine(result);
Console.WriteLine(DeleteDecimal(randomnumber));

// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// 14  ->  нет
// 46  ->  нет
// 161 ->  да

void Rest(int num1, int num2)
{
    int rez = num2 % num1;
    if (rez == 0)
    {
        Console.WriteLine($"1: {num1}, 2: {num2} Второе число кратно первому");
    }
    else
    {
        Console.WriteLine($"1: {num1}, 2: {num2} Второе число не кратно первомуб остаток {rez}");
    }
}

Rest(3, 9);


bool DoubleCheck(int num)
{
    int check1 = num % 7;
    int check2 = num % 23;

    if (check1 == 0 && check2 == 0)
    {
        return true;
    }
    else { return false; }
}

Console.WriteLine(DoubleCheck(161));