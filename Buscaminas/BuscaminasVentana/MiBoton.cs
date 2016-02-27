using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BuscaminasVentana
{
    class MiBoton:Button
    {
        public int f;
        public int c;

        public MiBoton(int i, int j):base()
        {
            f = i;
            c=j;
        }
    }
}
