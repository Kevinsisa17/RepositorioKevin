
namespace CPresentacion
{
    partial class FrmIngresoMedico
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
            this.btnGuardarMedico = new System.Windows.Forms.Button();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.mtbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.lblMedico = new System.Windows.Forms.Label();
            this.btnEditarMedico = new System.Windows.Forms.Button();
            this.btnEliminarMedico = new System.Windows.Forms.Button();
            this.dgvMedico = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(194)))));
            this.panel1.Controls.Add(this.btnGuardarMedico);
            this.panel1.Controls.Add(this.lblTelefono);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.lblApellido);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.mtbTelefono);
            this.panel1.Location = new System.Drawing.Point(63, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 134);
            this.panel1.TabIndex = 21;
            // 
            // btnGuardarMedico
            // 
            this.btnGuardarMedico.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardarMedico.Location = new System.Drawing.Point(287, 48);
            this.btnGuardarMedico.Name = "btnGuardarMedico";
            this.btnGuardarMedico.Size = new System.Drawing.Size(86, 33);
            this.btnGuardarMedico.TabIndex = 20;
            this.btnGuardarMedico.Text = "Guardar";
            this.btnGuardarMedico.UseVisualStyleBackColor = true;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(18, 88);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(80, 18);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(18, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 18);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(161, 55);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 17;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(18, 57);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(77, 18);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(161, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 16;
            // 
            // mtbTelefono
            // 
            this.mtbTelefono.Location = new System.Drawing.Point(161, 89);
            this.mtbTelefono.Mask = "\\0\\999999999";
            this.mtbTelefono.Name = "mtbTelefono";
            this.mtbTelefono.Size = new System.Drawing.Size(100, 20);
            this.mtbTelefono.TabIndex = 11;
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedico.Location = new System.Drawing.Point(153, 18);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(200, 23);
            this.lblMedico.TabIndex = 22;
            this.lblMedico.Text = "Registro de médico";
            // 
            // btnEditarMedico
            // 
            this.btnEditarMedico.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditarMedico.Location = new System.Drawing.Point(403, 223);
            this.btnEditarMedico.Name = "btnEditarMedico";
            this.btnEditarMedico.Size = new System.Drawing.Size(86, 33);
            this.btnEditarMedico.TabIndex = 24;
            this.btnEditarMedico.Text = "Editar";
            this.btnEditarMedico.UseVisualStyleBackColor = true;
            // 
            // btnEliminarMedico
            // 
            this.btnEliminarMedico.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminarMedico.Location = new System.Drawing.Point(403, 281);
            this.btnEliminarMedico.Name = "btnEliminarMedico";
            this.btnEliminarMedico.Size = new System.Drawing.Size(86, 33);
            this.btnEliminarMedico.TabIndex = 25;
            this.btnEliminarMedico.Text = "Eliminar";
            this.btnEliminarMedico.UseVisualStyleBackColor = true;
            // 
            // dgvMedico
            // 
            this.dgvMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedico.Location = new System.Drawing.Point(22, 195);
            this.dgvMedico.Name = "dgvMedico";
            this.dgvMedico.Size = new System.Drawing.Size(360, 182);
            this.dgvMedico.TabIndex = 26;
            // 
            // FrmIngresoMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 398);
            this.Controls.Add(this.dgvMedico);
            this.Controls.Add(this.btnEliminarMedico);
            this.Controls.Add(this.btnEditarMedico);
            this.Controls.Add(this.lblMedico);
            this.Controls.Add(this.panel1);
            this.Name = "FrmIngresoMedico";
            this.Text = "FrmIngresoMedico";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardarMedico;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.MaskedTextBox mtbTelefono;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.Button btnEditarMedico;
        private System.Windows.Forms.Button btnEliminarMedico;
        private System.Windows.Forms.DataGridView dgvMedico;
    }
}