/*
Задача 57: Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
1, 2, 3 
4, 6, 1 
2, 1, 6

1 встречается 3 раза 
2 встречается 2 раз 
3 встречается 1 раз 
4 встречается 1 раз 
6 встречается 2 раза
*/
int m = GetNumber("Введите количество строк:");
int n = GetNumber("Введите количество столбцов:");
int[,] matrix = new int[m, n];
FillArrayRandomNumbers(matrix);
PrintArray(matrix);
CalculateNumbers(matrix);

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
void FillArrayRandomNumbers(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

void CalculateNumbers (int[,] matrix)
{
    int m = matrix.GetLength(0);
    int n = matrix.GetLength(1);
    int numberOfElements = m * n;
    int number = 0;
    int count = 0;
    int total = 0;

    while (total != numberOfElements)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if(matrix[i, j] == number)
                {
                    count++;
                }
            }
        }
        if (count > 0)
    System.Console.WriteLine($"Число {number} встречается {count} раз;");
    total+= count;
    count = 0;
    number++;
    }
}