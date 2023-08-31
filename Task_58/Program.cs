int[,] firstArray = GetArray(2, 2, 2, 4);
int[,] secondArray = GetArray(2, 2, 2, 4);
PrintArray(firstArray);
Console.WriteLine();
PrintArray(secondArray);
Console.WriteLine();
PrintArray(MatrixProduct(firstArray, secondArray));

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

int[,] MatrixProduct(int[,] firstArray, int[,] secondArray){
    int[,] result = new int [secondArray.GetLength(0), secondArray.GetLength(1)];
    result[0,0] = firstArray[0,0] * secondArray[0,0] + firstArray[0,1] * secondArray[1,0];
    result[0,1] = firstArray[0,0] * secondArray[0,1] + firstArray[0,1] * secondArray[1,1];
    result[1,0] = firstArray[1,0] * secondArray[0,0] + firstArray[1,1] * secondArray[1,0];
    result[1,1] = firstArray[1,0] * secondArray[0,1] + firstArray[1,1] * secondArray[1,1];
    return result;
}