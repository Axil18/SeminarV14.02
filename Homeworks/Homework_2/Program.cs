// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// int DeleteDecimal(int num)
// {
//     int dec = num % 100;
//     int num2 = dec / 10;
//     return num2;
// }

// int randomnumber = new Random().Next(100, 1000);
// Console.WriteLine(randomnumber);
// // int result = DeleteDecimal(randomnumber);
// // Console.WriteLine(result);
// Console.WriteLine(DeleteDecimal(randomnumber));

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// int Prompt(string text)
// {
//     Console.WriteLine(text);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int GetThirdNumber(int number)
// {
//     while (number > 999)
//     {
//         number /= 10;
//     }
//     return number % 10;
// }

// bool ValidateNumber(int number)
// {
//     if (number < 100)
//     {
//         Console.WriteLine("3d digit is not exist");
//         return false;
//     }
//     return true;

// }

// int number = Prompt("Enter a number: ");
// if (ValidateNumber(number))
// {
//     Console.WriteLine(GetThirdNumber(number));
// }

int Prompt(string text)
{
    Console.WriteLine(text);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool IsWeekend(int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}

bool Weekday(int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine("This is not a day of the week");
    return false;
}

int weekDay = Prompt("Enter the day of the week: ");
if (Weekday(weekDay))
{
    if (IsWeekend(weekDay))
{
    Console.WriteLine("It is a weekend day");

}
else{
    Console.WriteLine("It is not a weekend day");
}
}