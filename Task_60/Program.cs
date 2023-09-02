int[,,] array = GetArray(2, 2, 2, 10, 99);
PrintArray(array);
Console.WriteLine();

int[,,] GetArray(int rows, int columns, int depth, int minValue, int maxValue)
{
    int[,,] result = new int[rows, columns, depth];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                while (true)
                {
                    int randomValue = new Random().Next(minValue, maxValue + 1);
                    if (!FindValue(result, randomValue))
                    {
                        result[i, j, k] = randomValue;
                        break;
                    }
                }
            }
        }
    }
    return result;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}

bool FindValue(int[,,] array, int value)
{
    bool checkValue = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == value)
                {
                    checkValue = true;
                    break;
                }
            }
        }
    }
    return checkValue;
}