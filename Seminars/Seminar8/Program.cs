//Задание 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю 
//строку массива.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4

//В итоге получается вот такой массив:

//8 4 2 4
//5 9 2 3
//1 4 7 2

//РЕАЛИЗУЕМ МЕТОД ПОИНТЕРЕСНЕЕ ОН БУДЕТ МЕНЯТЬ ЛЮБУЮ С ЛЮБОЙ СТРОКИ

// int[,] Create2DRandomArray(int colums, int rows, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, colums];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue+1);

//         }
//     }

//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] ChangeRows (int[,] array, int row1, int row2)
// {   
//     row1--;
//     row2--;
//     if (row1 > array.GetLength(0) || row2 > array.GetLength(0) || row1 < 0 || row2 < 0)
//     {
//             Console.WriteLine("Invalid row/s");
//             return array;
//     }
//     else
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             int temp = array[row1, j];
//             array[row1, j] = array[row2, j];
//             array[row2, j] = temp;
//         }
//     }
//     return array;

// }


// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of first row to change: ");
// int row1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of second row to change: ");
// int row2 = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(columns, rows, minValue, maxValue);
// Show2DArray(myArray);
// myArray = ChangeRows(myArray, row1, row2);
// Show2DArray(myArray);


//Задание 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//В итоге получается вот такой массив:

//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7
