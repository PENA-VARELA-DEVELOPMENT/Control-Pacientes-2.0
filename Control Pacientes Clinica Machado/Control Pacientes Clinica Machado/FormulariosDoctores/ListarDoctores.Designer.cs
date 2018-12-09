namespace Control_Pacientes_Clinica_Machado.FormulariosDoctores
{
    partial class ListarDoctores
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
            this.dgvListarDoctores = new System.Windows.Forms.DataGridView();
            this.modificarDoctorBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarDoctores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListarDoctores
            // 
            this.dgvListarDoctores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListarDoctores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.dgvListarDoctores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarDoctores.Location = new System.Drawing.Point(12, 12);
            this.dgvListarDoctores.Name = "dgvListarDoctores";
            this.dgvListarDoctores.Size = new System.Drawing.Size(843, 366);
            this.dgvListarDoctores.TabIndex = 0;
            // 
            // modificarDoctorBtn
            // 
            this.modificarDoctorBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.modificarDoctorBtn.FlatAppearance.BorderSize = 0;
            this.modificarDoctorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarDoctorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarDoctorBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(50)))), ((int)(((byte)(129)))));
            this.modificarDoctorBtn.Image = global::Control_Pacientes_Clinica_Machado.Properties.Resources.ok;
            this.modificarDoctorBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modificarDoctorBtn.Location = new System.Drawing.Point(12, 393);
            this.modificarDoctorBtn.Name = "modificarDoctorBtn";
            this.modificarDoctorBtn.Size = new System.Drawing.Size(210, 38);
            this.modificarDoctorBtn.TabIndex = 20;
            this.modificarDoctorBtn.Text = "Agenda doctor";
            this.modificarDoctorBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.modificarDoctorBtn.UseVisualStyleBackColor = true;
            this.modificarDoctorBtn.Click += new System.EventHandler(this.modificarDoctorBtn_Click);
            // 
            // ListarDoctores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(867, 443);
            this.Controls.Add(this.modificarDoctorBtn);
            this.Controls.Add(this.dgvListarDoctores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListarDoctores";
            this.Text = "ListarDoctores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarDoctores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListarDoctores;
        private System.Windows.Forms.Button modificarDoctorBtn;
    }
}