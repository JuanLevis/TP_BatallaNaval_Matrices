using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_BatallaNaval.Models.Tableros
{
    public class Tablero
    {
        public Panel[][] paneles { get; set; }

        public Tablero()
        {
            paneles = new Panel[64][];
            for (int i = 0; i < paneles.Length; i++)
            {
                paneles[i] = new Panel[32];
                for (int j = 0; j < paneles[i].Length; j++)
                {
                    paneles[i][j] = new Panel(i, j);
                }
            }
        }
    }
}
