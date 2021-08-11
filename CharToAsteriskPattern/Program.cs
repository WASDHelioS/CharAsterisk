using System;

namespace CharToAsteriskPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer();
            p.Print("stool lots");
        }
    }

    public class Printer
    {
        Letters letters = new Letters();
        public void Print(string phrase)
        {
            char letter;
            char[,] bigletter = null;

            char[] phr = phrase.ToCharArray();
            char[,,] charlist = new char[phr.Length, 5, 3];
            for(int i = 0; i < phr.Length; i++)
            {
                letter = phr[i];
                bigletter = letters.CharToCharMatrix(letter);
                for(int j = 0; j < 5; j++)
                {
                    for(int k = 0; k < 3; k++)
                    {
                        charlist[i, j, k] = bigletter[j,k];
                    }
                }
            }
            for(int i =0; i< 5; i++)
            {
                string str = "";
                for(int j=0; j<charlist.GetLength(0);j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        str += charlist[j,i,k] + " ";
                    }
                    str += "   ";
                }
                Console.WriteLine(str);
            }
        }
    }




    public class Letters
    {
        private static readonly char[,] A = new char[5, 3]
        {
            {' ','*',' '},
            {'*',' ','*'},
            {'*','*','*'},
            {'*',' ','*'},
            {'*',' ','*'}
        };
        private static readonly char[,] S = new char[5, 3]
        {
            {'*','*','*'},
            {'*',' ',' '},
            {'*','*','*'},
            {' ',' ','*'},
            {'*','*','*'}
        };
        private static readonly char[,] H = new char[5, 3]
        {
            {'*',' ','*'},
            {'*',' ','*'},
            {'*','*','*'},
            {'*',' ','*'},
            {'*',' ','*'}
        };
        private static readonly char[,] O = new char[5, 3]
        {
            {' ','*',' '},
            {'*',' ','*'},
            {'*',' ','*'},
            {'*',' ','*'},
            {' ','*',' '}
        };
        private static readonly char[,] L = new char[5, 3]
        {
            {'*',' ',' '},
            {'*',' ',' '},
            {'*',' ',' '},
            {'*',' ',' '},
            {'*','*','*'}
        };
        private static readonly char[,] E = new char[5, 3]
        {
            {'*','*','*'},
            {'*',' ',' '},
            {'*','*','*'},
            {'*',' ',' '},
            {'*','*','*'}
        };
        private static readonly char[,] SPACE = new char[5, 3]
        {
            {' ',' ',' '},
            {' ',' ',' '},
            {' ',' ',' '},
            {' ',' ',' '},
            {' ',' ',' '}
        };
        private static readonly char[,] I = new char[5,3]
        {
            {' ','*',' '},
            {' ','*',' '},
            {' ','*',' '},
            {' ','*',' '},
            {' ','*',' '}
        };

        private static readonly char[,] T = new char[5, 3]
        {
            {'*','*','*'},
            {' ','*',' '},
            {' ','*',' '},
            {' ','*',' '},
            {' ','*',' '}
        };


        public char[,] CharToCharMatrix(char c)
        {
            if (c == 'a') return A;
            if (c == 'e') return E;
            if (c == 'h') return H;
            if (c == 'l') return L;
            if (c == 'o') return O;
            if (c == 's') return S;
            if (c == 't') return T;
            if (c == 'i') return I;
            if (c == ' ') return SPACE;
            else return null;
        }
    }

}
