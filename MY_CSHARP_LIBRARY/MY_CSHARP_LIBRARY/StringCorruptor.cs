using System;
using System.Collections.Generic;
using System.Text;

namespace MY_CSHARP_LIBRARY
{
    public class StringCorruptor
    {
        public string CorruptString(string originalString)
        {
            RandomNumber randomNumber = new RandomNumber();
            int numLetter = 0;
            string corruptedString = "";

            for (int i = 0; i < originalString.Length; i++)
            {
                numLetter = randomNumber.GenerateRandomNumber(64, 126);

                if (i % 2 != 0) // Nombre impair, mais == c'est pair
                {
                    corruptedString += originalString[i] + Char.ConvertFromUtf32(numLetter);
                    //string hey = encryptedString.Insert(i, Char.ConvertFromUtf32(numLetter));
                }
                else
                {
                    corruptedString += originalString[i] + Char.ConvertFromUtf32(numLetter);
                    numLetter = randomNumber.GenerateRandomNumber(64, 126);
                    corruptedString += Char.ConvertFromUtf32(numLetter);
                }
            }
            return corruptedString;
        }

        public string UnCorruptString(string corruptedString)
        {
            string unCorruptedString = "";
            int posToChoose = 0;

            int originalLenght = corruptedString.Length * 100 / 250; // Ca fonctionne même avec les nombres impaires, car il arrondi au plus haut, donc la moitié de 5 pour lui n'est pas 2.5, mais 3
            // On utilise 250%, car exemple que la longueur original est de 8, la longueur corrupt sera de 20, donc un ajout de 12 caractère, ce qui est 150% de 8 et 20, c'est 8 + 12, donc 100% + 150% qui donne 250%

            unCorruptedString += corruptedString[posToChoose];

            for (int i = 1; i < originalLenght; i++)
            {
                if (unCorruptedString.Length % 2 == 0) // Pair
                {
                    posToChoose++;
                    posToChoose++;
                }
                else
                {
                    posToChoose++;
                    posToChoose++;
                    posToChoose++;
                }

                unCorruptedString += corruptedString[posToChoose];
            }
            return unCorruptedString;
        }
    }
}
