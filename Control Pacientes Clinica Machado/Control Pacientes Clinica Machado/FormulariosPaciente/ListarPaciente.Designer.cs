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
            ((System.ComponentModel.ISupportInitialize)(this.dvgListarPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgListarPaciente
            // 
            this.dvgListarPaciente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.dvgListarPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgListarPaciente.Location = new System.Drawing.Point(12, 12);
            this.dvgListarPaciente.Name = "dvgListarPaciente";
            this.dvgListarPaciente.Size = new System.Drawing.Size(851, 419);
            this.dvgListarPaciente.TabIndex = 0;
            // 
            // ListarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(875, 443);
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
    }
}