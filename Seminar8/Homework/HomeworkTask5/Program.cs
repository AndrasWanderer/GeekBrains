/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] array = new int[4, 4];
        int n = 4;
        int value = 1;
        int row = 0, col = -1;

        while (true)
        {
            for (int i = 0; i < n; i++)
            {
                col++;
                array[row, col] = value++;
            }
            n--;
            if (n == 0)
                break;

            for (int i = 0; i < n; i++) 
            {
                row++;
                array[row, col] = value++;
            }

            for (int i = 0; i < n; i++) 
            {
                col--;
                array[row, col] = value++;
            }
            n--;
            if (n == 0)
                break;

            for (int i = 0; i < n; i++)
            {
                row--;
                array[row, col] = value++;
            }
        }

        
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(array[i, j].ToString().PadLeft(2, '0') + " ");
            }
            Console.WriteLine();
        }