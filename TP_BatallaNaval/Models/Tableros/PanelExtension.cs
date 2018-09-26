using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_BatallaNaval.Models.Tableros
{
    public static class PanelExtension
    {
        /// <summary>
        /// Devuelve la coordenada del array
        /// </summary>
        /// <param name="paneles"></param>
        /// <param name="fila"></param>
        /// <param name="columna"></param>
        /// <returns></returns>
        public static Panel ubicado(this Panel[][] paneles, int fila, int columna)
        {
            return paneles[fila][columna];
        }

        public static List<Panel> Rango(this Panel[][] paneles ,int filaInicio, int columnaInicio , int filaFinal, int columnaFinal)
        {
            List<Panel> lstPaneles = new List<Panel>();

            if (columnaInicio == columnaFinal)
            {
                for (int i = filaInicio; i <= filaFinal; i++)
                {
                    lstPaneles.Add(paneles[i][columnaFinal]);
                }
            }
            else
            {
                for (int i = columnaInicio; i < columnaFinal; i++)
                {
                    lstPaneles.Add(paneles[filaFinal][i]);
                }
            }
            
            return lstPaneles;
        }
    }
}
