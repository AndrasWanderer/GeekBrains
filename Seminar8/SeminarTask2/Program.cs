// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя

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

int[,] TranspondSquareArray(int[,] matrix){
    if (matrix.GetLength(1) != matrix.GetLength(0)){
        Console.WriteLine("Incorrect data");
        Environment.Exit(0);
    }
    int[,] tmpMatrix = new int[matrix.GetLength(1),matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            tmpMatrix[j,i] = matrix[i,j];
        }        
    } 
    return tmpMatrix;   
}
//////////////////////////////////////
int[,] testArray = FillIntMatrix(4, 4);
Print2dIntMatrix(testArray);
Console.WriteLine();
int[,] newArray = TranspondSquareArray(testArray);
Print2dIntMatrix(newArray);

/*
// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива

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

int[,] ReverseArray(int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            int temp = matrix[j,i];
            matrix[j,i] = matrix[i,j];
            //matrix[i,j] = temp;
        }
    }
    return matrix;
}


int[,] testArray = FillIntMatrix(5, 5);
Print2dIntMatrix(testArray);
Console.WriteLine();
ReverseArray(testArray);
Console.WriteLine();
Print2dIntMatrix(testArray);
*/