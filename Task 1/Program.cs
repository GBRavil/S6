//Показать двумерный массив размером m×n заполненный вещественными числами
Console.WriteLine($"Задайте количество строк (м)");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Задайте количество столбцов (n)");
int n = Convert.ToInt32(Console.ReadLine());
int [,] nums = new int [m, n];
for(int i =0; i<nums.GetLength(0); i++) {
    for(int j =0; j<nums.GetLength(1); j++) {
        nums [i, j] = new Random().Next(1,10);
        Console.Write($"{nums [i, j]} ");
    }
    Console.WriteLine();

}