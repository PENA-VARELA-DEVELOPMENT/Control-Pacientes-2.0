namespace Control_Pacientes_Clinica_Machado
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
            ((System.ComponentModel.ISupportInitialize)(this.dvgListarPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgListarPaciente
            // 
            this.dvgListarPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgListarPaciente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.dvgListarPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgListarPaciente.Location = new System.Drawing.Point(12, 12);
            this.dvgListarPaciente.Name = "dvgListarPaciente";
            this.dvgListarPaciente.Size = new System.Drawing.Size(851, 369);
            this.dvgListarPaciente.TabIndex = 0;
            this.dvgListarPaciente.SelectionChanged += new System.EventHandler(this.dvgListarPaciente_SelectionChanged);
            // 
            // btnVerExpediente
            // 
            this.btnVerExpediente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVerExpediente.FlatAppearance.BorderSize = 0;
            this.btnVerExpediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerExpediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerExpediente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(50)))), ((int)(((byte)(129)))));
            this.btnVerExpediente.Image = global::Control_Pacientes_Clinica_Machado.Properties.Resources.reload;
            this.btnVerExpediente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerExpediente.Location = new System.Drawing.Point(95, 393);
            this.btnVerExpediente.Name = "btnVerExpediente";
            this.btnVerExpediente.Size = new System.Drawing.Size(210, 38);
            this.btnVerExpediente.TabIndex = 4;
            this.btnVerExpediente.Text = "Ver expediente";
            this.btnVerExpediente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerExpediente.UseVisualStyleBackColor = true;
            this.btnVerExpediente.Click += new System.EventHandler(this.btnVerExpediente_Click);
            // 
            // ListarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(875, 443);
            this.Controls.Add(this.btnVerExpediente);
            this.Controls.Add(this.dvgListarPaciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListarPaciente";
            this.Text = "ListarPaciente";
            this.Load += new System.EventHandler(this.ListarPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgListarPaciente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgListarPaciente;
        private System.Windows.Forms.Button btnVerExpediente;
    }
}