using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_BatallaNaval.Models;

namespace TP_BatallaNaval
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menu_automatico_Click(object sender, EventArgs e)
        {
            panel_automatico.Visible = true;
            panel_auto_ganador.Visible = true;

        }

        private void menu_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_jugar_automatico_Click(object sender, EventArgs e)
        {
            turnControls(panel_automatico, false);
            int victorias_j1 = 0, victorias_j2 = 0;

            int promedioDisparosJ1 = 0, promedioDisparosJ2 = 0;

            int numJuegos = int.Parse(txt_automatico.Text);

            for (int i = 0; i < numJuegos; i++)
            {
                Partida partida = new Partida(txt_nombre_jugador1.Text, txt_nombre_jugador2.Text);
                partida.jugarHastaFinal();

                promedioDisparosJ1 += (1 / (i + 1)) * ((((i + 1) - 1) * promedioDisparosJ1) + partida.Jugador1.cantidadDisparos); //Formula de media
                promedioDisparosJ2 += (1 / (i + 1)) * ((((i + 1) - 1) * promedioDisparosJ2) + partida.Jugador2.cantidadDisparos); //Formula de media

                if (partida.Jugador1.haPerdido)
                {
                    victorias_j2++;
                }
                else
                {
                    victorias_j1++;
                }
            }
            turnControls(panel_automatico, true);
            if (victorias_j1 > victorias_j2)
            {
                ganador_automatico.Text = "El ganador es Jugador 1 (" + txt_nombre_jugador1.Text + ")";
            }
            else
            {
                if (victorias_j1 < victorias_j2)
                {

                    ganador_automatico.Text = "El ganador es Jugador 2 (" + txt_nombre_jugador2.Text + ")";
                }
                else
                {
                    ganador_automatico.Text = " La partida resulto en empate";
                }

            }

            ganados_jugador1.Text = "Victorias de Jugador 1 (" + txt_nombre_jugador1.Text + "): " + victorias_j1;
            ganados_jugador2.Text = "Victorias de Jugador 2 (" + txt_nombre_jugador2.Text + "): " + victorias_j2;
            lbl_j1_promedio.Text = "Media de disparos por partida de Jugador 1: " + promedioDisparosJ1;
            lbl_j2_promedio.Text = "Media de disparos por partida de Jugador 2: " + promedioDisparosJ2;

        }

        /// <summary>
        /// Activa (true) y desactiva (false) los controles del panel parametro
        /// </summary>
        /// <param name="panel"></param>
        /// <param name="param"></param>
        private void turnControls(Panel panel, bool param)
        {
            if (!param)
            {
                foreach (Control control in panel.Controls)
                {
                    control.Enabled = false;
                }
            }
            else
            {
                foreach (Control control in panel.Controls)
                {
                    control.Enabled = true;
                }
            }

        }

        private Color buscarColor(String estado_panel)
        {
            if (estado_panel == "O")
            {
                return Color.LightBlue;
            } else if(estado_panel=="C" || estado_panel=="D" || estado_panel == "F" || estado_panel == "P" || estado_panel == "S")
            {
                return Color.Gray;
            }
            else
            {
                return Color.Red;
            }
        }

        private String buscarResultadoDisparo(String estado_panel)
        {
            if (estado_panel == "X" || estado_panel=="M")
            {
                return "X";
            }
            else
            {
                return "";
            }
        }

        int flag = 0;
        Partida partida = null;
        private void btn_JugarManual_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if(flag == 0)
            {// PRIMERA VEZ QUE SE APRIETA EL BOTON
                // Crea la partida
                partida = new Partida(txt_nombreJugador1m.Text, txt_nombreJugador2m.Text);
             //Inicializa las grillas
                // Limpia ambos tableros
                grid_Jugador1.Rows.Clear();
                gridJugador2.Rows.Clear();
                // Agrega 32 columnas a ambos tableros
                grid_Jugador1.ColumnCount = 32;
                gridJugador2.ColumnCount = 32;
                // Agrega las filas vacías a las grillas que después se van a llenar con barcos y disparos
                for (int i = 0; i < 64; i++)
                {
                    grid_Jugador1.Rows.Add();
                    gridJugador2.Rows.Add();
                }  
            }
            
            // Ejecuta un disparo cada jugador
            partida.jugarRonda();
            // Trae los tableros de cada jugador
            Models.Tableros.Panel[][] tableroJugador1 = partida.Jugador1.TableroDisparo.paneles;
            Models.Tableros.Panel[][] tableroJugador2 = partida.Jugador2.TableroDisparo.paneles;
           // LLena las grillas con los barcos y los disparos
            for (int i = 0; i < 64; i++)
            {
                for (int j = 0; j < 32; j++)
                {
                    if (flag == 0)
                    {
                        // Colorea cada casilla de ambos tableros para ver la ubicacion de los barcos (Solo la primera vez que se aprieta el boton)
                        Color colorCasillaJ1 = buscarColor(tableroJugador1[i][j].Estado);
                        Color colorCasillaJ2 = buscarColor(tableroJugador2[i][j].Estado);
                        
                        grid_Jugador1.Rows[i].Cells[j].Style.BackColor = colorCasillaJ1;
                        gridJugador2.Rows[i].Cells[j].Style.BackColor = colorCasillaJ2;
                    }
                    
                        //Pone los disparos en cada tablero como una X
                        String disparoJ1 = buscarResultadoDisparo(tableroJugador1[i][j].Estado);
                        String disparoJ2 = buscarResultadoDisparo(tableroJugador2[i][j].Estado);

                        grid_Jugador1.Rows[i].Cells[j].Value = disparoJ1;
                        gridJugador2.Rows[i].Cells[j].Value = disparoJ2;
                }
            }
            flag++;
            Cursor.Current = Cursors.Default;
        }
    }
}
