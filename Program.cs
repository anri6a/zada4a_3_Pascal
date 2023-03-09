
// Задача 3: Вывести первые N строк треугольника Паскаля. Сделать 
// вывод в виде равнобедренного треугольника
Console.WriteLine("enter number of rows: ");
int n = Convert.ToInt32(Console.ReadLine());
float Factorial(int n)
{
    float factorial = 1;
    for (int i = 1; i <= n; i++)
        factorial *= i;
    return factorial;
}
for (int i = 0; i <= n; i++)
{
    for (int j = 0; j <= n-i; j++)
    {
        Console.Write(" ");
    }
    for (int j = 0; j <= i; j++)
    {
        Console.Write(" ");
        Console.Write(Factorial(i)/(Factorial(j)*Factorial(i-j)));
    }
    Console.WriteLine();
    Console.WriteLine();
}


//   Console.WriteLine( "Введите высоту треугольника:\n");
//   int n = Convert.ToInt32(Console.ReadLine());

//   for (int row = 1; row <= n; ++row) 
//   {
//       int Cnk = 1; 

//       for (int column = 1; column < (n - row + 1); ++column) 
//       {
//         Console.Write(" ");
//       }

//       for (int k = 1; k <= row; ++k) 
//       {
//         Console.Write(Cnk + " ");
//         Cnk = Cnk *  (row - k) / k;
//       }

//       Console.Write("\n");
//     }
//   return 0;
