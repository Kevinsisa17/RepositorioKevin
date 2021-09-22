
namespace CPresentacion
{
    partial class FrmConsultaMedicos
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
            this.dgvPrimeraConsulta = new System.Windows.Forms.DataGridView();
            this.lblConsultas = new System.Windows.Forms.Label();
            this.btnConsultarMedico = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimeraConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(194)))));
            this.panel1.Controls.Add(this.dgvPrimeraConsulta);
            this.panel1.Location = new System.Drawing.Point(41, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 252);
            this.panel1.TabIndex = 0;
            // 
            // dgvPrimeraConsulta
            // 
            this.dgvPrimeraConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrimeraConsulta.Location = new System.Drawing.Point(25, 28);
            this.dgvPrimeraConsulta.Name = "dgvPrimeraConsulta";
            this.dgvPrimeraConsulta.Size = new System.Drawing.Size(500, 190);
            this.dgvPrimeraConsulta.TabIndex = 0;
            // 
            // lblConsultas
            // 
            this.lblConsultas.AutoSize = true;
            this.lblConsultas.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultas.Location = new System.Drawing.Point(47, 41);
            this.lblConsultas.Name = "lblConsultas";
            this.lblConsultas.Size = new System.Drawing.Size(377, 23);
            this.lblConsultas.TabIndex = 24;
            this.lblConsultas.Text = "Médicos con más de una especialidad";
            // 
            // btnConsultarMedico
            // 
            this.btnConsultarMedico.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultarMedico.Location = new System.Drawing.Point(439, 31);
            this.btnConsultarMedico.Name = "btnConsultarMedico";
            this.btnConsultarMedico.Size = new System.Drawing.Size(110, 48);
            this.btnConsultarMedico.TabIndex = 25;
            this.btnConsultarMedico.Text = "Consultar";
            this.btnConsultarMedico.UseVisualStyleBackColor = true;
            this.btnConsultarMedico.Click += new System.EventHandler(this.btnConsultarMedico_Click);
            // 
            // FrmConsultaMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 371);
            this.Controls.Add(this.btnConsultarMedico);
            this.Controls.Add(this.lblConsultas);
            this.Controls.Add(this.panel1);
            this.Name = "FrmConsultaMedicos";
            this.Text = "FrmConsultaMedicos";
            this.Load += new System.EventHandler(this.FrmConsultaMedicos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimeraConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblConsultas;
        private System.Windows.Forms.DataGridView dgvPrimeraConsulta;
        private System.Windows.Forms.Button btnConsultarMedico;
    }
}