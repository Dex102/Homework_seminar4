int SumNumbers (int N) 
{
    int sum = 0;
    while (N > 0) 
    {
        sum += N % 10;
        N = N / 10;
    }
    
    return sum;
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sum of numbers is " + SumNumbers(number));


