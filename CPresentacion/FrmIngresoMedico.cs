using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNegocio;
using CDatos;

namespace CPresentacion
{
    public partial class FrmIngresoMedico : Form
    {
        private CN_Doctor CNdoc = new CN_Doctor();
        private Medicos CDdoc = new Medicos();
        private Especialidades CDespecialidades = new Especialidades();
        private CN_Medico_Especialidad medi_esp = new CN_Medico_Especialidad();
        private CN_Especialidad espe = new CN_Especialidad();
        public FrmIngresoMedico()
        {
            InitializeComponent();
        }
        private void FrmIngresoMedico_Load(object sender, EventArgs e)
        {
            cargardatos();
            cargarespecialidades();
            cbEspecialidades.SelectedIndex = -1;
            cbEspecialidades.Enabled = false;
            bnespecialidad.Enabled = false;
        }

        private void dgvMedico_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnGuardarMedico.Enabled = false;
            int aux2;
            aux2 = int.Parse(dgvMedico.CurrentRow.Cells[0].Value.ToString());
            CDdoc = CNdoc.buscar_medico(aux2);
            cargardatos(CDdoc.Nombre, CDdoc.Apellidos, CDdoc.Telefono);
        }
        private void cargardatos(string nombre, string apellido, string telefono)
        {
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            mtbTelefono.Text = telefono;
        }
        private void btnEditarMedico_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtApellido.Text != "" && mtbTelefono.Text != "")
            {
                CDdoc = (Medicos)dgvMedico.CurrentRow.DataBoundItem;
                CNdoc.editar_medico(CDdoc, txtNombre.Text, txtApellido.Text, mtbTelefono.Text);
                cargardatos();
                btnGuardarMedico.Enabled = true;
                limpiar();
            }
            else
            {
                MessageBox.Show("Llene los campos!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void cargardatos()
        {
            dgvMedico.DataSource = CNdoc.desplegar_registro_medicos();
        }
        private void cargarespecialidades()
        {
            cbEspecialidades.DataSource = espe.desplegar_especialidades();
        }

        private void btnEliminarMedico_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta apunto de eliminar al médico" + dgvMedico.CurrentRow.Cells[1].Value.ToString() +" "+dgvMedico.CurrentRow.Cells[2].Value.ToString() + " ¿Desea continuar? ","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            CNdoc.eliminar_medico((Medicos)dgvMedico.CurrentRow.DataBoundItem);
            cargardatos();
        }
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
          ttEleccionEspecialidad.Show("Debe ingresar al médico para asignar una especialidad", cbEspecialidades, 2000);
        }
        private void btnGuardarMedico_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text!="" && txtApellido.Text!="" && mtbTelefono.Text != "")
            {
                CNdoc.crear_medico(txtNombre.Text,txtApellido.Text,mtbTelefono.Text);
                cargardatos();
                DialogResult res = MessageBox.Show("Ingreso Existoso ¿Desea ingresar una especialidad para el médico? ", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    cbEspecialidades.Enabled = true;
                }
                else
                {
                    limpiar();
                }
            }
            else
            {
                MessageBox.Show("Llene los campos!","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            mtbTelefono.Text = "";
        }
        public void ingresar_especialidad()
        {
            CDdoc = CNdoc.buscar_medico_(txtNombre.Text, txtApellido.Text, mtbTelefono.Text);
            if (cbEspecialidades.Text != "")
            {
                CDespecialidades = espe.buscar_especialidad(cbEspecialidades.Text);
                medi_esp.ingresar_especialidad_medico(CDdoc.MedicoId, CDespecialidades.EspecialidadId);
                MessageBox.Show("Ingresado Correctamente " + CDdoc.Nombre + " " + CDdoc.Apellidos + " " + " como " + CDespecialidades.Especialidad, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult res = MessageBox.Show(" Desea ingresar otra especialidad para el doctor "+CDdoc.Nombre+" "+CDdoc.Apellidos, "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    cbEspecialidades.Text = "";
                    if (cbEspecialidades.Text != "")
                    {
                        ingresar_especialidad();
                        
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar una especialidad nueva", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }   
                }
                else
                {
                    limpiar();
                    cbEspecialidades.Enabled = false;
                }

            }
            else
            {
                MessageBox.Show("Error", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void bnespecialidad_Click(object sender, EventArgs e)
        {
            ingresar_especialidad();
        }
        private void cbEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            bnespecialidad.Enabled = true;
        }
    }         
}
