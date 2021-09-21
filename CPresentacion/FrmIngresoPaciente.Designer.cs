
namespace CPresentacion
{
    partial class FrmIngresoPaciente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCama = new System.Windows.Forms.TextBox();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.mtbHabitacion = new System.Windows.Forms.MaskedTextBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblNHabitacion = new System.Windows.Forms.Label();
            this.lblCama = new System.Windows.Forms.Label();
            this.lblTituloIngreso = new System.Windows.Forms.Label();
            this.lblBusca = new System.Windows.Forms.Label();
            this.blbNombrePaciente = new System.Windows.Forms.Label();
            this.txtBuscarPaciente = new System.Windows.Forms.TextBox();
            this.dgvBuscaPaciente = new System.Windows.Forms.DataGridView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(194)))));
            this.panel1.Controls.Add(this.blbNombrePaciente);
            this.panel1.Controls.Add(this.txtCama);
            this.panel1.Controls.Add(this.lblPaciente);
            this.panel1.Controls.Add(this.mtbHabitacion);
            this.panel1.Controls.Add(this.dtpFechaIngreso);
            this.panel1.Controls.Add(this.lblFechaIngreso);
            this.panel1.Controls.Add(this.lblNHabitacion);
            this.panel1.Controls.Add(this.lblCama);
            this.panel1.Location = new System.Drawing.Point(41, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 145);
            this.panel1.TabIndex = 26;
            // 
            // txtCama
            // 
            this.txtCama.Location = new System.Drawing.Point(232, 111);
            this.txtCama.Name = "txtCama";
            this.txtCama.Size = new System.Drawing.Size(100, 20);
            this.txtCama.TabIndex = 19;
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblPaciente.ForeColor = System.Drawing.Color.White;
            this.lblPaciente.Location = new System.Drawing.Point(38, 10);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(79, 18);
            this.lblPaciente.TabIndex = 5;
            this.lblPaciente.Text = "Paciente:";
            // 
            // mtbHabitacion
            // 
            this.mtbHabitacion.Location = new System.Drawing.Point(232, 77);
            this.mtbHabitacion.Mask = "999";
            this.mtbHabitacion.Name = "mtbHabitacion";
            this.mtbHabitacion.Size = new System.Drawing.Size(100, 20);
            this.mtbHabitacion.TabIndex = 15;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(232, 42);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(128, 20);
            this.dtpFechaIngreso.TabIndex = 13;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblFechaIngreso.ForeColor = System.Drawing.Color.White;
            this.lblFechaIngreso.Location = new System.Drawing.Point(38, 44);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(140, 18);
            this.lblFechaIngreso.TabIndex = 7;
            this.lblFechaIngreso.Text = "Fecha de ingreso:";
            // 
            // lblNHabitacion
            // 
            this.lblNHabitacion.AutoSize = true;
            this.lblNHabitacion.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblNHabitacion.ForeColor = System.Drawing.Color.White;
            this.lblNHabitacion.Location = new System.Drawing.Point(38, 76);
            this.lblNHabitacion.Name = "lblNHabitacion";
            this.lblNHabitacion.Size = new System.Drawing.Size(142, 18);
            this.lblNHabitacion.TabIndex = 8;
            this.lblNHabitacion.Text = "Nº de habitación:";
            // 
            // lblCama
            // 
            this.lblCama.AutoSize = true;
            this.lblCama.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblCama.ForeColor = System.Drawing.Color.White;
            this.lblCama.Location = new System.Drawing.Point(38, 110);
            this.lblCama.Name = "lblCama";
            this.lblCama.Size = new System.Drawing.Size(58, 18);
            this.lblCama.TabIndex = 9;
            this.lblCama.Text = "Cama:";
            // 
            // lblTituloIngreso
            // 
            this.lblTituloIngreso.AutoSize = true;
            this.lblTituloIngreso.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloIngreso.Location = new System.Drawing.Point(104, 24);
            this.lblTituloIngreso.Name = "lblTituloIngreso";
            this.lblTituloIngreso.Size = new System.Drawing.Size(326, 23);
            this.lblTituloIngreso.TabIndex = 27;
            this.lblTituloIngreso.Text = "Ingreso de pacientes al Hospital";
            // 
            // lblBusca
            // 
            this.lblBusca.AutoSize = true;
            this.lblBusca.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblBusca.ForeColor = System.Drawing.Color.Black;
            this.lblBusca.Location = new System.Drawing.Point(38, 73);
            this.lblBusca.Name = "lblBusca";
            this.lblBusca.Size = new System.Drawing.Size(79, 18);
            this.lblBusca.TabIndex = 28;
            this.lblBusca.Text = "Paciente:";
            // 
            // blbNombrePaciente
            // 
            this.blbNombrePaciente.AutoSize = true;
            this.blbNombrePaciente.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold);
            this.blbNombrePaciente.ForeColor = System.Drawing.Color.White;
            this.blbNombrePaciente.Location = new System.Drawing.Point(229, 10);
            this.blbNombrePaciente.Name = "blbNombrePaciente";
            this.blbNombrePaciente.Size = new System.Drawing.Size(0, 18);
            this.blbNombrePaciente.TabIndex = 20;
            // 
            // txtBuscarPaciente
            // 
            this.txtBuscarPaciente.Location = new System.Drawing.Point(174, 71);
            this.txtBuscarPaciente.Name = "txtBuscarPaciente";
            this.txtBuscarPaciente.Size = new System.Drawing.Size(316, 20);
            this.txtBuscarPaciente.TabIndex = 29;
            // 
            // dgvBuscaPaciente
            // 
            this.dgvBuscaPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscaPaciente.Location = new System.Drawing.Point(41, 101);
            this.dgvBuscaPaciente.Name = "dgvBuscaPaciente";
            this.dgvBuscaPaciente.Size = new System.Drawing.Size(466, 92);
            this.dgvBuscaPaciente.TabIndex = 30;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.Location = new System.Drawing.Point(450, 263);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(86, 50);
            this.btnRegistrar.TabIndex = 31;
            this.btnRegistrar.Text = "Registrar Ingreso";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // FrmIngresoPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 410);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgvBuscaPaciente);
            this.Controls.Add(this.txtBuscarPaciente);
            this.Controls.Add(this.lblBusca);
            this.Controls.Add(this.lblTituloIngreso);
            this.Controls.Add(this.panel1);
            this.Name = "FrmIngresoPaciente";
            this.Text = "FrmIngresoPaciente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCama;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.MaskedTextBox mtbHabitacion;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblNHabitacion;
        private System.Windows.Forms.Label lblCama;
        private System.Windows.Forms.Label lblTituloIngreso;
        private System.Windows.Forms.Label blbNombrePaciente;
        private System.Windows.Forms.Label lblBusca;
        private System.Windows.Forms.TextBox txtBuscarPaciente;
        private System.Windows.Forms.DataGridView dgvBuscaPaciente;
        private System.Windows.Forms.Button btnRegistrar;
    }
}