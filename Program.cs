
// Задача 3: Вывести первые N строк треугольника Паскаля. Сделать 
// вывод в виде равнобедренного треугольника

// 1. создать массив

Console.WriteLine("Введите длину массива: ");
int[,] = create array Input[];
int n = Input();

// 2. ввод с клавиатуры Input

int Input(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


// 3. заполение массива
void FillAsPaskal(int[,]matrix, int N)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
           matrix[i,j]=Paskal(i,j);
        }
    }
}

int Paskal(int i, int j)
{
     if ( i == 0 || j == i) return 1;
     return Paskal(i-1, k-1) + Paskal(i-1, j);
}

// 4. вывод 


C(long n, long k)
{
    if (k == 0 || n == k)
        return 1;
    return C(n - 1, k - 1) + C(n - 1, k);
}