/*
 Задайте двумерный массив из целых чисел. 
 Напишите программу, которая удалит строку и столбец, 
 на пересечении которых расположен наименьший элемент 
 массива.
*/


// Задайте двумерный массив из целых чисел. 
//Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива

//Methods//////////////////////////////////
int[,] FillIntMatrix(int m, int n){
    int[,] matrix = new int[m,n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            matrix[i,j] =  new Random().Next(-100,100);
        }
    }
    return matrix;
}

void Print2dIntMatrix(int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            Console.Write(string.Format("{0,8}", matrix[i,j]));
        }
        Console.WriteLine();
    }
}

int[,] ZeroRawColWithMinElement(int[,] matrix){
    int row = 0;
    int col = 0;
    int minEl = int.MaxValue;

    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            if (matrix[i,j] < minEl){
                row = i;
                col = j;
                minEl = matrix[i,j];
            }
        }
        
    }   

    for (int i = 0; i < matrix.GetLength(0); i++){
        matrix[i,col] = 0;
    }

    for (int i = 0; i < matrix.GetLength(1); i++){
        matrix[row,i] = 0;
    } 

    Console.WriteLine($"col={col}, row = {row}"); 
    Console.WriteLine(); 
    return matrix;

}
//////////////////////////////////////
int[,] testArray = FillIntMatrix(4, 4);
Print2dIntMatrix(testArray);
Console.WriteLine();
int[,] newArray = ZeroRawColWithMinElement(testArray);
Print2dIntMatrix(newArray);