﻿namespace Control_Pacientes_Clinica_Machado
{
    partial class ListarPaciente
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
            this.dvgListarPaciente = new System.Windows.Forms.DataGridView();
            this.btnVerExpediente = new System.Windows.Forms.Button();
            this.BtnDarBaja = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgListarPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgListarPaciente
            // 
            this.dvgListarPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgListarPaciente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.dvgListarPaciente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dvgListarPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgListarPaciente.Location = new System.Drawing.Point(12, 47);
            this.dvgListarPaciente.Name = "dvgListarPaciente";
            this.dvgListarPaciente.Size = new System.Drawing.Size(851, 334);
            this.dvgListarPaciente.TabIndex = 0;
            this.dvgListarPaciente.SelectionChanged += new System.EventHandler(this.dvgListarPaciente_SelectionChanged);
            // 
            // btnVerExpediente
            // 
            this.btnVerExpediente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerExpediente.FlatAppearance.BorderSize = 0;
            this.btnVerExpediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerExpediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerExpediente.ForeColor = System.Drawing.Color.White;
            this.btnVerExpediente.Image = global::Control_Pacientes_Clinica_Machado.Properties.Resources.folder_find;
            this.btnVerExpediente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerExpediente.Location = new System.Drawing.Point(450, 393);
            this.btnVerExpediente.Name = "btnVerExpediente";
            this.btnVerExpediente.Size = new System.Drawing.Size(193, 38);
            this.btnVerExpediente.TabIndex = 4;
            this.btnVerExpediente.Text = "Ver expediente";
            this.btnVerExpediente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerExpediente.UseVisualStyleBackColor = true;
            this.btnVerExpediente.Click += new System.EventHandler(this.btnVerExpediente_Click);
            // 
            // BtnDarBaja
            // 
            this.BtnDarBaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDarBaja.FlatAppearance.BorderSize = 0;
            this.BtnDarBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDarBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDarBaja.ForeColor = System.Drawing.Color.White;
            this.BtnDarBaja.Image = global::Control_Pacientes_Clinica_Machado.Properties.Resources.trash;
            this.BtnDarBaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDarBaja.Location = new System.Drawing.Point(661, 393);
            this.BtnDarBaja.Name = "BtnDarBaja";
            this.BtnDarBaja.Size = new System.Drawing.Size(203, 38);
            this.BtnDarBaja.TabIndex = 5;
            this.BtnDarBaja.Text = "Dar de baja";
            this.BtnDarBaja.UseVisualStyleBackColor = true;
            this.BtnDarBaja.Click += new System.EventHandler(this.BtnDarBaja_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Image = global::Control_Pacientes_Clinica_Machado.Properties.Resources.search;
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(707, 2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(126, 39);
            this.BtnBuscar.TabIndex = 8;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(277, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // ListarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(875, 443);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnDarBaja);
            this.Controls.Add(this.btnVerExpediente);
            this.Controls.Add(this.dvgListarPaciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListarPaciente";
            this.Text = "ListarPaciente";
            this.Load += new System.EventHandler(this.ListarPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgListarPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgListarPaciente;
        private System.Windows.Forms.Button btnVerExpediente;
        private System.Windows.Forms.Button BtnDarBaja;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}