void FillArray (int [,] array)
{
for (int j = 0; j < array.GetLength(0); j++) 
    {
    for (int i = 0; i < array.GetLength(1); i++)
        {
        array[j, i] = new Random().Next(1, 11);
        Console.Write($"{array[j, i]} ");
        }
    Console.WriteLine();
    }
}

void ArraySorting (int [,] array)
{
    
    for (int line = 0; line < array.GetLength(0); line ++)
    {
        
        for (int i = 0; i < array.GetLength(1); i++)
        {  
            
            for (int j = 0; j < array.GetLength(1) - 1; j ++)
            {
                if (array[line, j + 1] > array[line, j])
                {
                    int temp = array[line, j];
                array[line, j] = array[line, j + 1];
                array[line, j + 1] = temp; 
                }
            }
            
        }
    }
}

void RealeseArray (int [,] array)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        for (int i = 0; i < array.GetLength(1); i ++)
        {
            Console.Write($"{array[j, i]} ");
        }
    Console.WriteLine();
    }
}

int MinRealese (int [,] array, int [] arrayHelp)
{
    int min = 0;
    for (int line = 0; line < array.GetLength(0); line ++)
    {
        int sum = 0;
        for (int i = 0; i < array.GetLength(1); i ++)
        {
            sum = sum + array[line, i];
        }
        
            arrayHelp[line] = sum; 
    }

    for (int i = 0; i < arrayHelp.Length; i++)
    {
        
        if (arrayHelp[i] < arrayHelp[min])
        {
            min = i;
        }
    }
    return min + 1;
}

void LinearProduct (int [,] firstArray, int[,] secondArray, int [] size)
{
    int [,] resultArray = new int[size[0], size[1]];
    for (int row = 0; row < firstArray.GetLength(0); row ++)
    {
        for (int i = 0; i < firstArray.GetLength(1); i ++)
        {
            resultArray[row, i] =  firstArray[row, i] * secondArray[row, i];
            Console.Write($"{resultArray[row, i]} ");
        }
        Console.WriteLine();
    }
    
}

Console.Write("Выберите задачу: 54, 56, 58, 60, 62: ");
int choice = Convert.ToInt32(Console.ReadLine());


if (choice == 54)   
{
    Console.Write("Введите размер матрицы через пробел: ");
    int [] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    int [,] array = new int[size[0], size[1]];
    FillArray(array);
    Console.WriteLine();
    ArraySorting(array);
    RealeseArray(array);
}

else if (choice == 56){
    Console.Write("Введите размер матрицы через пробел: ");
    int [] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    int [,] array = new int[size[0], size[1]];
    FillArray(array);
int [] arrayHelp = new int[array.GetLength(0)];
Console.Write($"Наименьшая сумма у {MinRealese(array, arrayHelp)} строки");
}

else if (choice == 58)
{
    Console.Write("Введите размер матрицы через пробел: ");
    int [] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    int [,] firstArray = new int[size[0], size[1]];
    FillArray(firstArray);
    Console.WriteLine();
    int [,] secondArray = new int[size[0], size[1]];
    FillArray(secondArray);
    Console.WriteLine();
    LinearProduct(firstArray, secondArray, size);

}


