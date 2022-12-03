using System;

namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            int abs = Math.Abs(candidate);
            if (abs <= 1)
            {
                return false;
            }
            int limit = abs/2;
            for(int i = 2 ; i<=limit ; i++)
            {
                if(abs%i==0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
