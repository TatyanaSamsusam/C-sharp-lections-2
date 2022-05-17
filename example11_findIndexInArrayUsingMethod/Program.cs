// покажи, под каким индексом стоит число, равное find, в одномерном массиве array с n элементов. используй методы.

void FillArray(int[] collection)            //collection - это имя массива
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[]col)                   //collection - это имя массива
{
    int size = col.Length;
    int position = 0;
    while(position < size)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int FindIndex(int[] colle, int find)
{
    int size = colle.Length;
    int index = 0;
    int position = -1;
    while(index < size)
    {
        if(colle[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int []array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();                   //распечатала пустую строку
int pos = FindIndex(array, 12);         //вызвала метод поиска индекса
Console.WriteLine(pos);