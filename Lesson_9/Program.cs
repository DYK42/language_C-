
int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
/*
int[,] ChangeRows(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        temp = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = array[0, i];
        array[0, i] = temp;
    }

    return array;
}

int[,] array = GetArray(5, 6, 0, 50);
PrintArray(array);
PrintArray(ChangeRows(array));
*/

int[] GetSingleArray(int[,] array)
{
    int[] result = new int[array.GetLength(0) * array.GetLength(1)];
    int count = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[count] = array[i, j];
            count++;
        }
    }

    return result;
}

void SortArray(int[] array)
{
    int temp = 0;

    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[i] > array[j])
            {
                temp = array[j];
                array[j] = array[i];
                array[i] = temp;
            }
        }
    }
}

void GetCountNumber(int[] array)
{
    int count = 1;

    for (int i = 0; i < array.Length - 1; i++)
    {
        if(array[i] < array[i + 1])
        {
            Console.Write($"{array[i]}: {count}");
            Console.WriteLine();
            count = 1;
        }
        else count++;
    }
    Console.Write($"{array[array.Length - 1]}: {count}");
    Console.WriteLine();
}

int[,] array = GetArray(5, 5, 0, 10);
PrintArray(array);
int[] singleArray = GetSingleArray(array);
Console.Write($"{string.Join(", ", singleArray)}");

SortArray(singleArray);
Console.WriteLine();
Console.Write($"{string.Join(", ", singleArray)}");
Console.WriteLine();
GetCountNumber(singleArray);