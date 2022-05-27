/* f(1) = 1
   f(2) = 1
   f(3) = f(3-1) + (3-2)    3
   f(4) = f(4-1) + (4-2)    5*/

int FindFibonacci (int n)
{
    if (n ==1 || n == 2) return 1;
    else return FindFibonacci(n-1) + FindFibonacci(n-2);
}

for (int i = 1; i < 10; i++)
{
    Console.WriteLine($"f({i}) = {FindFibonacci(i)}");
}