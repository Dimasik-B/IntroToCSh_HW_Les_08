int[,] array = GetArray(4, 4, 1, 9);
PrintArray(array);
Console.WriteLine();
SortRowsInArray(array);
PrintArray(array);


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

void SortRowsInArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            for(int k = 0; k < array.GetLength(1) - 1; k++){
                if (array[i,k] < array[i,k + 1]) { (array[i,k], array[i,k + 1]) = (array[i,k + 1], array[i,k]); }
            }
        }
    }
}