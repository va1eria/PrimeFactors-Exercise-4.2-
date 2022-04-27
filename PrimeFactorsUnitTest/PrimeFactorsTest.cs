using PrimeFactorsLib;
using Xunit;

namespace PrimeFactorsUnitTest
{
    public class PrimeFactorsTest
    {
        [Fact]
        public void Test1()
        {
            int a = 4;
            string expected = "2 x 2";
            Primes primes = new();
            string actual = primes.PrimeFactors(a);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            int a = 225;
            string expected = "3 x 3 x 5 x 5";
            Primes primes = new();
            string actual = primes.PrimeFactors(a);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            int a = 824;
            string expected = "2 x 2 x 2 x 103";
            Primes primes = new();
            string actual = primes.PrimeFactors(a);
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void Test()
        {
            int a = 103;
            string expected = "103";
            Primes primes = new();
            string actual = primes.PrimeFactors(a);
            Assert.Equal(expected, actual);
        }
    }
}