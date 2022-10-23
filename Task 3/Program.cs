//В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
Console.WriteLine($"Задайте количество строк (м)");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Задайте количество столбцов (n)");
int n = Convert.ToInt32(Console.ReadLine());
int [,] nums = new int [m, n];
FillArr(nums);
CubeArr(nums);
PrintArr(nums);

void PrintArr(int [,] num) {
    for(int i =0; i<num.GetLength(0); i++) {
        for(int j =0; j<num.GetLength(1); j++) {
            Console.Write($"{num [i, j]} ");
        }
        Console.WriteLine();
    }

}

void FillArr (int [,] num) {
    for(int i =0; i<num.GetLength(0); i++) {
        for(int j =0; j<num.GetLength(1); j++) {
            num [i, j] = new Random().Next(1,10);
            Console.Write($"{num [i, j]} ");

        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void CubeArr (int [,] num) {
    for(int i =0; i<num.GetLength(0); i++) {
        for(int j =0; j<num.GetLength(1); j++) {
            if(i%2==0 && j%2==0) {
                num[i,j]= num[i,j] * num[i,j];
            }

        }
    }
}