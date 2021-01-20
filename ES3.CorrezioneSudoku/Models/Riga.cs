using System;
using System.Collections.Generic;
using System.Text;

namespace ES3.CorrezioneSudoku.Models
{
    class Riga
    {

        int[] LineaO;
        public bool Corretto;

        public Riga(int x, int[,] TabCompleta)
        {
            LineaO = new int[9];
            Corretto = false;

            for (int i = 0; i < 9; i++)
            {
                LineaO[i] = TabCompleta[x, i];
            }
        }

        public void Verifica()
        {
            bool a = false;
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (LineaO[j] == i)
                    {
                        a = true;
                        break;
                    }
                }

                if (a == false)
                {
                    break;
                }
                if (i != 9)
                {
                    a = false;
                }
            }

            if (a == true)
            {
                Corretto = true;
            }
        }
    }
}
