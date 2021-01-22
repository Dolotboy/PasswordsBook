using System;
using System.Collections.Generic;
using System.Text;

namespace MY_CSHARP_LIBRARY
{
    public class StringEncryptor
    {
        public string EncryptString(string theString)
        {
            int numLettre = 0;
            string encryptedString = "";

            for (int i = 0; i < theString.Length; i++)
            {
                numLettre = (int)theString[i];

                numLettre = EncryptFileName(numLettre);

                encryptedString += Char.ConvertFromUtf32(numLettre);
            }

            return encryptedString;
        }

        // J'ai été obligé de faire cette méthode d'encryption de nom, car certain caractère ne sont pas pris en compte par la méthode normal avec les char, il pouvait changer un A en $ par exemple, mais un nom de fichier ne peut pas contenir $ et quelques d'autres caractère
        public int EncryptFileName(int numLettre)
        {
            if (numLettre == 32) // Space
            {
                numLettre = 40; // (
            }
            else if (numLettre == 33) // !
            {
                numLettre = 44; // , 
            }
            // 34 " interdit
            // 35 # restera ainsi à cause des interdits
            else if (numLettre == 36) // $
            {
                numLettre = 50; // 2 
            }
            else if (numLettre == 37) // %
            {
                numLettre = 126; // ~ 
            }
            else if (numLettre == 38) // &
            {
                numLettre = 48; // 0 
            }
            else if (numLettre == 39) // '
            {
                numLettre = 68; // D 
            }
            else if (numLettre == 40) // (
            {
                numLettre = 32; // Space
            }
            else if (numLettre == 41) // )
            {
                numLettre = 121; // y
            }
            // 42 * interdit
            // 43 + restera ainsi à cause des interdits
            else if (numLettre == 44) // ,
            {
                numLettre = 33; // ! 
            }
            else if (numLettre == 45) // -
            {
                numLettre = 122; // z 
            }
            // 46 . interdit
            // 47 / interdit
            else if (numLettre == 48) // 0
            {
                numLettre = 38; // & 
            }
            else if (numLettre == 49) // 1
            {
                numLettre = 66; // B 
            }
            else if (numLettre == 50) // 2
            {
                numLettre = 36; // $ 
            }
            else if (numLettre == 51) // 3 
            {
                numLettre = 78; // N 
            }
            else if (numLettre == 52) // 4
            {
                numLettre = 73; // I 
            }
            else if (numLettre == 53) // 5
            {
                numLettre = 115; // s
            }
            else if (numLettre == 54) // 6
            {
                numLettre = 117; // u
            }
            else if (numLettre == 55) // 7
            {
                numLettre = 109; // m
            }
            else if (numLettre == 56) // 8
            {
                numLettre = 100; // d
            }
            else if (numLettre == 57) // 9
            {
                numLettre = 103; // g
            }
            // 58 : interdit
            // 59 ; restera ainsi à cause des interdits
            // 60 < interdit
            // 61 = restera ainsi à cause des interdits
            // 62 > interdit
            // 63 ? interdit
            // 64 @ restera ainsi à cause des interdits
            else if (numLettre == 65) // A
            {
                numLettre = 119; // w 
            }
            else if (numLettre == 66) // B
            {
                numLettre = 49; // 1 
            }
            // 67 C restera ainsi à cause d'un nombre imparaire de caractère
            else if (numLettre == 68) // D
            {
                numLettre = 39; // ' 
            }
            else if (numLettre == 69) // E
            {
                numLettre = 97; // a
            }
            else if (numLettre == 70) // F
            {
                numLettre = 72; // H 
            }
            else if (numLettre == 71) // G 
            {
                numLettre = 79; // O 
            }
            else if (numLettre == 72) // H
            {
                numLettre = 70; // F 
            }
            else if (numLettre == 73) // I
            {
                numLettre = 52; // 4
            }
            else if (numLettre == 74) // J
            {
                numLettre = 84; // T 
            }
            else if (numLettre == 75) // K
            {
                numLettre = 102; // f 
            }
            else if (numLettre == 76) // L
            {
                numLettre = 96; // `
            }
            else if (numLettre == 77) // M
            {
                numLettre = 90; // Z 
            }
            else if (numLettre == 78) // N
            {
                numLettre = 51; // 3
            }
            else if (numLettre == 79) // O
            {
                numLettre = 71; // G 
            }
            else if (numLettre == 80) // P
            {
                numLettre = 98; // b
            }
            else if (numLettre == 81) // Q
            {
                numLettre = 107; // k 
            }
            else if (numLettre == 82) // R
            {
                numLettre = 95; // _ 
            }
            else if (numLettre == 83) // S
            {
                numLettre = 108; // l 
            }
            else if (numLettre == 84) // T
            {
                numLettre = 74; // J 
            }
            else if (numLettre == 85) // U
            {
                numLettre = 120; // x 
            }
            else if (numLettre == 86) // V
            {
                numLettre = 105; // i 
            }
            else if (numLettre == 87) // W
            {
                numLettre = 89; // Y 
            }
            else if (numLettre == 88) // X
            {
                numLettre = 110; // n 
            }
            else if (numLettre == 89) // Y
            {
                numLettre = 87;// W 
            }
            else if (numLettre == 90) // Z
            {
                numLettre = 77; // M 
            }
            else if (numLettre == 91) // [
            {
                numLettre = 112; // 
            }
            // 92 \ interdit
            // 93 ] restera ainsi à cause des interdits
            // 94 ^ restera ainsi à cause des interdits
            else if (numLettre == 95) // _
            {
                numLettre = 82; // R 
            }
            else if (numLettre == 96) // `
            {
                numLettre = 76; // L 
            }
            else if (numLettre == 97) // a
            {
                numLettre = 69; // E
            }
            else if (numLettre == 98) // b
            {
                numLettre = 80; // P
            }
            else if (numLettre == 99) // c
            {
                numLettre = 106; // j
            }
            else if (numLettre == 100) // d
            {
                numLettre = 56; // 8
            }
            else if (numLettre == 101) // e
            {
                numLettre = 118; // v
            }
            else if (numLettre == 102) // f
            {
                numLettre = 75; // K
            }
            else if (numLettre == 103) // g
            {
                numLettre = 57; // 9
            }
            else if (numLettre == 104) // h
            {
                numLettre = 114; // r
            }
            else if (numLettre == 105) // i
            {
                numLettre = 86; // V
            }
            else if (numLettre == 106) // j
            {
                numLettre = 99; // c
            }
            else if (numLettre == 107) // k
            {
                numLettre = 81; // Q
            }
            else if (numLettre == 108) // l
            {
                numLettre = 83; // S
            }
            else if (numLettre == 109) // m
            {
                numLettre = 55; // 7
            }
            else if (numLettre == 110) // n
            {
                numLettre = 88; // X
            }
            else if (numLettre == 111) // o
            {
                numLettre = 113; // q
            }
            else if (numLettre == 112) // p
            {
                numLettre = 91; // [
            }
            else if (numLettre == 113) // q
            {
                numLettre = 111; // o
            }
            else if (numLettre == 114) // r
            {
                numLettre = 104; // h
            }
            else if (numLettre == 115) // s
            {
                numLettre = 53; // 5
            }
            else if (numLettre == 116) // t
            {
                numLettre = 123; // {
            }
            else if (numLettre == 117) // u
            {
                numLettre = 54; // 6
            }
            else if (numLettre == 118) // v
            {
                numLettre = 101; // e
            }
            else if (numLettre == 119) // w
            {
                numLettre = 65; // A
            }
            else if (numLettre == 120) // x
            {
                numLettre = 85; // U
            }
            else if (numLettre == 121) // y
            {
                numLettre = 41; // )
            }
            else if (numLettre == 122) // z
            {
                numLettre = 45; // -
            }
            else if (numLettre == 123) // {
            {
                numLettre = 116; // t
            }
            // 124 | Interdit
            // 125 } restera ainsi à cause des interdits
            else if (numLettre == 126) // ~ 
            {
                numLettre = 37; // % 
            }
            return numLettre;
        }
    }
}
