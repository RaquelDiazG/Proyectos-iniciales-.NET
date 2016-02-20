using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaminasVentana
{

    class Tablero{

        private Casilla[,] casillas;
        private int filas;
        private int columnas;

        public Tablero(int f, int c)
        {
            //Creamos el tablero con un borde
            casillas = new Casilla[f+2, c+2];
            this.filas = f + 2;
            this.columnas = c + 2;

            //Rellenamos el tablero con objetos casilla
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    casillas[i, j] = new Casilla();
                }
            }

            //Inicializar el tablero
            initTablero();
        }

        private void initTablero()
        {
            //Introducmos bombas en el tablero (sin el borde)
            Random aleatorio = new Random();

            for (int i = 1; i < filas-1; i++)
            {
                for (int j = 1; j < columnas-1; j++)
                {
                    if (aleatorio.Next(100)<20)
                    {
                        //Poner bomba
                        casillas[i, j].bomba=true;
                        //Sumar 1 alrederor
                        for (int f = i - 1; f <= i + 1; f++)
                        {
                            for (int c = j - 1; c <= j + 1; c++)
                            {
                                casillas[f, c].num++;
                            }
                        }
                    }
                }
            }
            //Poner en el borde numeros
            for (int i = 1; i < columnas; i++)
            {
                casillas[0,i].num=23;
                casillas[filas-1,i].num=39;
            }
            for (int j = 1; j < filas; j++)
            {
                casillas[j, 0].num = 23;
                casillas[j, columnas-1].num = 39;
            }
        }


        public void visualizar()
        {
            //Mostrar el tablero (sin el borde)
            for (int i = 1; i < filas-1; i++)
            {
                for (int j = 1; j < columnas-1; j++)
                {
                    Console.Write(casillas[i, j]);
                }
                Console.WriteLine();
            }
        }

        public void levantar(int f, int c)
        {
            casillas[f, c].levantada = true;
            if (casillas[f, c].num == 0 && casillas[f, c].bomba==false)
            {
                for (int i = f - 1; i <= f + 1; i++)
                {
                    for (int j = c - 1; j <= c + 1; j++)
                    {
                        if (casillas[i, j].levantada == false)
                        {
                            levantar(i, j);
                        }
                    }
                }
            }
        }

        internal string queHayEn(int f, int c)
        {
            return casillas[f, c].ToString();
        }
    }
}
