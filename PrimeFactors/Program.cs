using PrimeFactorsLib;
using static System.Console;

Write("Enter a number between 1 and 1000: ");

if (int.TryParse(ReadLine(), out int number) && number >= 1 && number <= 1000)
{
    WriteLine($"Prime factors of {number} are: {Primes.PrimeFactors(number)}");
}
else
{
    WriteLine("The number is incorrect!");
}