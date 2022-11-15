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
            this.dtvMozos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvMozos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvMozos
            // 
            this.dtvMozos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvMozos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Postres});
            this.dtvMozos.Location = new System.Drawing.Point(24, 23);
            this.dtvMozos.Name = "dtvMozos";
            this.dtvMozos.Size = new System.Drawing.Size(542, 160);
            this.dtvMozos.TabIndex = 0;
            this.dtvMozos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 4F;
            this.Column1.HeaderText = "Mozos";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Bebidas Sin Alcohol";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Bebidas Con Alcohol";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Comidas";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Postres
            // 
            this.Postres.HeaderText = "Postres";
            this.Postres.Name = "Postres";
            this.Postres.ReadOnly = true;
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(469, 199);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(97, 24);
            this.btnValidar.TabIndex = 3;
            this.btnValidar.Text = "Validar Datos";
            this.btnValidar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(24, 266);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 19);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(383, 266);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(75, 19);
            this.btnTotal.TabIndex = 5;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(464, 260);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(18, 25);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = ".";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 310);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.dtvMozos);
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
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postres;
    }
}

