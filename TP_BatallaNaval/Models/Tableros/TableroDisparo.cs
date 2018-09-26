using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_BatallaNaval.Models.Tableros
{
    public class TableroDisparo : Tablero
    {
        /// <summary>
        /// Devuelve una lista de coordenadas que tengo disponible para disparar con estrategia random
        /// </summary>
        /// <returns></returns>
        public List<Coordenada> casillasDisponibles()
        {
            List<Coordenada> disponibles = new List<Coordenada>();
            for (int i = 0; i < paneles.Length; i++)
            {
                for (int j = 0; j < paneles[i].Length; j++)
                {
                    if (paneles[i][j].tipoPanel == TipoPanel.Vacio && paneles[i][j].utilizaRandom)
                    {
                        disponibles.Add(new Coordenada(paneles[i][j].coordenadas.fila, paneles[i][j].coordenadas.columna));
                    }
                }
            }

            return disponibles;
        }

        /// <summary>
        /// Obtiene los paneles adyacentes a los paneles que se les pego y tienen un barco
        /// </summary>
        /// <returns></returns>
        public List<Coordenada> obtenerAdyacentesDisparados()
        {
            List<Panel> lstResultado = new List<Panel>();
            for (int i = 0; i < paneles.Length; i++)
            {
                for (int j = 0; j < paneles[i].Length; j++)
                {
                    if (paneles[i][j].tipoPanel == TipoPanel.Hit)
                    {
                        lstResultado.AddRange(obtenerAdyacentes(new Coordenada(paneles[i][j].coordenadas.fila, paneles[i][j].coordenadas.columna)).ToList());
                    }
                }
            }

            return lstResultado.Distinct().Where(x => x.tipoPanel == TipoPanel.Vacio).Select(x => x.coordenadas).ToList();
        }

        /// <summary>
        /// Devuelve los paneles adyacentes a una coordenada dada
        /// </summary>
        /// <param name="coordenadas"></param>
        /// <returns></returns>
        public List<Panel> obtenerAdyacentes(Coordenada coordenadas)
        {
            int fila = coordenadas.fila;
            int columna = coordenadas.columna;

            List<Panel> lstPaneles = new List<Panel>();
            if (columna > 0) { lstPaneles.Add(paneles.ubicado(fila, columna - 1)); } //Oeste

            if (fila > 0) { lstPaneles.Add(paneles.ubicado(fila - 1, columna)); } //Norte

            if (fila < 63) { lstPaneles.Add(paneles.ubicado(fila + 1, columna)); } //Sur

            if (columna < 31) { lstPaneles.Add(paneles.ubicado(fila, columna + 1)); } //Este

            return lstPaneles;
        }

    }
}
