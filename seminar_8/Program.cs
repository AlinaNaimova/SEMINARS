/*
Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int row = GetNumber("Введите количество строк:");
int column = GetNumber("Введите количество столбцов:");
int[,] numbers = new int[row, column];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int[] numbers1 = new int[row];
int[] numbers2 = new int[row];
for (int i = 0; i < ; i++)
    {
        intTemp1[i] = numbers[0,i];
        intTemp2[i] = numbers[3,i];
    }
int[] intSwap = new int[4];
Array.Copy(numbers1,intSwap,4);
Array.Copy(numbers2,numbers1,4);
Array.Copy(intSwap,numbers1,4);

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

void FillArrayRandomNumbers(int[,] numbers)
{
    Random rnd = new Random();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = rnd.Next(1, 10);
        }
    }
}

void PrintArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(numbers[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

*/
/*void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(String.Format("{0,2:0.#}", arr[i, j]));
        Console.WriteLine();
    }
}

int[,] arr =
{
    { 1, 4, 7, 2 },
    { 5, 9, 2, 3 },
    { 8, 4, 2, 4 },
    { 5, 2, 6, 7 }
};

int[] line0 = new int[arr.GetLength(1)];
int[] line1 = new int[arr.GetLength(1)];

for (int i = 0; i < line0.Length; i++)
    line0[i] = arr[0, i];

for (int i = 0; i < line0.Length; i++)
    line1[i] = arr[arr.GetLength(0)-1, i];

PrintArray(arr);

for (int i = 0; i < line0.Length; i++)
    arr[0, i] = line1[i];
for (int i = 0; i < line0.Length; i++)
    arr[arr.GetLength(0) - 1, i] = line0[i];

Console.WriteLine();
Console.WriteLine();
PrintArray(arr);
*/
