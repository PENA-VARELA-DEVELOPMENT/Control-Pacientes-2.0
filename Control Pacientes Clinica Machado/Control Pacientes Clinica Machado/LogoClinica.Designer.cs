namespace Control_Pacientes_Clinica_Machado
{
    partial class LogoClinica
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
            this.logoPict01 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPict01)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPict01
            // 
            this.logoPict01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoPict01.BackgroundImage = global::Control_Pacientes_Clinica_Machado.Properties.Resources.Vector_clinica;
            this.logoPict01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoPict01.Location = new System.Drawing.Point(18, 77);
            this.logoPict01.Name = "logoPict01";
            this.logoPict01.Size = new System.Drawing.Size(915, 436);
            this.logoPict01.TabIndex = 1;
            this.logoPict01.TabStop = false;
            // 
            // LogoClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 629);
            this.Controls.Add(this.logoPict01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogoClinica";
            this.Text = "LogoClinica";
            ((System.ComponentModel.ISupportInitialize)(this.logoPict01)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPict01;
    }
}