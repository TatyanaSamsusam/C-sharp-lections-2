﻿int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 28;
int c3 = 300;

int findMax(int arg1, int arg2, int arg3)    //ввела функцию findMax c тремя аргументами
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int max1 = findMax(a1, b1, c1);
int max2 = findMax(a2, b2, c2);
int max3 = findMax(a3, b3, c3);
int finalMax = findMax(max1, max2, max3);

Console.WriteLine(finalMax);