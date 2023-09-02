Console.Write("Введите число строк: ");
int rowsNumber = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов: ");
int columnsNumber = int.Parse(Console.ReadLine()!);
int[,] array = GetSnailArray(rowsNumber, columnsNumber);
PrintArray(array);
Console.WriteLine();

int[,] GetSnailArray(int rows, int columns){
    int[,] array = new int[rows, columns]; 
    int value = 2;
    int maxValue = rows * columns;
    int turnPointCounter = 0;
    int turnPointX = columns-1;
    int turnPointY = rows-1;
    int currentXIndex = 0;
    int currentYIndex = 0;

    array[currentYIndex, currentXIndex] = 1;
    while(value != maxValue+1){
        while(currentXIndex < turnPointX - turnPointCounter && value != maxValue+1){
            array[currentYIndex, currentXIndex+1] = value++;            
            currentXIndex++;
        }        
        while(currentYIndex < turnPointY - turnPointCounter && value != maxValue+1){
            array[currentYIndex+1, currentXIndex] = value++;            
            currentYIndex++;
        }
        while(currentXIndex > turnPointX - turnPointX + turnPointCounter && value != maxValue+1){
            array[currentYIndex, currentXIndex-1] = value++;            
            currentXIndex--;
        }
        turnPointCounter++;
        while(currentYIndex > turnPointY - turnPointY + turnPointCounter && value != maxValue+1){
            array[currentYIndex-1, currentXIndex] = value++;            
            currentYIndex--;
        }
    }
    return array;
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]:d2} ");
        }
        Console.WriteLine();
    }
}