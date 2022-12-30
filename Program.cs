// home work 
// Задайте двумерный массив размером m×n, 
//  заполненный случайными вещественными числами.

//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9


/*
int m = 3, n = 4;
{
    double[,] array = new double[m, n];
    Random rnm = new Random();
    for(int i = 0; i<m; i++)
    {
        for(int j = 0; j<n; j++)
        {
            array[i, j] = (double)rnm.Next(-100, 100)/10;
            Console.Write(array[i, j]+" ");
        }
    Console.WriteLine();
    }
    
}
*/

// zadacha 2 Напишите программу, которая на вход принимает позиции элемента
 // в двумерном массиве,и возвращает значение этого элемента или же указание, 
 // что такого элемента нет.

// Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//1 7 -> числа с такими индексами в массиве не


/*
int m = 3;
int n = 3;
int[,] array = new int [m, n];
Console.WriteLine("input a value:");
int number = Convert.ToInt32(Console.ReadLine());
FillArray(array);
FindelementArray(array, number);

void FillArray(int [,] arrayToFill)
{
    for(int i=0; i < arrayToFill.GetLength(0); i++)
    {
        for(int j=0; j<arrayToFill.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array [i, j] + " ");

        }
        Console.WriteLine();
    }
}

void FindelementArray (int [,] findelement, int usernumber)
{
bool finde = false;

    for(int i=0; i < findelement.GetLength(0); i++)
    {
        for(int j=0; j < findelement.GetLength(1); j++)
        {
            if(findelement[i,j] == usernumber)
            Console.WriteLine("Ваше значение находится по координатам" + i + " " + j);
            finde = true;
        }
    }
    if(!finde) 
    Console.WriteLine("Такого значения в массиве нет");
}

*/


//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[n, m];
FillArrayRandomNumbers(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray(numbers);



void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}


//   20.12.2022 г.
//   задача в уроке 
/*
int[,] NewArray2d(int rows, int colums)
{
    int[,] array = new int[rows, colums];
    for(int i = 0; i<rows; i++)
    {
        for(int j = 0; j<colums; j++)
        {
            array[i, j] = i+j;
        }
    }
    return array;
}

void Show2dArray(int[,]array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array [i, j]+" ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input colums: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = NewArray2d(m,n);
Show2dArray(myArray);
*/
