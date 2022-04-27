namespace PrimeFactorsLib
{
    public class Primes
    {
        public static List<int> primes;
        static List<int> PrimesList()
        {
            primes = new List<int>();
            for (int i = 2; i < 1001; i++)
            {
                primes.Add(i);
            }
            for (int i = 1; i < primes.Count; i++)
            {
                for (int j = i + 1; j < primes.Count; j++)
                {
                    if (primes[j] % i == 0)
                    {
                        primes.Remove(primes[j]);
                    }
                }
            }
            return primes;
        }
        
        public static string PrimeFactors(int number)
        {
            PrimesList();
            string x = "";

            foreach (int div in primes)
            {
                int rem;
                do
                {
                    rem = number % div;
                    if (rem == 0)
                    {
                        number /= div;
                        if (number == 1)
                        {
                            x += $"{div}";
                        }
                        else
                        {
                            x += $"{div} x ";
                        }
                    }
                } while (rem == 0);
            }
            return $"{x}"; 
        }
    }
}