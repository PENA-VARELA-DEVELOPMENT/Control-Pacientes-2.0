namespace Control_Pacientes_Clinica_Machado.FormulariosMantenimiento
{
    partial class HabilitarPaciente
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
            this.label1 = new System.Windows.Forms.Label();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.inhabilitadoPicBox = new System.Windows.Forms.PictureBox();
            this.habilitadoPicBox = new System.Windows.Forms.PictureBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inhabilitadoPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habilitadoPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(247, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // nombreTxt
            // 
            this.nombreTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nombreTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.nombreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTxt.Location = new System.Drawing.Point(364, 139);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(254, 26);
            this.nombreTxt.TabIndex = 9;
            // 
            // inhabilitadoPicBox
            // 
            this.inhabilitadoPicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.inhabilitadoPicBox.Image = global::Control_Pacientes_Clinica_Machado.Properties.Resources.inhabilitadoP;
            this.inhabilitadoPicBox.Location = new System.Drawing.Point(755, 381);
            this.inhabilitadoPicBox.Name = "inhabilitadoPicBox";
            this.inhabilitadoPicBox.Size = new System.Drawing.Size(80, 39);
            this.inhabilitadoPicBox.TabIndex = 13;
            this.inhabilitadoPicBox.TabStop = false;
            // 
            // habilitadoPicBox
            // 
            this.habilitadoPicBox.Image = global::Control_Pacientes_Clinica_Machado.Properties.Resources.habilitadoP;
            this.habilitadoPicBox.Location = new System.Drawing.Point(755, 381);
            this.habilitadoPicBox.Name = "habilitadoPicBox";
            this.habilitadoPicBox.Size = new System.Drawing.Size(80, 39);
            this.habilitadoPicBox.TabIndex = 12;
            this.habilitadoPicBox.TabStop = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Image = global::Control_Pacientes_Clinica_Machado.Properties.Resources.error;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(462, 381);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(185, 39);
            this.BtnCancelar.TabIndex = 11;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BtnAceptar.FlatAppearance.BorderSize = 0;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.Color.White;
            this.BtnAceptar.Image = global::Control_Pacientes_Clinica_Machado.Properties.Resources.ok;
            this.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAceptar.Location = new System.Drawing.Point(256, 381);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(185, 39);
            this.BtnAceptar.TabIndex = 10;
            this.BtnAceptar.Text = "Habilitar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // HabilitarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(867, 443);
            this.Controls.Add(this.inhabilitadoPicBox);
            this.Controls.Add(this.habilitadoPicBox);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombreTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HabilitarPaciente";
            this.Text = "HabilitarPaciente";
            ((System.ComponentModel.ISupportInitialize)(this.inhabilitadoPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habilitadoPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.PictureBox habilitadoPicBox;
        private System.Windows.Forms.PictureBox inhabilitadoPicBox;
    }
}