/*
Задача 39: Напишите программу, которая перевернёт одномерный массив
 (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]

1. получения числа (размерность массив)
2. инициализация массив
3. печать массива
4. поэлементное копирование массива

int GetNumber(string message)
{
    int result;
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

int[] InitArray(int dimension)
{
    Random rnd = new Random();
    int[] array = new int[dimension];

    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(1,10);
    }

    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] ReverseArray(int [] array)
{
    int [] result = new int[array.Length];
    int count = 0;

    for (int i = array.Length - 1; i >= 0; i--)
    {
        result[count] = array[i];
        count++;
    }
    return result;
}

int dimension = GetNumber("Введите размерность массива");
int[] array = InitArray(dimension);
PrintArray(array);

int[]result = ReverseArray(array);
PrintArray(result);

Array.Reverse(result);

*/
/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if (a < b + c && b < a + c && c < a + b)
{
    Console.WriteLine("Треугольник существует.");
}
else
{
    Console.WriteLine("Треугольник не существует.");
}*/

/*Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10*/
/*
Console.WriteLine("Введите число.");
int num = Convert.ToInt32(Console.ReadLine());
string binar= Convert.ToString(num,2);
 
Console.WriteLine(binar);
*/
/*
string GetBinaryFromDecimal(int decimalNumber)
{
    // 11 % 2 = 5.5 = 1
    // 5 % 2 = 2.5 = 1
    // 2 % 2 = 1 = 0
    // 1 % 2 = 0.5 = 1
    int number = decimalNumber;
    int ostatok = 0;
    string result = String.Empty;

    while (number >= 1)
    {
        ostatok = number % 2;
        number /= 2;
        if (ostatok != 0)
        {
            result += "1";
        }
        else
        {
            result += "0";
        }
    }

    return new string (result.Reverse().ToArray());
}

Console.WriteLine(GetBinaryFromDecimal(11));
Console.WriteLine(GetBinaryFromDecimal(158));
*/

/*Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8*/
/*
int N = 100;
int x1 = 0;
int x2 = 1;
int res = 0;
string str = "0 1 ";

for (int i = 2; i <= N; i++)
{
    res = x2 + x1;
    x1 = x2;
    x2 = res;
    str += res.ToString() + " ";
}

Console.WriteLine(str);*/

/*Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.*/

    int[] array1 = { 1, 2, 3, 4, 5};
    int[] array2 = new int[array1.Length];
 
    for (int i = 0; i < array1.Length; i++)
        array2[i] = array1[i];
    Console.WriteLine(string.Join(" ",array2));