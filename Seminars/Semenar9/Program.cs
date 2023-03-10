//Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке 
//от 1 до N.

//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"



// void ShowNumbers(int n)
// {
//     if(n>1)
//     {
//         ShowNumbers(n-1);
//         //Console.Write(n + " ");
//     }
//     Console.Write(n + " ");
// }

// Console.WriteLine("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// ShowNumbers(n);

//Задание 2. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// int FindSum(int num)
// {
//     if(num>0)
//         return FindSum(num/10) + num%10;
//     else
//         return num;
// }

// Console.WriteLine(FindSum(453));

//Задача 3. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в 
//промежутке от M до N.

//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 5, 6, 7, 8"


//Задача 4.Напишите программу, которая на вход принимает два числа A и B, и возводит число А в 
//целую степень B с помощью рекурсии.

//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8

int FindSum(int num)
{
    if(num>0)
        return FindSum(num/10) + num%10;
    else
        return num;
}

Console.WriteLine(FindSum(453));