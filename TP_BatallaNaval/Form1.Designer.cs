﻿namespace TP_BatallaNaval
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menu_salir = new System.Windows.Forms.MenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel_auto_ganador = new System.Windows.Forms.Panel();
            this.lbl_j2_promedio = new System.Windows.Forms.Label();
            this.lbl_j1_promedio = new System.Windows.Forms.Label();
            this.ganados_jugador2 = new System.Windows.Forms.Label();
            this.ganados_jugador1 = new System.Windows.Forms.Label();
            this.ganador_automatico = new System.Windows.Forms.Label();
            this.panel_automatico = new System.Windows.Forms.Panel();
            this.txt_nombre_jugador2 = new System.Windows.Forms.TextBox();
            this.txt_nombre_jugador1 = new System.Windows.Forms.TextBox();
            this.lbl_nombre_jugador2 = new System.Windows.Forms.Label();
            this.lbl_nombre_jugador1 = new System.Windows.Forms.Label();
            this.lbl_automatico = new System.Windows.Forms.Label();
            this.btn_jugar_automatico = new System.Windows.Forms.Button();
            this.txt_automatico = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_efectividadJ2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_efectividadJ1 = new System.Windows.Forms.Label();
            this.lbl_cantRondas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_JugarManual = new System.Windows.Forms.Button();
            this.gridJugador2 = new System.Windows.Forms.DataGridView();
            this.grid_Jugador1 = new System.Windows.Forms.DataGridView();
            this.txt_nombreJugador2m = new System.Windows.Forms.TextBox();
            this.txt_nombreJugador1m = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel_auto_ganador.SuspendLayout();
            this.panel_automatico.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridJugador2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Jugador1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menu_salir});
            // 
            // menu_salir
            // 
            this.menu_salir.Index = 0;
            this.menu_salir.Text = "Salir";
            this.menu_salir.Click += new System.EventHandler(this.menu_salir_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1928, 911);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel_auto_ganador);
            this.tabPage1.Controls.Add(this.panel_automatico);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1920, 885);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Automatico";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel_auto_ganador
            // 
            this.panel_auto_ganador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_auto_ganador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_auto_ganador.Controls.Add(this.lbl_j2_promedio);
            this.panel_auto_ganador.Controls.Add(this.lbl_j1_promedio);
            this.panel_auto_ganador.Controls.Add(this.ganados_jugador2);
            this.panel_auto_ganador.Controls.Add(this.ganados_jugador1);
            this.panel_auto_ganador.Controls.Add(this.ganador_automatico);
            this.panel_auto_ganador.Location = new System.Drawing.Point(424, 26);
            this.panel_auto_ganador.Name = "panel_auto_ganador";
            this.panel_auto_ganador.Size = new System.Drawing.Size(527, 144);
            this.panel_auto_ganador.TabIndex = 3;
            // 
            // lbl_j2_promedio
            // 
            this.lbl_j2_promedio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_j2_promedio.Location = new System.Drawing.Point(259, 119);
            this.lbl_j2_promedio.Name = "lbl_j2_promedio";
            this.lbl_j2_promedio.Size = new System.Drawing.Size(276, 23);
            this.lbl_j2_promedio.TabIndex = 4;
            this.lbl_j2_promedio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_j1_promedio
            // 
            this.lbl_j1_promedio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_j1_promedio.Location = new System.Drawing.Point(-4, 119);
            this.lbl_j1_promedio.Name = "lbl_j1_promedio";
            this.lbl_j1_promedio.Size = new System.Drawing.Size(276, 23);
            this.lbl_j1_promedio.TabIndex = 3;
            this.lbl_j1_promedio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ganados_jugador2
            // 
            this.ganados_jugador2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ganados_jugador2.Location = new System.Drawing.Point(282, 81);
            this.ganados_jugador2.Name = "ganados_jugador2";
            this.ganados_jugador2.Size = new System.Drawing.Size(240, 23);
            this.ganados_jugador2.TabIndex = 2;
            this.ganados_jugador2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ganados_jugador1
            // 
            this.ganados_jugador1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ganados_jugador1.Location = new System.Drawing.Point(3, 81);
            this.ganados_jugador1.Name = "ganados_jugador1";
            this.ganados_jugador1.Size = new System.Drawing.Size(276, 23);
            this.ganados_jugador1.TabIndex = 1;
            this.ganados_jugador1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ganador_automatico
            // 
            this.ganador_automatico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ganador_automatico.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.ganador_automatico.Location = new System.Drawing.Point(3, 16);
            this.ganador_automatico.Name = "ganador_automatico";
            this.ganador_automatico.Size = new System.Drawing.Size(519, 22);
            this.ganador_automatico.TabIndex = 0;
            this.ganador_automatico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_automatico
            // 
            this.panel_automatico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_automatico.CausesValidation = false;
            this.panel_automatico.Controls.Add(this.txt_nombre_jugador2);
            this.panel_automatico.Controls.Add(this.txt_nombre_jugador1);
            this.panel_automatico.Controls.Add(this.lbl_nombre_jugador2);
            this.panel_automatico.Controls.Add(this.lbl_nombre_jugador1);
            this.panel_automatico.Controls.Add(this.lbl_automatico);
            this.panel_automatico.Controls.Add(this.btn_jugar_automatico);
            this.panel_automatico.Controls.Add(this.txt_automatico);
            this.panel_automatico.Location = new System.Drawing.Point(381, 298);
            this.panel_automatico.Name = "panel_automatico";
            this.panel_automatico.Size = new System.Drawing.Size(632, 166);
            this.panel_automatico.TabIndex = 2;
            // 
            // txt_nombre_jugador2
            // 
            this.txt_nombre_jugador2.Location = new System.Drawing.Point(143, 130);
            this.txt_nombre_jugador2.Name = "txt_nombre_jugador2";
            this.txt_nombre_jugador2.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre_jugador2.TabIndex = 10;
            // 
            // txt_nombre_jugador1
            // 
            this.txt_nombre_jugador1.Location = new System.Drawing.Point(143, 101);
            this.txt_nombre_jugador1.Name = "txt_nombre_jugador1";
            this.txt_nombre_jugador1.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre_jugador1.TabIndex = 9;
            // 
            // lbl_nombre_jugador2
            // 
            this.lbl_nombre_jugador2.AutoSize = true;
            this.lbl_nombre_jugador2.Location = new System.Drawing.Point(40, 133);
            this.lbl_nombre_jugador2.Name = "lbl_nombre_jugador2";
            this.lbl_nombre_jugador2.Size = new System.Drawing.Size(97, 13);
            this.lbl_nombre_jugador2.TabIndex = 8;
            this.lbl_nombre_jugador2.Text = "Nombre Jugador 2:";
            // 
            // lbl_nombre_jugador1
            // 
            this.lbl_nombre_jugador1.AutoSize = true;
            this.lbl_nombre_jugador1.Location = new System.Drawing.Point(40, 104);
            this.lbl_nombre_jugador1.Name = "lbl_nombre_jugador1";
            this.lbl_nombre_jugador1.Size = new System.Drawing.Size(97, 13);
            this.lbl_nombre_jugador1.TabIndex = 7;
            this.lbl_nombre_jugador1.Text = "Nombre Jugador 1:";
            // 
            // lbl_automatico
            // 
            this.lbl_automatico.AutoSize = true;
            this.lbl_automatico.Location = new System.Drawing.Point(40, 30);
            this.lbl_automatico.Name = "lbl_automatico";
            this.lbl_automatico.Size = new System.Drawing.Size(178, 13);
            this.lbl_automatico.TabIndex = 1;
            this.lbl_automatico.Text = "Ingrese la cantidad de simulaciones:";
            // 
            // btn_jugar_automatico
            // 
            this.btn_jugar_automatico.Location = new System.Drawing.Point(444, 71);
            this.btn_jugar_automatico.Name = "btn_jugar_automatico";
            this.btn_jugar_automatico.Size = new System.Drawing.Size(126, 28);
            this.btn_jugar_automatico.TabIndex = 6;
            this.btn_jugar_automatico.Text = "Jugar";
            this.btn_jugar_automatico.UseVisualStyleBackColor = true;
            this.btn_jugar_automatico.Click += new System.EventHandler(this.btn_jugar_automatico_Click);
            // 
            // txt_automatico
            // 
            this.txt_automatico.Location = new System.Drawing.Point(224, 27);
            this.txt_automatico.Name = "txt_automatico";
            this.txt_automatico.Size = new System.Drawing.Size(100, 20);
            this.txt_automatico.TabIndex = 4;
            this.txt_automatico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_automatico_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btn_JugarManual);
            this.tabPage2.Controls.Add(this.gridJugador2);
            this.tabPage2.Controls.Add(this.grid_Jugador1);
            this.tabPage2.Controls.Add(this.txt_nombreJugador2m);
            this.tabPage2.Controls.Add(this.txt_nombreJugador1m);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1920, 885);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manual";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_efectividadJ2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_efectividadJ1);
            this.groupBox1.Controls.Add(this.lbl_cantRondas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(686, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(256, 123);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estadísticas de la partida";
            // 
            // lbl_efectividadJ2
            // 
            this.lbl_efectividadJ2.AutoSize = true;
            this.lbl_efectividadJ2.Location = new System.Drawing.Point(136, 68);
            this.lbl_efectividadJ2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_efectividadJ2.Name = "lbl_efectividadJ2";
            this.lbl_efectividadJ2.Size = new System.Drawing.Size(0, 13);
            this.lbl_efectividadJ2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Efectividad Jugador 2:";
            // 
            // lbl_efectividadJ1
            // 
            this.lbl_efectividadJ1.AutoSize = true;
            this.lbl_efectividadJ1.Location = new System.Drawing.Point(136, 46);
            this.lbl_efectividadJ1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_efectividadJ1.Name = "lbl_efectividadJ1";
            this.lbl_efectividadJ1.Size = new System.Drawing.Size(0, 13);
            this.lbl_efectividadJ1.TabIndex = 3;
            // 
            // lbl_cantRondas
            // 
            this.lbl_cantRondas.AutoSize = true;
            this.lbl_cantRondas.Location = new System.Drawing.Point(122, 25);
            this.lbl_cantRondas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_cantRondas.Name = "lbl_cantRondas";
            this.lbl_cantRondas.Size = new System.Drawing.Size(0, 13);
            this.lbl_cantRondas.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Efectividad Jugador 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cantidad de rondas:";
            // 
            // btn_JugarManual
            // 
            this.btn_JugarManual.Location = new System.Drawing.Point(408, 9);
            this.btn_JugarManual.Name = "btn_JugarManual";
            this.btn_JugarManual.Size = new System.Drawing.Size(120, 27);
            this.btn_JugarManual.TabIndex = 6;
            this.btn_JugarManual.Text = "Jugar Ronda";
            this.btn_JugarManual.UseVisualStyleBackColor = true;
            this.btn_JugarManual.Click += new System.EventHandler(this.btn_JugarManual_Click);
            // 
            // gridJugador2
            // 
            this.gridJugador2.AllowUserToAddRows = false;
            this.gridJugador2.AllowUserToDeleteRows = false;
            this.gridJugador2.AllowUserToResizeColumns = false;
            this.gridJugador2.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridJugador2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridJugador2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gridJugador2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridJugador2.BackgroundColor = System.Drawing.Color.White;
            this.gridJugador2.ColumnHeadersHeight = 10;
            this.gridJugador2.ColumnHeadersVisible = false;
            this.gridJugador2.Location = new System.Drawing.Point(672, 148);
            this.gridJugador2.Name = "gridJugador2";
            this.gridJugador2.ReadOnly = true;
            this.gridJugador2.RowHeadersVisible = false;
            this.gridJugador2.RowHeadersWidth = 10;
            this.gridJugador2.RowTemplate.Height = 10;
            this.gridJugador2.Size = new System.Drawing.Size(670, 520);
            this.gridJugador2.TabIndex = 5;
            // 
            // grid_Jugador1
            // 
            this.grid_Jugador1.AllowUserToAddRows = false;
            this.grid_Jugador1.AllowUserToDeleteRows = false;
            this.grid_Jugador1.AllowUserToResizeColumns = false;
            this.grid_Jugador1.AllowUserToResizeRows = false;
            this.grid_Jugador1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_Jugador1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_Jugador1.BackgroundColor = System.Drawing.Color.White;
            this.grid_Jugador1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Jugador1.ColumnHeadersVisible = false;
            this.grid_Jugador1.Location = new System.Drawing.Point(-4, 148);
            this.grid_Jugador1.Name = "grid_Jugador1";
            this.grid_Jugador1.ReadOnly = true;
            this.grid_Jugador1.RowHeadersVisible = false;
            this.grid_Jugador1.RowTemplate.Height = 10;
            this.grid_Jugador1.Size = new System.Drawing.Size(656, 520);
            this.grid_Jugador1.TabIndex = 4;
            // 
            // txt_nombreJugador2m
            // 
            this.txt_nombreJugador2m.Location = new System.Drawing.Point(281, 15);
            this.txt_nombreJugador2m.Name = "txt_nombreJugador2m";
            this.txt_nombreJugador2m.Size = new System.Drawing.Size(100, 20);
            this.txt_nombreJugador2m.TabIndex = 3;
            // 
            // txt_nombreJugador1m
            // 
            this.txt_nombreJugador1m.Location = new System.Drawing.Point(82, 15);
            this.txt_nombreJugador1m.Name = "txt_nombreJugador1m";
            this.txt_nombreJugador1m.Size = new System.Drawing.Size(100, 20);
            this.txt_nombreJugador1m.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jugador 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jugador 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 708);
            this.Controls.Add(this.tabControl1);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Batalla Naval";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel_auto_ganador.ResumeLayout(false);
            this.panel_automatico.ResumeLayout(false);
            this.panel_automatico.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridJugador2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Jugador1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menu_salir;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel_auto_ganador;
        private System.Windows.Forms.Label lbl_j2_promedio;
        private System.Windows.Forms.Label lbl_j1_promedio;
        private System.Windows.Forms.Label ganados_jugador2;
        private System.Windows.Forms.Label ganados_jugador1;
        private System.Windows.Forms.Label ganador_automatico;
        private System.Windows.Forms.Panel panel_automatico;
        private System.Windows.Forms.TextBox txt_nombre_jugador2;
        private System.Windows.Forms.TextBox txt_nombre_jugador1;
        private System.Windows.Forms.Label lbl_nombre_jugador2;
        private System.Windows.Forms.Label lbl_nombre_jugador1;
        private System.Windows.Forms.Label lbl_automatico;
        private System.Windows.Forms.Button btn_jugar_automatico;
        private System.Windows.Forms.TextBox txt_automatico;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_nombreJugador2m;
        private System.Windows.Forms.TextBox txt_nombreJugador1m;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_JugarManual;
        private System.Windows.Forms.DataGridView gridJugador2;
        private System.Windows.Forms.DataGridView grid_Jugador1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_efectividadJ1;
        private System.Windows.Forms.Label lbl_cantRondas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_efectividadJ2;
        private System.Windows.Forms.Label label5;
    }
}

