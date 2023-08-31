int[,] array = GetArray(4, 4, 1, 9);
PrintArray(array);
Console.WriteLine();
FindMinSumInRows(array);


int[,] GetArray(int rows, int columns, int minValue, int maxValue){
    int[,] result = new int[rows,columns];
    for(int i = 0; i < rows; i++){
        for(int j = 0; j < columns; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void FindMinSumInRows (int[,] array){
    int rowNumber = 1;
    int minSum = 0;
    int tempSum = 0;
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            tempSum += array[i,j];
        }
        if (i == 0) minSum = tempSum;
        else if (tempSum < minSum) {
            minSum = tempSum;
            tempSum = 0;
            rowNumber = i + 1;
        }
        else tempSum = 0;
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {rowNumber}\n");
}