// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.

int[,] CreateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(0, 10);
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
            Console.Write("{0}	", array[i, j]);
        }
        Console.WriteLine(" ");
    }
}

void PrintOneDimArray(int[] array);
{
    for (int j = 0; j < length; j++)
    {
        Console.Write(array[j]);
    }
}

Console.Write("Enter the number or rows...");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number or columns..");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine(" ");
int[,] array = new int[rows, columns];
array = CreateArray(rows, columns);
Console.WriteLine(" ");
PrintArray(array);
Console.WriteLine(" ");


int[] OneDimensionArray (int[,] array)
{
    int element = 0;
    int [] OneDimensionArray = new int [(array.GetLength(0))*(array.GetLength(1))];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            element = array[i,j];
            OneDimensionArray = element;
        }
    }
    return OneDimensionArray;
}

// void DigitCounter(int[,] array)
// {
//     int counter = 0;
//     for (int digit = 0; digit < (array.GetLength(0))*(array.GetLength(1)); digit++)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 if (array[i, j] == digit) counter++;
//             }
//         }
//         if (counter == 2 || counter == 3 || counter == 4 )
//         {
//             Console.WriteLine($"Цифра {digit} встретилась {counter} раза");
//         }
//         else
//         {
//             Console.WriteLine($"Цифра {digit} встретилась {counter} раз");
//         }
//         counter = 0;
//     }
// }

// DigitCounter(array);

PrintOneDimArray(OneDimensionArray(array));