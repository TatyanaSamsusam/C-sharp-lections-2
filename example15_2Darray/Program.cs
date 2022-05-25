string[,] table = new string[2,5]; // 2 строки, 5 столбцов
table[1,2] = "слово";              // на пересечении строки 1 и столбца 2 напишем "слово"


// индексы считаются с нуля
// table[0,0]  table[0,1]  table[0,2]  table[0,3]  table[0,4] 
// table[1,0]  table[1,1]  слово       table[1,3]  table[1,4] 

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.Write($"+{table[rows, columns]}+ ");
    }
    Console.WriteLine();
}

void FillArray (int[,] matri)
{
    for (int i = 0; i < matri.GetLength(0); i++)
    {
        for (int j = 0; j < matri.GetLength(1); j++)
        {
            matri[i,j] = new Random().Next(1,11);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)                 // matrix.GetLength(0) - обращается к размеру массива, указанному строкой выше
        {
            for (int j = 0; j < matr.GetLength(1); j++)
                {
                    Console.Write($"{matr[i,j]} ");
                }
            Console.WriteLine();
        }
}
int[,] matrix = new int[3,4];
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);