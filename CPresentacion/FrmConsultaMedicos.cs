using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CConsultas_Solicitadas;

namespace CPresentacion
{
    public partial class FrmConsultaMedicos : Form
    {
        Consulta_1 consulta1 = new Consulta_1();
        public FrmConsultaMedicos()
        {
            InitializeComponent();
        }

        private void FrmConsultaMedicos_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultarMedico_Click(object sender, EventArgs e)
        {
            dgvPrimeraConsulta.DataSource = consulta1.Primera_Consulta();
           
        }
    }
}
