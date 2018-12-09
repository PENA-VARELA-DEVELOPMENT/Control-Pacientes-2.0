namespace Control_Pacientes_Clinica_Machado.FormulariosMantenimiento
{
    partial class Mantenimiento
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
            this.PanelCrud = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inventarioBtn = new System.Windows.Forms.Button();
            this.habilitarPxBtn = new System.Windows.Forms.Button();
            this.UsuariosBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelCrud
            // 
            this.PanelCrud.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelCrud.Location = new System.Drawing.Point(17, 140);
            this.PanelCrud.Name = "PanelCrud";
            this.PanelCrud.Size = new System.Drawing.Size(905, 443);
            this.PanelCrud.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(50)))), ((int)(((byte)(129)))));
            this.label1.Location = new System.Drawing.Point(389, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mantenimiento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::Control_Pacientes_Clinica_Machado.Properties.Resources.Cerrar;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(908, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // inventarioBtn
            // 
            this.inventarioBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inventarioBtn.FlatAppearance.BorderSize = 0;
            this.inventarioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventarioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventarioBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(50)))), ((int)(((byte)(129)))));
            this.inventarioBtn.Image = global::Control_Pacientes_Clinica_Machado.Properties.Resources.storage32;
            this.inventarioBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventarioBtn.Location = new System.Drawing.Point(669, 85);
            this.inventarioBtn.Name = "inventarioBtn";
            this.inventarioBtn.Size = new System.Drawing.Size(144, 38);
            this.inventarioBtn.TabIndex = 12;
            this.inventarioBtn.Text = "Inventario";
            this.inventarioBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.inventarioBtn.UseVisualStyleBackColor = true;
            // 
            // habilitarPxBtn
            // 
            this.habilitarPxBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.habilitarPxBtn.FlatAppearance.BorderSize = 0;
            this.habilitarPxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.habilitarPxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habilitarPxBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(50)))), ((int)(((byte)(129)))));
            this.habilitarPxBtn.Image = global::Control_Pacientes_Clinica_Machado.Properties.Resources.habilitarOpt;
            this.habilitarPxBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.habilitarPxBtn.Location = new System.Drawing.Point(353, 85);
            this.habilitarPxBtn.Name = "habilitarPxBtn";
            this.habilitarPxBtn.Size = new System.Drawing.Size(198, 38);
            this.habilitarPxBtn.TabIndex = 11;
            this.habilitarPxBtn.Text = "Habilitar paciente";
            this.habilitarPxBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.habilitarPxBtn.UseVisualStyleBackColor = true;
            this.habilitarPxBtn.Click += new System.EventHandler(this.habilitarPxBtn_Click);
            // 
            // UsuariosBtn
            // 
            this.UsuariosBtn.FlatAppearance.BorderSize = 0;
            this.UsuariosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsuariosBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuariosBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(50)))), ((int)(((byte)(129)))));
            this.UsuariosBtn.Image = global::Control_Pacientes_Clinica_Machado.Properties.Resources.team32;
            this.UsuariosBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UsuariosBtn.Location = new System.Drawing.Point(91, 85);
            this.UsuariosBtn.Name = "UsuariosBtn";
            this.UsuariosBtn.Size = new System.Drawing.Size(131, 38);
            this.UsuariosBtn.TabIndex = 10;
            this.UsuariosBtn.Text = "Usuarios";
            this.UsuariosBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UsuariosBtn.UseVisualStyleBackColor = true;
            this.UsuariosBtn.Click += new System.EventHandler(this.UsuariosBtn_Click);
            // 
            // Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 590);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PanelCrud);
            this.Controls.Add(this.inventarioBtn);
            this.Controls.Add(this.habilitarPxBtn);
            this.Controls.Add(this.UsuariosBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mantenimiento";
            this.Text = "Mantenimiento";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelCrud;
        private System.Windows.Forms.Button inventarioBtn;
        private System.Windows.Forms.Button habilitarPxBtn;
        private System.Windows.Forms.Button UsuariosBtn;
        private System.Windows.Forms.Label label1;
    }
}