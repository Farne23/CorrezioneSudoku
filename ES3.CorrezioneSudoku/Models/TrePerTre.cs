using System;
using System.Collections.Generic;
using System.Text;

namespace ES3.CorrezioneSudoku.Models
{
    class TrePerTre
    {
        int[,] Tabella;
        public bool Corretto;

        public TrePerTre(int xquadrante, int yquadrante, int[,] TabCompleta)
        {
            Tabella = new int[3, 3];
            Corretto = false;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Tabella[i, j] = TabCompleta[i + (3 * xquadrante), j + (3 * yquadrante)];
                }
            }
        }

        public void Verifica()
        {
            bool trovato = false;
            bool a = true;

            for (int i = 1; i <= 9; i++)
            {
                for (int x = 0; x < 3; x++)
                {
                    for (int y = 0; y < 3; y++)
                    {
                        if (Tabella[x, y] == i)
                        {
                            trovato = true;
                            break;
                        }

                    }

                    if (trovato == true)
                    {
                        break;
                    }
                }

                if (trovato == false)
                {
                    a = false;
                    break;
                }
                trovato = false;
            }

            if (a == true)
            {
                Corretto = true;
            }
        }

    }
}
