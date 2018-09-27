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

        int flag = 0;
        Partida partida = null;
        private void btn_JugarManual_Click(object sender, EventArgs e)
        {
            if(flag == 0)
            {
                partida = new Partida(txt_nombreJugador1m.Text, txt_nombreJugador2m.Text);
            }            
            partida.jugarRonda();
            Models.Tableros.Panel[][] tableroJugador1 = partida.Jugador1.TableroDisparo.paneles;
            Models.Tableros.Panel[][] tableroJugador2 = partida.Jugador2.TableroDisparo.paneles;
            grid_Jugador1.ColumnCount = 32;
            grid_Jugador1.Rows.Clear();
            gridJugador2.ColumnCount = 32;
            gridJugador2.Rows.Clear();

            for (int i = 0; i < 64; i++)
            {
                for (int j = 0; j < 32; j++)
                {
                    grid_Jugador1.Rows.Add();
                    grid_Jugador1.Rows[i].Cells[j].Value = tableroJugador1[i][j].Estado;

                    gridJugador2.Rows.Add();
                    gridJugador2.Rows[i].Cells[j].Value = tableroJugador2[i][j].Estado;

                }
            }
            flag = 1;
        }
    }
}
