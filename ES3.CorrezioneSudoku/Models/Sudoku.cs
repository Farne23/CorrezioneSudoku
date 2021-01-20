using System;
using System.Collections.Generic;
using System.Text;

namespace ES3.CorrezioneSudoku.Models
{
    class Sudoku
    {
        int[,] _griglia;
        bool _corretto;
        public bool Corretto { get; private set; }
        public int[,] Griglia { get; private set; }

        public Sudoku(int[,] GrigliaInput)
        {
            Griglia = GrigliaInput;
            Corretto = false;
        }

        public bool Correggi()
        {
            Corretto = true;

            //Controllo delle righe
            for (int i = 0; i < 9; i++)
            {
                Riga rigacontrollo = new Riga(i, Griglia);
                rigacontrollo.Verifica();
                if (rigacontrollo.Corretto == false)
                {
                    Corretto = false;
                }
            }

            //Controllo delle colonne
            for (int i = 0; i < 9; i++)
            {
                Colonna colonnacontrollo = new Colonna(i, Griglia);
                colonnacontrollo.Verifica();
                if (colonnacontrollo.Corretto == false)
                {
                    Corretto = false;
                }
            }

            //Controllo dei quadranti
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    TrePerTre trextrecontrollo = new TrePerTre(i, j, Griglia);
                    trextrecontrollo.Verifica();

                    if (trextrecontrollo.Corretto == false)
                    {
                        Corretto = false;
                    }
                }
            }
            return Corretto;
        }

        public override string ToString()
        {
            string output = "\r\n Griglia del sudoku: \r\n";

            output += "___________________\r\n";
            for (int i=0; i<9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    output += $"|{Griglia[i, j].ToString()}";
                }
                output += "|\r\n";
            }
            output += "¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯";

            return output;
        }
    }
}
