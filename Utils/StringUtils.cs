﻿namespace MyUtilities
{
    public static class StringUtils
    {
        public static int Length(string str)
        {
            return str.Length;
        }
        public static string ToUpper(string str)
        {
            string newStr = "";
            int len = Length(str);
            for ( int i = 0 ; i < len ; i++ )
            {
                char c = str[i];
                if ( c == 'a' )
                {
                    newStr += 'A';
                }
                else if (c == 'b' )
                {
                    newStr += 'B';
                }
                else if (c == 'c' )
                {
                    newStr += 'C';
                }
                else if (c == 'd' )
                {
                    newStr += 'D';
                }
                else if (c =='e' )
                {
                    newStr += 'E';
                }
                else if (c == 'f' )
                {
                    newStr += 'F';
                }
                else if (c == 'g')
                {
                    newStr += 'G';
                }
                else if (c == 'h')
                {
                    newStr += 'H';
                }
                else if (c == 'i')
                {
                    newStr += 'I';
                }
                else if (c == 'j')
                {
                    newStr += 'J';
                }
                else if (c == 'k')
                {
                    newStr += 'K';
                }
                else if (c == 'l')
                {
                    newStr += 'L';
                }
                else if (c == 'm')
                {
                    newStr += 'M';
                }
                else if (c == 'n')
                {
                    newStr += 'N';
                }
                else if (c == 'o')
                {
                    newStr += 'O';
                }
                else if (c == 'p')
                {
                    newStr += 'P';
                }
                else if (c == 'q')
                {
                    newStr += 'q';
                }
                else if (c == 'r')
                {
                     newStr += 'R';
                }
                else if (c == 's')
                {
                    newStr += 'S';
                }
                else if (c == 't')
                {
                    newStr += 'T';
                }
                else if (c == 'u')
                {
                    newStr += 'U';
                }
                else if (c == 'v')
                {
                    newStr += 'V';
                }
                else if (c == 'w')
                {
                    newStr += 'W';
                }
                else if (c == 'x')
                {
                    newStr += 'X';
                } 
                else if (c == 'y')
                {
                    newStr += 'Y';
                }
                else if (c == 'z')
                {
                    newStr += 'Z';
                }
                else 
                {
                    newStr += c;
                }
            }
            return newStr;
        }
        public static string ToLower(string str)
        {
            string newStr = "";
            int len = Length(str);
            for ( int i = 0 ; i < len ; i++ )
            {
                char c = str[i];
                if ( c == 'A' )
                {
                    newStr += 'a';
                }
                else if (c == 'B' )
                {
                    newStr += 'b';
                }
                else if (c == 'C' )
                {
                    newStr += 'c';
                }
                else if (c == 'D' )
                {
                    newStr += 'd';
                }
                else if (c == 'E' )
                {
                    newStr += 'e';
                }
                else if (c == 'F' )
                {
                    newStr += 'f';
                }
                else if (c == 'G')
                {
                    newStr += 'g';
                }
                else if (c == 'H')
                {
                    newStr += 'h';
                }
                else if (c == 'I')
                {
                    newStr += 'i';
                }
                else if (c == 'J')
                {
                    newStr += 'j';
                }
                else if (c == 'K')
                {
                    newStr += 'k';
                }
                else if (c == 'L')
                {
                    newStr += 'l';
                }
                else if (c == 'M')
                {
                    newStr += 'm';
                }
                else if (c == 'N')
                {
                    newStr += 'n';
                }
                else if (c == 'O')
                {
                    newStr += 'o';
                }
                else if (c == 'P')
                {
                    newStr += 'p';
                }
                else if (c == 'Q')
                {
                    newStr += 'q';
                }
                else if (c == 'R')
                {
                     newStr += 'R';
                }
                else if (c == 'S')
                {
                    newStr += 's';
                }
                else if (c == 'T')
                {
                    newStr += 't';
                }
                else if (c == 'U')
                {
                    newStr += 'u';
                }
                else if (c == 'V')
                {
                    newStr += 'v';
                }
                else if (c == 'W')
                {
                    newStr += 'w';
                }
                else if (c == 'X')
                {
                    newStr += 'x';
                } 
                else if (c == 'y')
                {
                    newStr += 'y';
                }
                else if (c == 'Z')
                {
                    newStr += 'z';
                }
                else 
                {
                    newStr += c;
                }
            }
            return str;
        }
        public static string Reverse(string str)
        {
            int len = Length(str) - 1;
            string newStr = "";
            for ( int i = len ; i >= 0 ; i-- )
            {
                newStr += str[i];
            }
            return newStr;
        }
        public static bool HasLetter(string str, char ltr)
        {
            foreach (char cr in str)
            {
                if (cr == ltr)
                {
                    return true;
                }
            }
            return false;
        }
        public static int CountVowels(string word)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'I', 'O', 'U', 'E' };
            int vowelCount = 0;
            foreach (char letter in word)
            {
                foreach (char vowel in vowels)
                {
                    if (letter == vowel)
                    {
                        vowelCount++;
                    }
                }
            }
            return vowelCount;
        }
        public static int CountConsonants(string word)
        {
            string consonants = "qwrtplkjhgfdszxcvbnmQWSDFRTGHKLPMNBVCXZJ";
            int consonantCount = 0;
            foreach (char letter in word)
            {
                foreach (char consonant in consonants)
                {
                    if (letter == consonant)
                    {
                        consonantCount++;
                    }
                }
            }
            return consonantCount;
        }
        public static string RemoveLetter(string str, char letter)
        {
            string newStr = "";
            foreach ( char ltr in str )
            {
                if ( str[ltr] != letter )
                {
                    newStr += str[ltr];
                }
            }
            return newStr;
        }
        public static bool HasWord(string str, string word)
        {
            int correctLetters = 0;
            foreach (char letter in str )
            {
                foreach ( char ltr in word )
                {
                    if ( str[letter + ltr] == word[ltr] )
                    {
                        correctLetters++;
                    }
                    else
                    {
                        correctLetters = 0;
                    }
                }
            }
            if ( correctLetters == Length(word) )
            {
                return true;
            } 
            return false;
        }
        public static string ReplaceLetter(string str, char letter, char rLetter)
        {
            string newStr = "";
            foreach ( char ltr in str )
            {
                if ( str[ltr] != letter )
                {
                    newStr += str[ltr];
                }
                else if ( str[ltr] == letter )
                {
                    newStr += rLetter;
                }
                else 
                {
                    newStr += "\n";
                }
            }
            return newStr;
        }
        public static string InsertWord(string str, string word, int location)
        {
            string newStr = "";
            foreach ( char letter in str )
            {
                if ( letter < location ||letter > location)
                {
                    newStr += str[letter];
                }
                else if ( letter >= location )
                {
                    newStr += word;
                }
            }
            return newStr;
        }
    }
}