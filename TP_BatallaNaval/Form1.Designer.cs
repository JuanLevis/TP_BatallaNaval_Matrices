namespace TP_BatallaNaval
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
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1800, 1000);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel_auto_ganador);
            this.tabPage1.Controls.Add(this.panel_automatico);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1546, 769);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Automatico";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel_auto_ganador
            // 
            this.panel_auto_ganador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_auto_ganador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_auto_ganador.Controls.Add(this.lbl_j2_promedio);
            this.panel_auto_ganador.Controls.Add(this.lbl_j1_promedio);
            this.panel_auto_ganador.Controls.Add(this.ganados_jugador2);
            this.panel_auto_ganador.Controls.Add(this.ganados_jugador1);
            this.panel_auto_ganador.Controls.Add(this.ganador_automatico);
            this.panel_auto_ganador.Location = new System.Drawing.Point(179, 47);
            this.panel_auto_ganador.Margin = new System.Windows.Forms.Padding(4);
            this.panel_auto_ganador.Name = "panel_auto_ganador";
            this.panel_auto_ganador.Size = new System.Drawing.Size(702, 177);
            this.panel_auto_ganador.TabIndex = 3;
            // 
            // lbl_j2_promedio
            // 
            this.lbl_j2_promedio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_j2_promedio.Location = new System.Drawing.Point(345, 146);
            this.lbl_j2_promedio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_j2_promedio.Name = "lbl_j2_promedio";
            this.lbl_j2_promedio.Size = new System.Drawing.Size(368, 28);
            this.lbl_j2_promedio.TabIndex = 4;
            this.lbl_j2_promedio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_j1_promedio
            // 
            this.lbl_j1_promedio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_j1_promedio.Location = new System.Drawing.Point(-5, 146);
            this.lbl_j1_promedio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_j1_promedio.Name = "lbl_j1_promedio";
            this.lbl_j1_promedio.Size = new System.Drawing.Size(368, 28);
            this.lbl_j1_promedio.TabIndex = 3;
            this.lbl_j1_promedio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ganados_jugador2
            // 
            this.ganados_jugador2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ganados_jugador2.Location = new System.Drawing.Point(376, 100);
            this.ganados_jugador2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ganados_jugador2.Name = "ganados_jugador2";
            this.ganados_jugador2.Size = new System.Drawing.Size(320, 28);
            this.ganados_jugador2.TabIndex = 2;
            this.ganados_jugador2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ganados_jugador1
            // 
            this.ganados_jugador1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ganados_jugador1.Location = new System.Drawing.Point(4, 100);
            this.ganados_jugador1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ganados_jugador1.Name = "ganados_jugador1";
            this.ganados_jugador1.Size = new System.Drawing.Size(368, 28);
            this.ganados_jugador1.TabIndex = 1;
            this.ganados_jugador1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ganador_automatico
            // 
            this.ganador_automatico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ganador_automatico.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.ganador_automatico.Location = new System.Drawing.Point(4, 20);
            this.ganador_automatico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ganador_automatico.Name = "ganador_automatico";
            this.ganador_automatico.Size = new System.Drawing.Size(692, 27);
            this.ganador_automatico.TabIndex = 0;
            this.ganador_automatico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_automatico
            // 
            this.panel_automatico.CausesValidation = false;
            this.panel_automatico.Controls.Add(this.txt_nombre_jugador2);
            this.panel_automatico.Controls.Add(this.txt_nombre_jugador1);
            this.panel_automatico.Controls.Add(this.lbl_nombre_jugador2);
            this.panel_automatico.Controls.Add(this.lbl_nombre_jugador1);
            this.panel_automatico.Controls.Add(this.lbl_automatico);
            this.panel_automatico.Controls.Add(this.btn_jugar_automatico);
            this.panel_automatico.Controls.Add(this.txt_automatico);
            this.panel_automatico.Location = new System.Drawing.Point(121, 278);
            this.panel_automatico.Margin = new System.Windows.Forms.Padding(4);
            this.panel_automatico.Name = "panel_automatico";
            this.panel_automatico.Size = new System.Drawing.Size(817, 204);
            this.panel_automatico.TabIndex = 2;
            // 
            // txt_nombre_jugador2
            // 
            this.txt_nombre_jugador2.Location = new System.Drawing.Point(191, 160);
            this.txt_nombre_jugador2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre_jugador2.Name = "txt_nombre_jugador2";
            this.txt_nombre_jugador2.Size = new System.Drawing.Size(132, 22);
            this.txt_nombre_jugador2.TabIndex = 10;
            // 
            // txt_nombre_jugador1
            // 
            this.txt_nombre_jugador1.Location = new System.Drawing.Point(191, 124);
            this.txt_nombre_jugador1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre_jugador1.Name = "txt_nombre_jugador1";
            this.txt_nombre_jugador1.Size = new System.Drawing.Size(132, 22);
            this.txt_nombre_jugador1.TabIndex = 9;
            // 
            // lbl_nombre_jugador2
            // 
            this.lbl_nombre_jugador2.AutoSize = true;
            this.lbl_nombre_jugador2.Location = new System.Drawing.Point(53, 164);
            this.lbl_nombre_jugador2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombre_jugador2.Name = "lbl_nombre_jugador2";
            this.lbl_nombre_jugador2.Size = new System.Drawing.Size(130, 17);
            this.lbl_nombre_jugador2.TabIndex = 8;
            this.lbl_nombre_jugador2.Text = "Nombre Jugador 2:";
            // 
            // lbl_nombre_jugador1
            // 
            this.lbl_nombre_jugador1.AutoSize = true;
            this.lbl_nombre_jugador1.Location = new System.Drawing.Point(53, 128);
            this.lbl_nombre_jugador1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombre_jugador1.Name = "lbl_nombre_jugador1";
            this.lbl_nombre_jugador1.Size = new System.Drawing.Size(130, 17);
            this.lbl_nombre_jugador1.TabIndex = 7;
            this.lbl_nombre_jugador1.Text = "Nombre Jugador 1:";
            // 
            // lbl_automatico
            // 
            this.lbl_automatico.AutoSize = true;
            this.lbl_automatico.Location = new System.Drawing.Point(53, 37);
            this.lbl_automatico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_automatico.Name = "lbl_automatico";
            this.lbl_automatico.Size = new System.Drawing.Size(237, 17);
            this.lbl_automatico.TabIndex = 1;
            this.lbl_automatico.Text = "Ingrese la cantidad de simulaciones:";
            // 
            // btn_jugar_automatico
            // 
            this.btn_jugar_automatico.Location = new System.Drawing.Point(592, 87);
            this.btn_jugar_automatico.Margin = new System.Windows.Forms.Padding(4);
            this.btn_jugar_automatico.Name = "btn_jugar_automatico";
            this.btn_jugar_automatico.Size = new System.Drawing.Size(168, 34);
            this.btn_jugar_automatico.TabIndex = 6;
            this.btn_jugar_automatico.Text = "Jugar";
            this.btn_jugar_automatico.UseVisualStyleBackColor = true;
            this.btn_jugar_automatico.Click += new System.EventHandler(this.btn_jugar_automatico_Click);
            // 
            // txt_automatico
            // 
            this.txt_automatico.Location = new System.Drawing.Point(299, 33);
            this.txt_automatico.Margin = new System.Windows.Forms.Padding(4);
            this.txt_automatico.Name = "txt_automatico";
            this.txt_automatico.Size = new System.Drawing.Size(132, 22);
            this.txt_automatico.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_JugarManual);
            this.tabPage2.Controls.Add(this.gridJugador2);
            this.tabPage2.Controls.Add(this.grid_Jugador1);
            this.tabPage2.Controls.Add(this.txt_nombreJugador2m);
            this.tabPage2.Controls.Add(this.txt_nombreJugador1m);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1792, 971);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manual";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_JugarManual
            // 
            this.btn_JugarManual.Location = new System.Drawing.Point(544, 11);
            this.btn_JugarManual.Margin = new System.Windows.Forms.Padding(4);
            this.btn_JugarManual.Name = "btn_JugarManual";
            this.btn_JugarManual.Size = new System.Drawing.Size(160, 33);
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
            this.gridJugador2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.gridJugador2.BackgroundColor = System.Drawing.Color.White;
            this.gridJugador2.ColumnHeadersHeight = 10;
            this.gridJugador2.ColumnHeadersVisible = false;
            this.gridJugador2.Location = new System.Drawing.Point(928, 55);
            this.gridJugador2.Margin = new System.Windows.Forms.Padding(4);
            this.gridJugador2.Name = "gridJugador2";
            this.gridJugador2.ReadOnly = true;
            this.gridJugador2.RowHeadersVisible = false;
            this.gridJugador2.RowHeadersWidth = 10;
            this.gridJugador2.RowTemplate.Height = 10;
            this.gridJugador2.Size = new System.Drawing.Size(912, 794);
            this.gridJugador2.TabIndex = 5;
            // 
            // grid_Jugador1
            // 
            this.grid_Jugador1.AllowUserToAddRows = false;
            this.grid_Jugador1.AllowUserToDeleteRows = false;
            this.grid_Jugador1.AllowUserToResizeColumns = false;
            this.grid_Jugador1.AllowUserToResizeRows = false;
            this.grid_Jugador1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.grid_Jugador1.BackgroundColor = System.Drawing.Color.White;
            this.grid_Jugador1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Jugador1.ColumnHeadersVisible = false;
            this.grid_Jugador1.Location = new System.Drawing.Point(8, 55);
            this.grid_Jugador1.Margin = new System.Windows.Forms.Padding(4);
            this.grid_Jugador1.Name = "grid_Jugador1";
            this.grid_Jugador1.ReadOnly = true;
            this.grid_Jugador1.RowHeadersVisible = false;
            this.grid_Jugador1.RowTemplate.Height = 10;
            this.grid_Jugador1.Size = new System.Drawing.Size(912, 794);
            this.grid_Jugador1.TabIndex = 4;
            // 
            // txt_nombreJugador2m
            // 
            this.txt_nombreJugador2m.Location = new System.Drawing.Point(375, 19);
            this.txt_nombreJugador2m.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombreJugador2m.Name = "txt_nombreJugador2m";
            this.txt_nombreJugador2m.Size = new System.Drawing.Size(132, 22);
            this.txt_nombreJugador2m.TabIndex = 3;
            // 
            // txt_nombreJugador1m
            // 
            this.txt_nombreJugador1m.Location = new System.Drawing.Point(109, 19);
            this.txt_nombreJugador1m.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombreJugador1m.Name = "txt_nombreJugador1m";
            this.txt_nombreJugador1m.Size = new System.Drawing.Size(132, 22);
            this.txt_nombreJugador1m.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jugador 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jugador 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 927);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}

