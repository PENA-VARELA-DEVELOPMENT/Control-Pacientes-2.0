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
            this.button1 = new System.Windows.Forms.Button();
            this.darBajaBtn = new System.Windows.Forms.Button();
            this.modificarDoctorBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarDoctores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListarDoctores
            // 
            this.dgvListarDoctores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListarDoctores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListarDoctores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.dgvListarDoctores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListarDoctores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarDoctores.Location = new System.Drawing.Point(12, 12);
            this.dgvListarDoctores.Name = "dgvListarDoctores";
            this.dgvListarDoctores.Size = new System.Drawing.Size(843, 366);
            this.dgvListarDoctores.TabIndex = 0;
            this.dgvListarDoctores.SelectionChanged += new System.EventHandler(this.dgvListarDoctores_SelectionChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Control_Pacientes_Clinica_Machado.Properties.Resources.reload;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(543, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 38);
            this.button1.TabIndex = 21;
            this.button1.Text = "Modificar doctor";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // darBajaBtn
            // 
            this.darBajaBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.darBajaBtn.FlatAppearance.BorderSize = 0;
            this.darBajaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.darBajaBtn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darBajaBtn.ForeColor = System.Drawing.Color.White;
            this.darBajaBtn.Image = global::Control_Pacientes_Clinica_Machado.Properties.Resources.trash;
            this.darBajaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.darBajaBtn.Location = new System.Drawing.Point(733, 393);
            this.darBajaBtn.Name = "darBajaBtn";
            this.darBajaBtn.Size = new System.Drawing.Size(121, 38);
            this.darBajaBtn.TabIndex = 22;
            this.darBajaBtn.Text = "Eliminar ";
            this.darBajaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.darBajaBtn.UseVisualStyleBackColor = true;
            this.darBajaBtn.Click += new System.EventHandler(this.darBajaBtn_Click);
            // 
            // modificarDoctorBtn
            // 
            this.modificarDoctorBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.modificarDoctorBtn.FlatAppearance.BorderSize = 0;
            this.modificarDoctorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarDoctorBtn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarDoctorBtn.ForeColor = System.Drawing.Color.White;
            this.modificarDoctorBtn.Image = global::Control_Pacientes_Clinica_Machado.Properties.Resources.date_32x32_32;
            this.modificarDoctorBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modificarDoctorBtn.Location = new System.Drawing.Point(371, 393);
            this.modificarDoctorBtn.Name = "modificarDoctorBtn";
            this.modificarDoctorBtn.Size = new System.Drawing.Size(166, 38);
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.darBajaBtn);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button darBajaBtn;
    }
}