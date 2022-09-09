double [,] FillArray(int m,int n)
{
  double [,] arr = new double[m,n]; 
    for( int i = 0; i<m; ++i)   {
    for(int j =0; j<n; ++j)      {
        arr[i,j] = new Random().Next(-9,9) + new Random().NextDouble(); 
    }
  }
  return arr;
}


void PrintArray(double[,] array) 
{
  for (int i = 0; i < array.GetLength(0); ++i) {
    for (int j = 0; j < array.GetLength(1); ++j) {
      Console.Write("  " + array[i, j]);
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
//Console.WriteLine(string.Join("  " + FillArray));