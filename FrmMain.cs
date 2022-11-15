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
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
                   
        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
