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

void SpiralArray (int [,] array, int [] size)
{
     
    int skipRow = 0; int skipRightIndex = 1; int skipLeftIndex = 0; int temp = 0;
    while (temp != (size[0] * size[1]))
    {
        for (int index = 0 + skipRow; index < array.GetLength(1)- skipLeftIndex; index ++)
            {
                temp ++;
                array[skipRow, index] = temp;   
                
            }
        
           
            skipRow ++;
         
                for (int column = 0 + skipRow; column < array.GetLength(0) - skipLeftIndex; column ++)
            {   
                int index = array.GetLength(1) - skipRightIndex;
                temp ++;
                array[column, index] = temp;    
                
            }
        
            skipRightIndex ++;
            
                    for (int index = array.GetLength(1) - skipRightIndex; index >= skipLeftIndex; index --)
                    {
                        temp ++;
                        array[array.GetLength(0)-skipRow, index] = temp;     
                        
                    }
        
            skipLeftIndex ++;
          
                        for (int column = array.GetLength(0) - skipRightIndex; column >= skipRow; column --)
                        {
                            int index = skipLeftIndex - 1;
                            temp ++;
                            array[column, index] = temp;     
                            
                        }
    }   
}

void RealeseSpiralArray (int [,] array)
{
    for (int row = 0; row < array.GetLength(0); row ++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        if (array[row, i]<10)
        {
        {
            Console.Write($"{array[row, i]}  ");
        }
        
        }
        else 
        {
            Console.Write($"{array[row, i]} ");
        }
        Console.WriteLine();
}
}

void FillMatrix (int [,,] array, int[] size)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int row = 0; row < array.GetLength(0); row ++)
        {
            for (int i = 0; i < array.GetLength(1); i++)
            {
                array[row, i, k] = new Random().Next(1, 100);
            }
        }
    }
}

void RealeseCheckMatrix (int[,,]array, int [] size)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int row = 0; row < array.GetLength(0); row ++)
        {
            for (int i = 0; i < array.GetLength(1); i ++)
            {
                int check = 0;
                while (check != i)
                {
                    if (array[row, i, k] == array[row,(check+1)%size[1], k])
                    {
                        array[row, i, k] = new Random().Next(1, 100);
                        check ++;
                    }
                }
            }
        }
    }

    for (int k = 0; k < array.GetLength(2); k++) 
    {
        for (int row = 0; row < array.GetLength(0); row ++)
        {
            for (int i = 0; i < array.GetLength(1); i++)
            {
                Console.Write($"{array[row, i, k]} [{row}, {i}, {k}] ");
            }
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

else if (choice == 62)
{
    Console.Write("Введите размер матрицы через пробел: ");
    int [] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    int [,] array = new int[size[0], size[1]];
    SpiralArray(array, size);
    Console.WriteLine();
    RealeseSpiralArray(array);
    
}

else if (choice == 60)
{
    Console.Write("Введите размер матрицы через пробел: ");
    int [] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    int [,,] array = new int[size[0], size[1], size[2]];
    FillMatrix(array, size);
    RealeseCheckMatrix(array, size);
}

/* void RealeseSpiralArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");
            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void SpiralArray(int[,] array)
{
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
        {
          j++;
        }   
        else if (i < j && i + j >= array.GetLength(0) - 1)
        {
           i++;
        }         
        else if (i >= j && i + j > array.GetLength(1) - 1)
        {
           j--;
        }           
        else
        {
           i--;
        }     
    }

    RealeseSpiralArray(array);
}
int size = 5;
int[,] array = new int[size, size];
SpiralArray(array);
*/