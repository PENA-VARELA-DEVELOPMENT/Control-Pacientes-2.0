﻿namespace Control_Pacientes_Clinica_Machado
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.PanelOpciones = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ContaBtn = new System.Windows.Forms.Button();
            this.citasBtn = new System.Windows.Forms.Button();
            this.pacientesBtn = new System.Windows.Forms.Button();
            this.doctoresBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelInformacion = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.PanelCitas = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanelOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelInformacion.SuspendLayout();
            this.PanelCitas.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelOpciones
            // 
            this.PanelOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(196)))), ((int)(((byte)(45)))));
            this.PanelOpciones.Controls.Add(this.button1);
            this.PanelOpciones.Controls.Add(this.button2);
            this.PanelOpciones.Controls.Add(this.ContaBtn);
            this.PanelOpciones.Controls.Add(this.citasBtn);
            this.PanelOpciones.Controls.Add(this.pacientesBtn);
            this.PanelOpciones.Controls.Add(this.doctoresBtn);
            this.PanelOpciones.Controls.Add(this.pictureBox1);
            this.PanelOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelOpciones.Location = new System.Drawing.Point(0, 0);
            this.PanelOpciones.Name = "PanelOpciones";
            this.PanelOpciones.Size = new System.Drawing.Size(200, 729);
            this.PanelOpciones.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(50)))), ((int)(((byte)(129)))));
            this.button1.Image = global::Control_Pacientes_Clinica_Machado.Properties.Resources.ajustes1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-3, 554);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 73);
            this.button1.TabIndex = 6;
            this.button1.Text = "Mantenimiento";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(10, 694);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Acerca de los desarrolladores";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ContaBtn
            // 
            this.ContaBtn.FlatAppearance.BorderSize = 0;
            this.ContaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContaBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(50)))), ((int)(((byte)(129)))));
            this.ContaBtn.Image = global::Control_Pacientes_Clinica_Machado.Properties.Resources.reportes;
            this.ContaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ContaBtn.Location = new System.Drawing.Point(-3, 450);
            this.ContaBtn.Name = "ContaBtn";
            this.ContaBtn.Size = new System.Drawing.Size(204, 58);
            this.ContaBtn.TabIndex = 4;
            this.ContaBtn.Text = "            Reportes";
            this.ContaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ContaBtn.Click += new System.EventHandler(this.ContaBtn_Click);
            // 
            // citasBtn
            // 
            this.citasBtn.FlatAppearance.BorderSize = 0;
            this.citasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.citasBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citasBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(50)))), ((int)(((byte)(129)))));
            this.citasBtn.Image = global::Control_Pacientes_Clinica_Machado.Properties.Resources.appointment;
            this.citasBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.citasBtn.Location = new System.Drawing.Point(-3, 229);
            this.citasBtn.Name = "citasBtn";
            this.citasBtn.Size = new System.Drawing.Size(197, 71);
            this.citasBtn.TabIndex = 3;
            this.citasBtn.Text = "Citas        ";
            this.citasBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.citasBtn.UseVisualStyleBackColor = true;
            this.citasBtn.Click += new System.EventHandler(this.citasBtn_Click);
            this.citasBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.citasBtn_MouseDown);
            this.citasBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.citasBtn_MouseUp);
            // 
            // pacientesBtn
            // 
            this.pacientesBtn.FlatAppearance.BorderSize = 0;
            this.pacientesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pacientesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pacientesBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(50)))), ((int)(((byte)(129)))));
            this.pacientesBtn.Image = global::Control_Pacientes_Clinica_Machado.Properties.Resources.team;
            this.pacientesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pacientesBtn.Location = new System.Drawing.Point(-3, 125);
            this.pacientesBtn.Name = "pacientesBtn";
            this.pacientesBtn.Size = new System.Drawing.Size(200, 58);
            this.pacientesBtn.TabIndex = 2;
            this.pacientesBtn.Text = "Pacientes ";
            this.pacientesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pacientesBtn.UseVisualStyleBackColor = true;
            this.pacientesBtn.Click += new System.EventHandler(this.pacientesBtn_Click);
            this.pacientesBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pacientesBtn_MouseDown);
            this.pacientesBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pacientesBtn_MouseUp);
            // 
            // doctoresBtn
            // 
            this.doctoresBtn.FlatAppearance.BorderSize = 0;
            this.doctoresBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doctoresBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctoresBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(50)))), ((int)(((byte)(129)))));
            this.doctoresBtn.Image = global::Control_Pacientes_Clinica_Machado.Properties.Resources.doctor;
            this.doctoresBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doctoresBtn.Location = new System.Drawing.Point(-3, 346);
            this.doctoresBtn.Name = "doctoresBtn";
            this.doctoresBtn.Size = new System.Drawing.Size(200, 58);
            this.doctoresBtn.TabIndex = 1;
            this.doctoresBtn.Text = "Doctores   ";
            this.doctoresBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.doctoresBtn.Click += new System.EventHandler(this.doctoresBtn_Click);
            this.doctoresBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.doctoresBtn_MouseDown);
            this.doctoresBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.doctoresBtn_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Control_Pacientes_Clinica_Machado.Properties.Resources.Logo_Letras021;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(10, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 78);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PanelInformacion
            // 
            this.PanelInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(196)))), ((int)(((byte)(45)))));
            this.PanelInformacion.Controls.Add(this.lblFecha);
            this.PanelInformacion.Controls.Add(this.lblHora);
            this.PanelInformacion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelInformacion.Location = new System.Drawing.Point(200, 629);
            this.PanelInformacion.Name = "PanelInformacion";
            this.PanelInformacion.Size = new System.Drawing.Size(1150, 100);
            this.PanelInformacion.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.DimGray;
            this.lblFecha.Location = new System.Drawing.Point(730, 69);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(86, 31);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "label1";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Indigo;
            this.lblHora.Location = new System.Drawing.Point(897, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(190, 69);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "label1";
            // 
            // PanelCitas
            // 
            this.PanelCitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(196)))), ((int)(((byte)(45)))));
            this.PanelCitas.Controls.Add(this.label1);
            this.PanelCitas.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelCitas.Location = new System.Drawing.Point(1150, 0);
            this.PanelCitas.Name = "PanelCitas";
            this.PanelCitas.Size = new System.Drawing.Size(200, 629);
            this.PanelCitas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Información del día";
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(200, 0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(950, 629);
            this.PanelContenedor.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.PanelCitas);
            this.Controls.Add(this.PanelInformacion);
            this.Controls.Add(this.PanelOpciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Clínica Dental Machado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.PanelOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelInformacion.ResumeLayout(false);
            this.PanelInformacion.PerformLayout();
            this.PanelCitas.ResumeLayout(false);
            this.PanelCitas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelOpciones;
        private System.Windows.Forms.Panel PanelInformacion;
        private System.Windows.Forms.Panel PanelCitas;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button doctoresBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button citasBtn;
        private System.Windows.Forms.Button pacientesBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ContaBtn;
    }
}

