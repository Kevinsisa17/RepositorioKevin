
namespace CPresentacion
{
    partial class FrmConsultaPaciente
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
            this.btnPacienteNo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPacientesMas = new System.Windows.Forms.Button();
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.btnIngresadoJunio = new System.Windows.Forms.Button();
            this.btnHabitacion101 = new System.Windows.Forms.Button();
            this.lblConsultas = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPacienteNo
            // 
            this.btnPacienteNo.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.btnPacienteNo.Location = new System.Drawing.Point(159, 25);
            this.btnPacienteNo.Name = "btnPacienteNo";
            this.btnPacienteNo.Size = new System.Drawing.Size(115, 60);
            this.btnPacienteNo.TabIndex = 21;
            this.btnPacienteNo.Text = "Pacientes no ingresados";
            this.btnPacienteNo.UseVisualStyleBackColor = true;
            this.btnPacienteNo.Click += new System.EventHandler(this.btnPacienteNo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(194)))));
            this.panel1.Controls.Add(this.btnPacientesMas);
            this.panel1.Controls.Add(this.dgvConsultas);
            this.panel1.Controls.Add(this.btnIngresadoJunio);
            this.panel1.Controls.Add(this.btnHabitacion101);
            this.panel1.Controls.Add(this.btnPacienteNo);
            this.panel1.Location = new System.Drawing.Point(27, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 294);
            this.panel1.TabIndex = 22;
            // 
            // btnPacientesMas
            // 
            this.btnPacientesMas.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.btnPacientesMas.Location = new System.Drawing.Point(23, 25);
            this.btnPacientesMas.Name = "btnPacientesMas";
            this.btnPacientesMas.Size = new System.Drawing.Size(115, 60);
            this.btnPacientesMas.TabIndex = 25;
            this.btnPacientesMas.Text = "Pacientes más ingresados en 2010";
            this.btnPacientesMas.UseVisualStyleBackColor = true;
            this.btnPacientesMas.Click += new System.EventHandler(this.btnPacientesMas_Click);
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Location = new System.Drawing.Point(23, 101);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.Size = new System.Drawing.Size(586, 169);
            this.dgvConsultas.TabIndex = 24;
            // 
            // btnIngresadoJunio
            // 
            this.btnIngresadoJunio.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.btnIngresadoJunio.Location = new System.Drawing.Point(472, 25);
            this.btnIngresadoJunio.Name = "btnIngresadoJunio";
            this.btnIngresadoJunio.Size = new System.Drawing.Size(115, 60);
            this.btnIngresadoJunio.TabIndex = 23;
            this.btnIngresadoJunio.Text = "Pacientes ingresados Junio 2011";
            this.btnIngresadoJunio.UseVisualStyleBackColor = true;
            this.btnIngresadoJunio.Click += new System.EventHandler(this.btnIngresadoJunio_Click);
            // 
            // btnHabitacion101
            // 
            this.btnHabitacion101.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.btnHabitacion101.Location = new System.Drawing.Point(307, 25);
            this.btnHabitacion101.Name = "btnHabitacion101";
            this.btnHabitacion101.Size = new System.Drawing.Size(126, 60);
            this.btnHabitacion101.TabIndex = 22;
            this.btnHabitacion101.Text = "Pacientes de la habitación 101";
            this.btnHabitacion101.UseVisualStyleBackColor = true;
            this.btnHabitacion101.Click += new System.EventHandler(this.btnHabitacion101_Click);
            // 
            // lblConsultas
            // 
            this.lblConsultas.AutoSize = true;
            this.lblConsultas.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultas.Location = new System.Drawing.Point(279, 19);
            this.lblConsultas.Name = "lblConsultas";
            this.lblConsultas.Size = new System.Drawing.Size(108, 23);
            this.lblConsultas.TabIndex = 23;
            this.lblConsultas.Text = "Consultas";
            // 
            // FrmConsultaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 380);
            this.Controls.Add(this.lblConsultas);
            this.Controls.Add(this.panel1);
            this.Name = "FrmConsultaPaciente";
            this.Text = "FrmConsultaPaciente";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPacienteNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblConsultas;
        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.Button btnIngresadoJunio;
        private System.Windows.Forms.Button btnHabitacion101;
        private System.Windows.Forms.Button btnPacientesMas;
    }
}