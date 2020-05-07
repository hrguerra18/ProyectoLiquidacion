namespace LiquidacionGUI
{
    partial class ConsultoLiquidacionFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tabla = new System.Windows.Forms.DataGridView();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.CmbFiltrarTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTotalLiquidaciones = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtLiquidacionesContributivo = new System.Windows.Forms.TextBox();
            this.TxtLiquidacionesSubsidiado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTotalCuotaModeradora = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtTotalCuotaModeradoraContributivo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtTotalCuotaModeradoraSubsidiado = new System.Windows.Forms.TextBox();
            this.BtnFiltrarFecha = new System.Windows.Forms.Button();
            this.dtFiltroFecha = new System.Windows.Forms.DateTimePicker();
            this.TxtFiltrarCoincidencia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabla
            // 
            this.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla.Location = new System.Drawing.Point(25, 85);
            this.Tabla.Name = "Tabla";
            this.Tabla.Size = new System.Drawing.Size(615, 225);
            this.Tabla.TabIndex = 0;
            this.Tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tabla_CellContentClick);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(345, 27);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(75, 51);
            this.BtnConsultar.TabIndex = 1;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // CmbFiltrarTipo
            // 
            this.CmbFiltrarTipo.FormattingEnabled = true;
            this.CmbFiltrarTipo.Items.AddRange(new object[] {
            "Todos",
            "S",
            "C"});
            this.CmbFiltrarTipo.Location = new System.Drawing.Point(205, 43);
            this.CmbFiltrarTipo.Name = "CmbFiltrarTipo";
            this.CmbFiltrarTipo.Size = new System.Drawing.Size(121, 21);
            this.CmbFiltrarTipo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Liquidaciones";
            // 
            // TxtTotalLiquidaciones
            // 
            this.TxtTotalLiquidaciones.Location = new System.Drawing.Point(137, 347);
            this.TxtTotalLiquidaciones.Name = "TxtTotalLiquidaciones";
            this.TxtTotalLiquidaciones.Size = new System.Drawing.Size(100, 20);
            this.TxtTotalLiquidaciones.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Liquidaciones Contributivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(586, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Liquidaciones Subsidiado";
            // 
            // TxtLiquidacionesContributivo
            // 
            this.TxtLiquidacionesContributivo.Location = new System.Drawing.Point(426, 351);
            this.TxtLiquidacionesContributivo.Name = "TxtLiquidacionesContributivo";
            this.TxtLiquidacionesContributivo.Size = new System.Drawing.Size(100, 20);
            this.TxtLiquidacionesContributivo.TabIndex = 7;
            // 
            // TxtLiquidacionesSubsidiado
            // 
            this.TxtLiquidacionesSubsidiado.Location = new System.Drawing.Point(719, 351);
            this.TxtLiquidacionesSubsidiado.Name = "TxtLiquidacionesSubsidiado";
            this.TxtLiquidacionesSubsidiado.Size = new System.Drawing.Size(100, 20);
            this.TxtLiquidacionesSubsidiado.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Filtro de cantidad de liquidaciones";
            // 
            // TxtTotalCuotaModeradora
            // 
            this.TxtTotalCuotaModeradora.Location = new System.Drawing.Point(137, 384);
            this.TxtTotalCuotaModeradora.Name = "TxtTotalCuotaModeradora";
            this.TxtTotalCuotaModeradora.Size = new System.Drawing.Size(100, 20);
            this.TxtTotalCuotaModeradora.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total Cuota Moderadora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total Cuota Moderadora Contributivo";
            // 
            // TxtTotalCuotaModeradoraContributivo
            // 
            this.TxtTotalCuotaModeradoraContributivo.Location = new System.Drawing.Point(426, 384);
            this.TxtTotalCuotaModeradoraContributivo.Name = "TxtTotalCuotaModeradoraContributivo";
            this.TxtTotalCuotaModeradoraContributivo.Size = new System.Drawing.Size(100, 20);
            this.TxtTotalCuotaModeradoraContributivo.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(536, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total Cuota Moderadora Subsidiado";
            // 
            // TxtTotalCuotaModeradoraSubsidiado
            // 
            this.TxtTotalCuotaModeradoraSubsidiado.Location = new System.Drawing.Point(719, 384);
            this.TxtTotalCuotaModeradoraSubsidiado.Name = "TxtTotalCuotaModeradoraSubsidiado";
            this.TxtTotalCuotaModeradoraSubsidiado.Size = new System.Drawing.Size(100, 20);
            this.TxtTotalCuotaModeradoraSubsidiado.TabIndex = 15;
            // 
            // BtnFiltrarFecha
            // 
            this.BtnFiltrarFecha.Location = new System.Drawing.Point(695, 111);
            this.BtnFiltrarFecha.Name = "BtnFiltrarFecha";
            this.BtnFiltrarFecha.Size = new System.Drawing.Size(124, 36);
            this.BtnFiltrarFecha.TabIndex = 17;
            this.BtnFiltrarFecha.Text = "Filtrar Fecha";
            this.BtnFiltrarFecha.UseVisualStyleBackColor = true;
            this.BtnFiltrarFecha.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtFiltroFecha
            // 
            this.dtFiltroFecha.Location = new System.Drawing.Point(655, 85);
            this.dtFiltroFecha.Name = "dtFiltroFecha";
            this.dtFiltroFecha.Size = new System.Drawing.Size(200, 20);
            this.dtFiltroFecha.TabIndex = 16;
            // 
            // TxtFiltrarCoincidencia
            // 
            this.TxtFiltrarCoincidencia.Location = new System.Drawing.Point(695, 228);
            this.TxtFiltrarCoincidencia.Name = "TxtFiltrarCoincidencia";
            this.TxtFiltrarCoincidencia.Size = new System.Drawing.Size(124, 20);
            this.TxtFiltrarCoincidencia.TabIndex = 18;
            this.TxtFiltrarCoincidencia.TextChanged += new System.EventHandler(this.TxtFiltrarCoincidencia_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(692, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Filtrar por Coincidencia";
            // 
            // ConsultoLiquidacionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 448);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtFiltrarCoincidencia);
            this.Controls.Add(this.BtnFiltrarFecha);
            this.Controls.Add(this.dtFiltroFecha);
            this.Controls.Add(this.TxtTotalCuotaModeradoraSubsidiado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtTotalCuotaModeradoraContributivo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtTotalCuotaModeradora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtLiquidacionesSubsidiado);
            this.Controls.Add(this.TxtLiquidacionesContributivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtTotalLiquidaciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbFiltrarTipo);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.Tabla);
            this.Name = "ConsultoLiquidacionFrm";
            this.Text = "ConsultoLiquidacionFrm";
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Tabla;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.ComboBox CmbFiltrarTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTotalLiquidaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtLiquidacionesContributivo;
        private System.Windows.Forms.TextBox TxtLiquidacionesSubsidiado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtTotalCuotaModeradora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtTotalCuotaModeradoraContributivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtTotalCuotaModeradoraSubsidiado;
        private System.Windows.Forms.Button BtnFiltrarFecha;
        private System.Windows.Forms.DateTimePicker dtFiltroFecha;
        private System.Windows.Forms.TextBox TxtFiltrarCoincidencia;
        private System.Windows.Forms.Label label8;
    }
}