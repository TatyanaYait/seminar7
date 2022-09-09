int[,] GetArray(int m, int n) {
    int[,] array = new int[m, n];

    for (int i = 0; i < m; ++i)     {
        for (int j = 0; j < n; ++j)         {
            array[i, j] = new Random().Next(-9, 10);
        }
    }
    return array;
}

void PrintArray(int[,] arr) {
    for (int i = 0; i < arr.GetLength(0); ++i)     {
        for (int j = 0; j < arr.GetLength(1); ++j)         {
            Console.Write("  " + arr[i, j]);
        }
        Console.WriteLine();
    }
}

Console.Write("Введите число строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int n = int.Parse(Console.ReadLine());
int[,] array = GetArray(m, n);
PrintArray(array);

Console.Write("Введите число, которое будем искать в массиве: ");
int numb = int.Parse(Console.ReadLine());
int mayak = 0;
for (int i = 0; i < array.GetLength(0); ++i) {
    for (int j = 0; j < array.GetLength(1); ++j)     {
        if (array[i, j] == numb)         {
            mayak += 1;
            break;
        }
        
    }
}
if (mayak > 0)         {
            Console.WriteLine("Такое число в массиве есть!");
        }
        else         {
            Console.WriteLine("Такого числа в массиве нет!");
        }