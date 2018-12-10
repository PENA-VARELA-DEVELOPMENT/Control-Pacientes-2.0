namespace Control_Pacientes_Clinica_Machado.FormulariosDoctores
{
    partial class Doctores
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
            this.PanelCrudDoctor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nuevaDoctorBtn = new System.Windows.Forms.Button();
            this.buscarDoctorBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(50)))), ((int)(((byte)(129)))));
            this.label1.Location = new System.Drawing.Point(407, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Doctores";
            // 
            // PanelCrudDoctor
            // 
            this.PanelCrudDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelCrudDoctor.Location = new System.Drawing.Point(34, 135);
            this.PanelCrudDoctor.Name = "PanelCrudDoctor";
            this.PanelCrudDoctor.Size = new System.Drawing.Size(867, 443);
            this.PanelCrudDoctor.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::Control_Pacientes_Clinica_Machado.Properties.Resources.Cerrar;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(907, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // nuevaDoctorBtn
            // 
            this.nuevaDoctorBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nuevaDoctorBtn.FlatAppearance.BorderSize = 0;
            this.nuevaDoctorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevaDoctorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevaDoctorBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(50)))), ((int)(((byte)(129)))));
            this.nuevaDoctorBtn.Image = global::Control_Pacientes_Clinica_Machado.Properties.Resources.insert;
            this.nuevaDoctorBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nuevaDoctorBtn.Location = new System.Drawing.Point(607, 84);
            this.nuevaDoctorBtn.Name = "nuevaDoctorBtn";
            this.nuevaDoctorBtn.Size = new System.Drawing.Size(186, 38);
            this.nuevaDoctorBtn.TabIndex = 18;
            this.nuevaDoctorBtn.Text = "Nuevo doctor";
            this.nuevaDoctorBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nuevaDoctorBtn.UseVisualStyleBackColor = true;
            this.nuevaDoctorBtn.Click += new System.EventHandler(this.nuevaDoctorBtn_Click);
            // 
            // buscarDoctorBtn
            // 
            this.buscarDoctorBtn.FlatAppearance.BorderSize = 0;
            this.buscarDoctorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarDoctorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarDoctorBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(50)))), ((int)(((byte)(129)))));
            this.buscarDoctorBtn.Image = global::Control_Pacientes_Clinica_Machado.Properties.Resources.search;
            this.buscarDoctorBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarDoctorBtn.Location = new System.Drawing.Point(125, 84);
            this.buscarDoctorBtn.Name = "buscarDoctorBtn";
            this.buscarDoctorBtn.Size = new System.Drawing.Size(187, 38);
            this.buscarDoctorBtn.TabIndex = 17;
            this.buscarDoctorBtn.Text = "Buscar doctor";
            this.buscarDoctorBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buscarDoctorBtn.UseVisualStyleBackColor = true;
            this.buscarDoctorBtn.Click += new System.EventHandler(this.buscarDoctorBtn_Click);
            // 
            // Doctores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 590);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PanelCrudDoctor);
            this.Controls.Add(this.nuevaDoctorBtn);
            this.Controls.Add(this.buscarDoctorBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Doctores";
            this.Text = "Doctores";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelCrudDoctor;
        private System.Windows.Forms.Button nuevaDoctorBtn;
        private System.Windows.Forms.Button buscarDoctorBtn;
    }
}