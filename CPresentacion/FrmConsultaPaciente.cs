using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CDatos;
using CConsultas_Solicitadas;

namespace CPresentacion
{
    public partial class FrmConsultaPaciente : Form
    {
        Consulta_2 c2 = new Consulta_2();
        Consulta_3 c3 = new Consulta_3();
        Consulta_4 c4 = new Consulta_4();
        Consulta_5 c5 = new Consulta_5();
        public FrmConsultaPaciente()
        {
            InitializeComponent();
        }
        private void btnPacientesMas_Click(object sender, EventArgs e)
        {
            dgvConsultas.DataSource = c2.Segunda_Consulta();
        }

        private void btnPacienteNo_Click(object sender, EventArgs e)
        {
            dgvConsultas.DataSource = c3.Tercera_Consulta();
        }

        private void btnHabitacion101_Click(object sender, EventArgs e)
        {
            dgvConsultas.DataSource = c4.Cuarta_Consulta();
        }

        private void btnIngresadoJunio_Click(object sender, EventArgs e)
        {
            dgvConsultas.DataSource = c5.Quinta_Consulta();
        }

    
    }
}
