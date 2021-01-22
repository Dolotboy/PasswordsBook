using System;
using System.Collections.Generic;
using System.Text;

namespace MY_CSHARP_LIBRARY
{
    public class RandomNumber
    {
        public int GenerateRandomNumber(int min, int max)
        {
            int nbrToReturn = 0;
            Random randomNbr = new Random();

            max += 1;
            nbrToReturn = randomNbr.Next(min, max);

            return nbrToReturn;
        }
    }
}
