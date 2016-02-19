using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaminasVentana
{
    public partial class Form1 : Form
    {
        private Tablero tablero = new Tablero(10,10);
        private Button[,] botones = new Button[10, 10];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.RowCount = 10;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    botones[i, j] = new MiBoton(i+1,j+1);
                    //botones[i, j].Text = "f: " + (i + 1);
                    this.tableLayoutPanel1.Controls.Add(botones[i, j]);

                    //asociamos un controlador de eventos para todos los botones
                    botones[i,j].Click+=new EventHandler(this.OnClick);
                }
            }
            actualizaIU();
        }

        private void OnClick(object sender, EventArgs e)
        {
            //MessageBox.Show("fila: "+((MiBoton)sender).f);
            tablero.levantar(((MiBoton)sender).f, ((MiBoton)sender).c);
            actualizaIU();
        }

        public void actualizaIU()
        {
            for (int f = 1; f <= 10; f++)
            {
                for (int c = 1; c <= 10; c++)
                {
                    //Texto en el boton
                    botones[f-1,c-1].Text=tablero.queHayEn(f, c);

                    if (tablero.queHayEn(f, c).Equals("0"))
                    {
                        botones[f - 1, c - 1].Enabled = false;
                        botones[f - 1, c - 1].Text = "";
                    }
                    else if (tablero.queHayEn(f, c).Equals("B"))
                    {
                        botones[f - 1, c - 1].Image=global::BuscaminasVentana.Properties.Resources.bomba;
                    }
                }
            }
        }
    }
}
