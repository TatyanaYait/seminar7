int[,] NewArr(int m, int n, int minV, int maxV) {
    int[,] array = new int[m, n];
     for (int i = 0; i < m; ++i)  {
        for (int j = 0; j < n; ++j) {
            array[i, j] = new Random().Next(minV, maxV + 1);
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

int[,] array = NewArr(m, n, 0, 9);
PrintArray(array);

double Srednyaya = 0;

for (int j = 0; j < n; ++j)
{ double summa = 0;

    for (int i = 0; i < m; ++i)
    {
    summa = summa + array[i, j] ;
    Srednyaya = summa/m;
    }

    //Console.Write("  " + summa);
    Console.Write(" " + Math.Round(Srednyaya,2));    }

/*double [,] FillArray(int m,int n) {
  double [,] arr = new double[m,n]; 
    for( int i = 0; i<m; ++i)   {
    for(int j =0; j<n; ++j)      {
        arr[i,j] = new Random().Next(0,9) + new Random().NextDouble(); 
    }
  }
  return arr;
}
void PrintArray(double[,] array)  {
  for (int i = 0; i < array.GetLength(0); ++i) {
    for (int j = 0; j < array.GetLength(1); ++j) {
      Console.Write("  " + Math.Round(array[i, j],0));
    }
    Console.WriteLine();
  }
}
Console.WriteLine("Введите число строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива: ");
int n = int.Parse(Console.ReadLine());

double [,] arr = FillArray(m,n);
PrintArray(arr);
Console.WriteLine(FillArray);

for (int j = 0; j < n; ++j) { 
double summa = 0;
double Srednyaya = 0;
    for (int i = 0; i < m; ++i)     {
    summa = summa + arr[i, j] ;
    Srednyaya = summa / m;
    }

    //Console.Write("  " + summa);
    Console.Write(" " + Math.Round(Srednyaya,2));    }*/