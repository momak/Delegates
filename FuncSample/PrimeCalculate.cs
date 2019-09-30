namespace FuncSample
{
   class PrimeCalculate
    {
        public static bool CheckPrimeNumber(int x)
        {
            bool isPrime = false;
            int i;
            for (i = 2; i <= x - 1; i++)
            {
                if (x % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (i == x)
            {
                isPrime = true;
            }
            return isPrime;
        }

       public static bool CheckPrimeWhile(int x)
        {
            int i = 2;
            while (i < x)
            {
                if (x % i == 0)
                {
                    return false;
                }
                i++;
            }
            return true;
        }
    }
}