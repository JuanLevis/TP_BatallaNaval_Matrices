using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            this.WindowState = FormWindowState.Maximized;
            //Setea una mejora de Scroll para la grilla de jugador 1
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.SetProperty, null,
            grid_Jugador1, new object[] { true });
            //Setea una mejora de Scroll para la grilla de jugador 2
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.SetProperty, null,
            gridJugador2, new object[] { true });

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
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
        private void tabControl1_SelectedIndexChanged(Object sender, EventArgs e)
        {
            TabControl control = (TabControl)sender;
            if (control.SelectedTab.Text == "Automatico")
            {
                Jugador.flagManual = false;
                partida = null;
                cantidadRondas = 0;
                hitsJ1 = 0;
                hitsJ2 = 0;
                lbl_cantRondas.Text = "0";
                lbl_efectividadJ1.Text = "0%";
                lbl_efectividadJ2.Text = "0%";
                grid_Jugador1.Rows.Clear();
                gridJugador2.Rows.Clear();
            }
            else
            {
                Jugador.flagManual = true;
            }
        }

        


        private Color buscarColor(string estado_panel)
        {
            if (estado_panel == "O")
            {
                return Color.LightBlue;
            }
            else if (estado_panel == "C" || estado_panel == "D" || estado_panel == "F" || estado_panel == "P" || estado_panel == "S")
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
            if (estado_panel == "M")
            {
                return "X";
            }
            else if (estado_panel == "X")
            {
                return "H";
            }
            else
            {
                return string.Empty;
            }
        }
        
        int cantidadRondas = 0;
        Partida partida = null;
        float hitsJ1 = 0;
        float hitsJ2 = 0;
       
        private void btn_JugarManual_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cantidadRondas == 0)
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
                    grid_Jugador1.Rows[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; //Alinea las letras en las celdas
                    gridJugador2.Rows.Add();
                    gridJugador2.Rows[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }


            // Trae los tableros de cada jugador
            Models.Tableros.Panel[][] tableroJugador1 = partida.Jugador1.TableroDisparo.paneles;
            Models.Tableros.Panel[][] tableroJugador2 = partida.Jugador2.TableroDisparo.paneles;
            hitsJ1 = 0;
            hitsJ2 = 0;
            // LLena las grillas con los barcos y los disparos
            for (int i = 0; i < 64; i++)
            {
                for (int j = 0; j < 32; j++)
                {
                    if (cantidadRondas == 0)
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
                    if (disparoJ1 == "H")
                    {
                        Color colorCasillaJ1 = Color.Red;
                        grid_Jugador1.Rows[i].Cells[j].Style.BackColor = colorCasillaJ1;
                        gridJugador2.Rows[i].Cells[j].Style.BackColor = colorCasillaJ1;
                        hitsJ1++;
                    }
                    if (disparoJ2 == "H")
                    {
                        Color colorCasillaJ2 = Color.Red;
                        gridJugador2.Rows[i].Cells[j].Style.BackColor = colorCasillaJ2;
                        grid_Jugador1.Rows[i].Cells[j].Style.BackColor = colorCasillaJ2;
                        hitsJ2++;
                    }
                    grid_Jugador1.Rows[i].Cells[j].Value = disparoJ1;
                    gridJugador2.Rows[i].Cells[j].Value = disparoJ2;
                }
            }
            // Ejecuta un disparo cada jugador
            partida.jugarRonda();
            cantidadRondas++;
            float efectividadJ1 = hitsJ1 / partida.Jugador1.cantidadDisparos;
            float efectividadJ2 = hitsJ2 / partida.Jugador2.cantidadDisparos; 
            lbl_cantRondas.Text = cantidadRondas.ToString();
            lbl_efectividadJ1.Text = efectividadJ1.ToString() + " %";
            lbl_efectividadJ2.Text = efectividadJ2.ToString() + " %";
            Cursor.Current = Cursors.Default;
        }

        private void txt_automatico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo solo admite numeros enteros");
            }
        }
    }
}
