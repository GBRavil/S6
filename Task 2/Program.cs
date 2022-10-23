//Задать двумерный массив следующим правилом: Aₘₙ = m+n
Console.WriteLine($"Задайте количество строк (м)");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Задайте количество столбцов (n)");
int n = Convert.ToInt32(Console.ReadLine());
int [,] nums = new int [m, n];
FillArr(nums);
PrintArr(nums);
SumNums(nums);

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

        }
    }
}

void SumNums(int [,] num) {
    int sum = 0;
    for(int i =0; i<num.GetLength(0); i++) {
        for(int j =0; j<num.GetLength(1); j++) {
            if(i==j) {
                sum += num[i,j];
            }
            
        }
    }
    Console.WriteLine();
    Console.WriteLine(sum);
}