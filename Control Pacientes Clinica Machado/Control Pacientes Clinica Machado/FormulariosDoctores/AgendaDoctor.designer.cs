namespace Control_Pacientes_Clinica_Machado.FormulariosDoctores
{
    partial class AgendaDoctor
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.annee = new System.Windows.Forms.ComboBox();
            this.mois = new System.Windows.Forms.ComboBox();
            this.maDataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lundi = new System.Windows.Forms.Label();
            this.mardi = new System.Windows.Forms.Label();
            this.mercredi = new System.Windows.Forms.Label();
            this.jeudi = new System.Windows.Forms.Label();
            this.vendredi = new System.Windows.Forms.Label();
            this.samedi = new System.Windows.Forms.Label();
            this.dimanche = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.displayEvent = new System.Windows.Forms.TextBox();
            this.addEvent = new System.Windows.Forms.Button();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.timeEvent = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateEvent = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.annee);
            this.panel1.Controls.Add(this.mois);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 27);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.maDate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 21);
            this.panel2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(179, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = ">|";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = ">";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // maDate
            // 
            this.maDate.AutoSize = true;
            this.maDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maDate.Location = new System.Drawing.Point(58, 3);
            this.maDate.Name = "maDate";
            this.maDate.Size = new System.Drawing.Size(0, 13);
            this.maDate.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "<";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "|<";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // annee
            // 
            this.annee.FormattingEnabled = true;
            this.annee.Location = new System.Drawing.Point(335, 3);
            this.annee.Name = "annee";
            this.annee.Size = new System.Drawing.Size(121, 21);
            this.annee.TabIndex = 1;
            this.annee.SelectedIndexChanged += new System.EventHandler(this.annee_SelectedIndexChanged);
            // 
            // mois
            // 
            this.mois.FormattingEnabled = true;
            this.mois.Location = new System.Drawing.Point(208, 3);
            this.mois.Name = "mois";
            this.mois.Size = new System.Drawing.Size(121, 21);
            this.mois.TabIndex = 0;
            this.mois.SelectedIndexChanged += new System.EventHandler(this.mois_SelectedIndexChanged);
            // 
            // maDataGrid
            // 
            this.maDataGrid.AllowUserToAddRows = false;
            this.maDataGrid.AllowUserToResizeColumns = false;
            this.maDataGrid.AllowUserToResizeRows = false;
            this.maDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.maDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maDataGrid.ColumnHeadersVisible = false;
            this.maDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.maDataGrid.DefaultCellStyle = dataGridViewCellStyle9;
            this.maDataGrid.Location = new System.Drawing.Point(12, 138);
            this.maDataGrid.MultiSelect = false;
            this.maDataGrid.Name = "maDataGrid";
            this.maDataGrid.RowHeadersVisible = false;
            this.maDataGrid.RowHeadersWidth = 10;
            this.maDataGrid.RowTemplate.Height = 50;
            this.maDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.maDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.maDataGrid.Size = new System.Drawing.Size(738, 317);
            this.maDataGrid.TabIndex = 1;
            this.maDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.maDataGrid_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 30;
            // 
            // Column2
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // lundi
            // 
            this.lundi.AutoSize = true;
            this.lundi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lundi.ForeColor = System.Drawing.Color.White;
            this.lundi.Location = new System.Drawing.Point(60, 119);
            this.lundi.Name = "lundi";
            this.lundi.Size = new System.Drawing.Size(51, 16);
            this.lundi.TabIndex = 2;
            this.lundi.Text = "label3";
            // 
            // mardi
            // 
            this.mardi.AutoSize = true;
            this.mardi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mardi.ForeColor = System.Drawing.Color.White;
            this.mardi.Location = new System.Drawing.Point(164, 119);
            this.mardi.Name = "mardi";
            this.mardi.Size = new System.Drawing.Size(51, 16);
            this.mardi.TabIndex = 3;
            this.mardi.Text = "label6";
            // 
            // mercredi
            // 
            this.mercredi.AutoSize = true;
            this.mercredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mercredi.ForeColor = System.Drawing.Color.White;
            this.mercredi.Location = new System.Drawing.Point(264, 119);
            this.mercredi.Name = "mercredi";
            this.mercredi.Size = new System.Drawing.Size(51, 16);
            this.mercredi.TabIndex = 4;
            this.mercredi.Text = "label7";
            // 
            // jeudi
            // 
            this.jeudi.AutoSize = true;
            this.jeudi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jeudi.ForeColor = System.Drawing.Color.White;
            this.jeudi.Location = new System.Drawing.Point(362, 119);
            this.jeudi.Name = "jeudi";
            this.jeudi.Size = new System.Drawing.Size(51, 16);
            this.jeudi.TabIndex = 5;
            this.jeudi.Text = "label8";
            // 
            // vendredi
            // 
            this.vendredi.AutoSize = true;
            this.vendredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendredi.ForeColor = System.Drawing.Color.White;
            this.vendredi.Location = new System.Drawing.Point(464, 119);
            this.vendredi.Name = "vendredi";
            this.vendredi.Size = new System.Drawing.Size(51, 16);
            this.vendredi.TabIndex = 6;
            this.vendredi.Text = "label9";
            // 
            // samedi
            // 
            this.samedi.AutoSize = true;
            this.samedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.samedi.ForeColor = System.Drawing.Color.White;
            this.samedi.Location = new System.Drawing.Point(560, 119);
            this.samedi.Name = "samedi";
            this.samedi.Size = new System.Drawing.Size(59, 16);
            this.samedi.TabIndex = 7;
            this.samedi.Text = "label10";
            // 
            // dimanche
            // 
            this.dimanche.AutoSize = true;
            this.dimanche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimanche.ForeColor = System.Drawing.Color.White;
            this.dimanche.Location = new System.Drawing.Point(662, 119);
            this.dimanche.Name = "dimanche";
            this.dimanche.Size = new System.Drawing.Size(59, 16);
            this.dimanche.TabIndex = 8;
            this.dimanche.Text = "label11";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.displayEvent);
            this.groupBox1.Controls.Add(this.addEvent);
            this.groupBox1.Controls.Add(this.txtEvent);
            this.groupBox1.Controls.Add(this.timeEvent);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateEvent);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(4, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 86);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eventos";
            // 
            // displayEvent
            // 
            this.displayEvent.BackColor = System.Drawing.Color.White;
            this.displayEvent.Location = new System.Drawing.Point(441, 19);
            this.displayEvent.Multiline = true;
            this.displayEvent.Name = "displayEvent";
            this.displayEvent.ReadOnly = true;
            this.displayEvent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.displayEvent.Size = new System.Drawing.Size(299, 49);
            this.displayEvent.TabIndex = 8;
            // 
            // addEvent
            // 
            this.addEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEvent.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEvent.ForeColor = System.Drawing.Color.White;
            this.addEvent.Location = new System.Drawing.Point(359, 19);
            this.addEvent.Name = "addEvent";
            this.addEvent.Size = new System.Drawing.Size(75, 49);
            this.addEvent.TabIndex = 7;
            this.addEvent.Text = "Añadir evento";
            this.addEvent.UseVisualStyleBackColor = true;
            this.addEvent.Click += new System.EventHandler(this.addEvent_Click);
            // 
            // txtEvent
            // 
            this.txtEvent.Location = new System.Drawing.Point(192, 19);
            this.txtEvent.Multiline = true;
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(162, 49);
            this.txtEvent.TabIndex = 6;
            this.txtEvent.Text = "Event : ";
            // 
            // timeEvent
            // 
            this.timeEvent.Location = new System.Drawing.Point(83, 48);
            this.timeEvent.Mask = "00:00";
            this.timeEvent.Name = "timeEvent";
            this.timeEvent.Size = new System.Drawing.Size(103, 20);
            this.timeEvent.TabIndex = 5;
            this.timeEvent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.timeEvent.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(8, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tiempo evento : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Fecha evento";
            // 
            // dateEvent
            // 
            this.dateEvent.Location = new System.Drawing.Point(83, 19);
            this.dateEvent.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateEvent.Name = "dateEvent";
            this.dateEvent.Size = new System.Drawing.Size(103, 20);
            this.dateEvent.TabIndex = 1;
            this.dateEvent.ValueChanged += new System.EventHandler(this.dateEvent_ValueChanged);
            // 
            // AgendaDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(755, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dimanche);
            this.Controls.Add(this.samedi);
            this.Controls.Add(this.vendredi);
            this.Controls.Add(this.jeudi);
            this.Controls.Add(this.mercredi);
            this.Controls.Add(this.mardi);
            this.Controls.Add(this.lundi);
            this.Controls.Add(this.maDataGrid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AgendaDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Penp - Agenda";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label maDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox annee;
        private System.Windows.Forms.ComboBox mois;
        private System.Windows.Forms.DataGridView maDataGrid;
        private System.Windows.Forms.Label lundi;
        private System.Windows.Forms.Label mardi;
        private System.Windows.Forms.Label mercredi;
        private System.Windows.Forms.Label jeudi;
        private System.Windows.Forms.Label vendredi;
        private System.Windows.Forms.Label samedi;
        private System.Windows.Forms.Label dimanche;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateEvent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox timeEvent;
        private System.Windows.Forms.TextBox txtEvent;
        private System.Windows.Forms.Button addEvent;
        private System.Windows.Forms.TextBox displayEvent;
    }
}

