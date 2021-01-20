using System;
using System.Collections.Generic;
using System.Text;

namespace ES3.CorrezioneSudoku.Models
{
    class Colonna
    {

        int[] LineaV;
        public bool Corretto;

        public Colonna(int y, int[,] TabCompleta)
        {
            LineaV = new int[9];
            Corretto = false;

            for (int i = 0; i < 9; i++)
            {
                LineaV[i] = TabCompleta[i, y];
            }
        }

        public void Verifica()
        {
            bool a = false;
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (LineaV[j] == i)
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
