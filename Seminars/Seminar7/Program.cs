//Задача 1. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

int[,] Create2DRandomArray(int colums, int rows, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, colums];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue+1);

        }
    }

    return newArray;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] array = Create2DRandomArray(columns, rows, minValue, maxValue);

// Show2DArray(array);

//Задача 2. ****Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: 
//Aₘₙ = m+n.
// Выведите полученный массив на экран.

int[,] Create2DArray(int colums, int rows)
{
    int[,] newArray = new int[rows, colums];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            newArray[i, j] = i+j;
        }
    }

    return newArray;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// Show2DArray(Create2DArray(columns, rows));

//Задача 3.Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти 
//элементы на их квадраты.

//Например, изначально массив выглядел вот так:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//Новый массив будет выглядеть вот так:

//1 4 7 2
//5 **81  ** 2 **9**
//8 4 2 4



//Задача 4. адайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
//(с индексами (0,0); (1;1) и т.д.

//Например, задан массив:

//1 4 7 2                      Главная диагональ это когда i и j совпадают
//5 9 2 3
//8 4 2 4

//Сумма элементов главной диагонали: 1+9+2 = 12

//Задача 3.Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

//Например, изначально массив выглядел вот так:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//Новый массив будет выглядеть вот так:

//1 4 7 2
//5 **81  ** 2 **9**
//8 4 2 4

// int[,] ConvertArray(int[,] array)
// {
//   int[,] result = new int[array.GetLength(0), array.GetLength(1)];

//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       if ((i + 1) % 2 == 0 && (j + 1) % 2 == 0)
//       {
//         result[i, j] = Convert.ToInt32(Math.Pow(array[i, j], 2));
//       }
//       else
//       {
//         result[i, j] = array[i, j];
//       }
//     }
//   }
//   return result;
// }

// Console.Write("Input number of rows in array: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of columns in array: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(m, n);
// Show2DArray(myArray);
// Show2DArray(ConvertArray(myArray));

// ======================================================================================

//Задача 4. адайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

//Например, задан массив:

//1 4 7 2                      Главная диагональ это когда i и j совпадают
//5 9 2 3
//8 4 2 4

//Сумма элементов главной диагонали: 1+9+2 = 12

// int SummOfElements(int[,] array)
// {
//   int num = Math.Min(array.GetLength(0), array.GetLength(1));

//   int summ = 0;

//   for (int i = 0; i < num; i++)
//   {
//     summ += array[i, i];
//     Console.WriteLine(array[i, i]);
//   }

//   return summ;
// }

// Console.Write("Input number of rows in array: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of columns in array: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(m, n);
// Show2DArray(myArray);

// Console.WriteLine(SummOfElements(myArray));


int SummOfElements(int[,] array)
{
  int num = Math.Min(array.GetLength(0), array.GetLength(1));

  int summ = 0;

  // for (int i = 0; i < num; i++)
  // {
  //   summ += array[i, i];
  //   Console.WriteLine(array[i, i]);
  // }
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (i == j)
      {
        summ += array[i, j];
      }
    }
  }
  return summ;
}

Console.Write("Input number of rows in array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns in array: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DRandomArray(m, n);
Show2DArray(myArray);

Console.WriteLine(SummOfElements(myArray));