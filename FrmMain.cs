using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMenemLaMilanga
{
    
   
    public partial class FrmMain : Form
    {

        public int[,] MatrizDatos = new int[5, 4];
        public int[] VectorDatos = new int[10];

        public FrmMain()
        {
            InitializeComponent();
        }

         
        private void FrmMain_Load(object sender, EventArgs e)
        {
            dtvMozos.Rows.Add("Julio");
            dtvMozos.Rows.Add("Estéban");
            dtvMozos.Rows.Add("Javier");
            dtvMozos.Rows.Add("Gonzalo");
            dtvMozos.Rows.Add("Andres");
            dtvMozos.Columns[0].ReadOnly = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            int i = 0;
            int f = 0;
            int c = 1;
            int cmat = 0;
            while (f <= 4)
            {
                while (c <= 4)
                {

                    if (dtvMozos.Rows[f].Cells[c].Value == null || dtvMozos.Rows[f].Cells[c].Value == "")
                    {
                        i++;
                    }
                    c++;
                }
                c = 1;
                f++;
            }

            if (i == 0)
            {

                btnMozo.Enabled = true;
                btnTotales.Enabled = true;

                f = 0;
                c = 1;

                while (f <= 4)
                {
                    while (c <= 4 && cmat <= MatrizDatos.GetLength(1))
                    {
                        MatrizDatos[f, cmat] = Convert.ToInt32(dtvMozos.Rows[f].Cells[c].Value);
                        c++;
                        cmat++;
                    }
                    c = 1;
                    cmat = 0;
                    f++;
                }
            }
            else
            {

                btnMozo.Enabled = false;
                btnTotales.Enabled = false;
                MessageBox.Show("Asegurese de ingresar valores numéricos.", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnMozo_Click(object sender, EventArgs e)
        {
            int c = 0;
            int f = 0;
            int Suma = 0;
            int Mayor = 0;
            int Posicion = 0;
            while (f < MatrizDatos.GetLength(0))
            {
                while (c < MatrizDatos.GetLength(1))
                {
                    Suma = Suma + MatrizDatos[f, c];
                    c++;
                }
                VectorDatos[f] = Suma;
                c = 0;
                f++;
                Suma = 0;
            }

            f = 0;
            Mayor = VectorDatos[0];
            while (f <= 4)
            {
                if (VectorDatos[f] >= Mayor)
                {
                    Mayor = VectorDatos[f];
                    Posicion = f;
                }
                f++;
            }

            if (Posicion == 0)
            {
                txtMozoDelDia.Text = "Julio";
                txtMontoTotal.Text = Mayor.ToString();
            }
            if (Posicion == 1)
            {
                txtMozoDelDia.Text = "Esteban";
                txtMontoTotal.Text = Mayor.ToString();
            }
            if (Posicion == 2)
            {
                txtMozoDelDia.Text = "Javier";
                txtMontoTotal.Text = Mayor.ToString();
            }
            if (Posicion == 3)
            {
                txtMozoDelDia.Text = "Gonzalo";
                txtMontoTotal.Text = Mayor.ToString();
            }
            if (Posicion == 4)
            {
                txtMozoDelDia.Text = "Andres";
                txtMontoTotal.Text = Mayor.ToString();
            }
        }

        private void btnTotales_Click(object sender, EventArgs e)
        {
            int f = 0;
            int c = 0;
            int i = 5;
            int Suma = 0;
            int Total = 0;

            while (c < MatrizDatos.GetLength(1) && i <= 9)
            {
                Suma = 0;
                while (f < MatrizDatos.GetLength(0))
                {
                    Suma = Suma + MatrizDatos[f, c];
                    f++;
                }
                VectorDatos[i] = Suma;
                Total = Total + Suma;
                f = 0;
                c++;
                i++;
            }

            VectorDatos[9] = Total;

            txtComidas.Text = Convert.ToString(VectorDatos[5]);
            txtBebidasSinAlc.Text = Convert.ToString(VectorDatos[6]);
            txtBebidasConAlc.Text = Convert.ToString(VectorDatos[7]);
            txtPostres.Text = Convert.ToString(VectorDatos[8]);
            txtTotal.Text = Convert.ToString(VectorDatos[9]);
        }

        private void dtvMozos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
