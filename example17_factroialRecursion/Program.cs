double FindFactorial (double n)
{
    if (n ==1) return 1;
    else return n * FindFactorial(n-1);
}

for (double i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {FindFactorial(i)}");
}
