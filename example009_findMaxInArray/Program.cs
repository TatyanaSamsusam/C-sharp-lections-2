int[] array = {18,21,13,44,85,66,17,89,49};

int findMax(int arg1, int arg2, int arg3)    //ввела функцию findMax c тремя аргументами
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int max = findMax(
    findMax(array[0], array[1], array[2]),
    findMax(array[3], array[4], array[5]),
    findMax(array[6], array[7], array[8])
);
Console.WriteLine(max);
