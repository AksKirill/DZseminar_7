// // Задача 47 Задайте массив MxN со случайными чмслами

// Console.Write("Введите, количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите, количество столбцов массива: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// double[,] Arr = new double[rows, colums];

// for (int i = 0; i < rows; i++)
// {
//     Console.Write("Строка массива {0}: ", i+1);
//     for (int j = 0; j < colums; j++)
//     {
//         Arr[i, j] = new Random().Next(-500, 500);
//         Console.Write(" {0}", Arr[i,j]);
//     }
//      Console.WriteLine();
// }

////////////////////////////////////////////////////////////////////////
//  // Задача 50 Задается адрес в массиве, требуется вывести число из массива или указание, что его нет
// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// double[,] Arr = new double[rows, colums];

// for (int i = 0; i < rows; i++)
// {
//     Console.Write("Строка массива {0}: ", i+1);
//     for (int j = 0; j < colums; j++)
//     {
//         Arr[i, j] = new Random().Next(-500, 500);
//         Console.Write(" {0}", Arr[i,j]);
//     }
//      Console.WriteLine();
// }

// Console.Write("Введите, номер строки искомого элемента массива: ");
// int indexX = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите, номер столбца искомого элемента массива: ");
// int indexY = Convert.ToInt32(Console.ReadLine());
// if (indexX<=Arr.GetLength(0)&&indexY<=Arr.GetLength(1)) {
//     Console.WriteLine("Искомый элемент массива: " +Arr[indexX-1,indexY-1]); 
//     }
//     else {
//     Console.WriteLine("Элемента [" +indexX +", " +indexY +"] в массиве нет!");
//     }

///////////////////////////////////////////////////////////////////////
//  // Задача 52 Посчитать среднеарифметическое каждого столбца задаваемого массива
// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// double[,] Arr = new double[rows, colums];

// for (int i = 0; i < rows; i++)
// {
//     Console.Write("Строка массива {0}: ", i+1);
//     for (int j = 0; j < colums; j++)
//     {
//         Arr[i, j] = new Random().Next(-500, 500);
//         Console.Write(" {0}", Arr[i,j]);
//     }
//      Console.WriteLine();
// }

// Console.Write("Ср. значение столбцов: ");
// for (int j = 0; j < colums; j++)
// {
//     double Sum=0;
//     for (int i = 0; i < rows; i++)
//     {
//     Sum = Sum+Arr[i,j];
//     }
//     Console.Write(" {0}", Sum/Arr.GetLength(0));
// }
/////////////////////////////////////////////////////////////////////
