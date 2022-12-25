/*Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1
*/
/*
int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}

int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1, 10);
        }
    } 
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}

int rows = GetNumber("Введите количество строк:");
int columns = GetNumber("Введите количество столбцов:");
int[,] matrix = InitMatrix(rows, columns);
PrintMatrix(matrix);
*/
/*
Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 58
*/
/*
int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}
int[,] InitMatrix (int rows, int columns)
{
    int[,] arrMatrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for ( int j = 0; j < columns; j++)
        arrMatrix[i,j] = i + j;
    }
    return arrMatrix; 
}

void PrintInitMatrix(int[,] arrMatrix)
{
    for (int i = 0; i < arrMatrix.GetLength(0); i++)
    {
        for ( int j = 0; j < arrMatrix.GetLength(1); j++)
            Console.Write($"{arrMatrix[i,j]} ");
        Console.WriteLine();
    } 
    Console.WriteLine();
}

int rows = GetNumber("Введите количество строк:");
int columns = GetNumber("Введите количество столбцов:");
int[,] arrMatrix = InitMatrix(rows, columns);
PrintInitMatrix(arrMatrix);
*/

/*Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив
 выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Новый массив будет выглядеть 
вот так:
1 4 7 2
5 81 2 9
8 4 2 4
*/

/*
int[,] arr = {
    { 1, 4, 7, 2 },
    { 5, 9, 2, 3 },
    { 8, 4, 2, 4 }
};



var dim0 = arr.GetLength(0);
var dim1 = arr.GetLength(1);

for (int i = 0; i < dim0; i++)
    for (int j = 0; j < dim1; j++)
        if (((i+1) % 2) == 0 && ((j+1) % 2) == 0)
            arr[i,j] *= arr[i, j];


Console.WriteLine("Распечатка массива: ");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
        Console.Write(String.Format("{0,4:0.#}", arr[i, j]));
    Console.WriteLine();
}
*/

/*
Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/
/*
//сумма главной диагонали
int GetSumm(int[,] matrix)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
            count+=matrix[i, i];
    }
    return count;
}

//получить размерность массива с консоли
int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        System.Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            System.Console.WriteLine("Vveli nevernye danniye. Vvedite korrektnoe chislo");
        }
    }
    return result;
}

int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

//сумма главной диагонали
int GetSumm(int[,] matrix)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
            count+=matrix[i, i];
    }
    return count;
}


//распечатать массив на консоль
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
int rows = GetNumber("Введите кол-во строк: ");
int columns = GetNumber("Введите кол-во столбцов: ");
if(rows == columns)
{
    int[,] matrix = InitMatrix(rows, columns);
    PrintMatrix(matrix);
    int diagonalSumm = GetSumm(matrix);
    System.Console.WriteLine($"Сумма элементов, находящихся на главной диагонали с индексами (0,0); (1;1) и т.д. = {diagonalSumm}");
}
else
    System.Console.WriteLine("Матрица не квадратная");
*/

int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число.");
        }
    }

    return result;
}

int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

int GetSumm(int[,] matrix)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
            count+=matrix[i, i];
    }
    return count;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int rows = GetNumber("Введите кол-во строк: ");
int columns = GetNumber("Введите кол-во столбцов: ");
if(rows == columns)
{
    int[,] matrix = InitMatrix(rows, columns);
    PrintMatrix(matrix);
    int diagonalSumm = GetSumm(matrix);
    System.Console.WriteLine($"Сумма элементов, находящихся на главной диагонали с индексами (0,0); (1;1) и т.д. = {diagonalSumm}");
}
else
    System.Console.WriteLine("Матрица не квадратная");