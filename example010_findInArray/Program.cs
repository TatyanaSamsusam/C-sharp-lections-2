// покажи, под каким индексом стоит число, равное find, в одномерном массиве array с n элементов

int[] array = {18,21,13,44,85,66,17,89,49,18};
int n = array.Length;
int find = 18;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index = index + 1; //index ++
}
