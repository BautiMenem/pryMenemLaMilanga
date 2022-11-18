namespace pryMenemLaMilanga
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.dtvMozos = new System.Windows.Forms.DataGridView();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnTotales = new System.Windows.Forms.Button();
            this.txtBebidasSinAlc = new System.Windows.Forms.TextBox();
            this.txtComidas = new System.Windows.Forms.TextBox();
            this.txtBebidasConAlc = new System.Windows.Forms.TextBox();
            this.txtPostres = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblBebidasSinAlc = new System.Windows.Forms.Label();
            this.lblbebidasConAlc = new System.Windows.Forms.Label();
            this.lblComidas = new System.Windows.Forms.Label();
            this.lblPostres = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnMozo = new System.Windows.Forms.Button();
            this.txtMozoDelDia = new System.Windows.Forms.TextBox();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtvMozos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvMozos
            // 
            this.dtvMozos.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtvMozos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvMozos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Postres});
            this.dtvMozos.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtvMozos.Location = new System.Drawing.Point(12, 23);
            this.dtvMozos.Name = "dtvMozos";
            this.dtvMozos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtvMozos.Size = new System.Drawing.Size(542, 175);
            this.dtvMozos.TabIndex = 0;
            this.dtvMozos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dtvMozos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtvMozos_KeyPress);
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(457, 204);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(97, 24);
            this.btnValidar.TabIndex = 3;
            this.btnValidar.Text = "Validar Datos";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(457, 339);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 19);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnTotales
            // 
            this.btnTotales.Location = new System.Drawing.Point(12, 301);
            this.btnTotales.Name = "btnTotales";
            this.btnTotales.Size = new System.Drawing.Size(92, 19);
            this.btnTotales.TabIndex = 5;
            this.btnTotales.Text = "Totales";
            this.btnTotales.UseVisualStyleBackColor = true;
            this.btnTotales.Click += new System.EventHandler(this.btnTotales_Click);
            // 
            // txtBebidasSinAlc
            // 
            this.txtBebidasSinAlc.Location = new System.Drawing.Point(12, 339);
            this.txtBebidasSinAlc.Name = "txtBebidasSinAlc";
            this.txtBebidasSinAlc.Size = new System.Drawing.Size(60, 20);
            this.txtBebidasSinAlc.TabIndex = 6;
            // 
            // txtComidas
            // 
            this.txtComidas.Location = new System.Drawing.Point(189, 339);
            this.txtComidas.Name = "txtComidas";
            this.txtComidas.Size = new System.Drawing.Size(60, 20);
            this.txtComidas.TabIndex = 7;
            this.txtComidas.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtBebidasConAlc
            // 
            this.txtBebidasConAlc.Location = new System.Drawing.Point(102, 339);
            this.txtBebidasConAlc.Name = "txtBebidasConAlc";
            this.txtBebidasConAlc.Size = new System.Drawing.Size(60, 20);
            this.txtBebidasConAlc.TabIndex = 7;
            // 
            // txtPostres
            // 
            this.txtPostres.Location = new System.Drawing.Point(273, 339);
            this.txtPostres.Name = "txtPostres";
            this.txtPostres.Size = new System.Drawing.Size(60, 20);
            this.txtPostres.TabIndex = 8;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(355, 339);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(60, 20);
            this.txtTotal.TabIndex = 9;
            // 
            // lblBebidasSinAlc
            // 
            this.lblBebidasSinAlc.AutoSize = true;
            this.lblBebidasSinAlc.Location = new System.Drawing.Point(9, 323);
            this.lblBebidasSinAlc.Name = "lblBebidasSinAlc";
            this.lblBebidasSinAlc.Size = new System.Drawing.Size(76, 13);
            this.lblBebidasSinAlc.TabIndex = 10;
            this.lblBebidasSinAlc.Text = "Bebidas s/ Alc";
            // 
            // lblbebidasConAlc
            // 
            this.lblbebidasConAlc.AutoSize = true;
            this.lblbebidasConAlc.Location = new System.Drawing.Point(99, 323);
            this.lblbebidasConAlc.Name = "lblbebidasConAlc";
            this.lblbebidasConAlc.Size = new System.Drawing.Size(77, 13);
            this.lblbebidasConAlc.TabIndex = 11;
            this.lblbebidasConAlc.Text = "Bebidas c/ Alc";
            // 
            // lblComidas
            // 
            this.lblComidas.AutoSize = true;
            this.lblComidas.Location = new System.Drawing.Point(186, 323);
            this.lblComidas.Name = "lblComidas";
            this.lblComidas.Size = new System.Drawing.Size(47, 13);
            this.lblComidas.TabIndex = 12;
            this.lblComidas.Text = "Comidas";
            // 
            // lblPostres
            // 
            this.lblPostres.AutoSize = true;
            this.lblPostres.Location = new System.Drawing.Point(270, 323);
            this.lblPostres.Name = "lblPostres";
            this.lblPostres.Size = new System.Drawing.Size(42, 13);
            this.lblPostres.TabIndex = 13;
            this.lblPostres.Text = "Postres";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(352, 323);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Total";
            // 
            // btnMozo
            // 
            this.btnMozo.Location = new System.Drawing.Point(12, 207);
            this.btnMozo.Name = "btnMozo";
            this.btnMozo.Size = new System.Drawing.Size(92, 21);
            this.btnMozo.TabIndex = 15;
            this.btnMozo.Text = "Mozo del Día";
            this.btnMozo.UseVisualStyleBackColor = true;
            this.btnMozo.Click += new System.EventHandler(this.btnMozo_Click);
            // 
            // txtMozoDelDia
            // 
            this.txtMozoDelDia.Location = new System.Drawing.Point(110, 208);
            this.txtMozoDelDia.Name = "txtMozoDelDia";
            this.txtMozoDelDia.Size = new System.Drawing.Size(82, 20);
            this.txtMozoDelDia.TabIndex = 16;
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(242, 208);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(82, 20);
            this.txtMontoTotal.TabIndex = 17;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(199, 214);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(37, 13);
            this.lblMonto.TabIndex = 18;
            this.lblMonto.Text = "Monto";
            // 
            // Column1
            // 
            this.Column1.FillWeight = 4F;
            this.Column1.HeaderText = "Mozos";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Bebidas Sin Alcohol";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Bebidas Con Alcohol";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Comidas";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Postres
            // 
            this.Postres.HeaderText = "Postres";
            this.Postres.Name = "Postres";
            this.Postres.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(566, 371);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.txtMozoDelDia);
            this.Controls.Add(this.btnMozo);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPostres);
            this.Controls.Add(this.lblComidas);
            this.Controls.Add(this.lblbebidasConAlc);
            this.Controls.Add(this.lblBebidasSinAlc);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtPostres);
            this.Controls.Add(this.txtBebidasConAlc);
            this.Controls.Add(this.txtComidas);
            this.Controls.Add(this.txtBebidasSinAlc);
            this.Controls.Add(this.btnTotales);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.dtvMozos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "La Milanga";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvMozos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvMozos;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnTotales;
        private System.Windows.Forms.TextBox txtBebidasSinAlc;
        private System.Windows.Forms.TextBox txtComidas;
        private System.Windows.Forms.TextBox txtBebidasConAlc;
        private System.Windows.Forms.TextBox txtPostres;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblBebidasSinAlc;
        private System.Windows.Forms.Label lblbebidasConAlc;
        private System.Windows.Forms.Label lblComidas;
        private System.Windows.Forms.Label lblPostres;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnMozo;
        private System.Windows.Forms.TextBox txtMozoDelDia;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postres;
    }
}

