namespace Control_Pacientes_Clinica_Machado
{
    partial class NuevaCita
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
            this.label3 = new System.Windows.Forms.Label();
            this.pacienteTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.doctorTxt = new System.Windows.Forms.TextBox();
            this.dateTimeDTP = new System.Windows.Forms.DateTimePicker();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAgregarCita = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha y hora";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Paciente";
            // 
            // pacienteTxt
            // 
            this.pacienteTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pacienteTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.pacienteTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pacienteTxt.Location = new System.Drawing.Point(346, 180);
            this.pacienteTxt.Name = "pacienteTxt";
            this.pacienteTxt.Size = new System.Drawing.Size(305, 26);
            this.pacienteTxt.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(204, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Doctor";
            // 
            // doctorTxt
            // 
            this.doctorTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.doctorTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.doctorTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorTxt.Location = new System.Drawing.Point(346, 224);
            this.doctorTxt.Name = "doctorTxt";
            this.doctorTxt.Size = new System.Drawing.Size(305, 26);
            this.doctorTxt.TabIndex = 3;
            // 
            // dateTimeDTP
            // 
            this.dateTimeDTP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimeDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDTP.Location = new System.Drawing.Point(346, 136);
            this.dateTimeDTP.Name = "dateTimeDTP";
            this.dateTimeDTP.Size = new System.Drawing.Size(305, 26);
            this.dateTimeDTP.TabIndex = 1;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Image = global::Control_Pacientes_Clinica_Machado.Properties.Resources.error;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(470, 355);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(154, 39);
            this.BtnCancelar.TabIndex = 72;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAgregarCita
            // 
            this.BtnAgregarCita.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAgregarCita.FlatAppearance.BorderSize = 0;
            this.BtnAgregarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarCita.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarCita.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarCita.Image = global::Control_Pacientes_Clinica_Machado.Properties.Resources.ok;
            this.BtnAgregarCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarCita.Location = new System.Drawing.Point(240, 355);
            this.BtnAgregarCita.Name = "BtnAgregarCita";
            this.BtnAgregarCita.Size = new System.Drawing.Size(189, 39);
            this.BtnAgregarCita.TabIndex = 71;
            this.BtnAgregarCita.Text = "AGREGAR CITA";
            this.BtnAgregarCita.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregarCita.UseVisualStyleBackColor = true;
            // 
            // NuevaCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(867, 443);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAgregarCita);
            this.Controls.Add(this.dateTimeDTP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.doctorTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pacienteTxt);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevaCita";
            this.Text = "NuevaCita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pacienteTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox doctorTxt;
        private System.Windows.Forms.DateTimePicker dateTimeDTP;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAgregarCita;
    }
}