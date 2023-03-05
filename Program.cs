
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


// 4. вывод 


C(long n, long k)
{
    if (k == 0 || n == k)
        return 1;
    return C(n - 1, k - 1) + C(n - 1, k);
}