namespace interda.vistas
{
    partial class binforme
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxci = new System.Windows.Forms.TextBox();
            this.textBoxapellidos = new System.Windows.Forms.TextBox();
            this.buscarci = new System.Windows.Forms.Button();
            this.buscarapellidos = new System.Windows.Forms.Button();
            this.tablabuscador = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tablabuscador)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar por CI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(36, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos";
            // 
            // textBoxci
            // 
            this.textBoxci.Location = new System.Drawing.Point(213, 28);
            this.textBoxci.Name = "textBoxci";
            this.textBoxci.Size = new System.Drawing.Size(345, 22);
            this.textBoxci.TabIndex = 2;
            this.textBoxci.TextChanged += new System.EventHandler(this.textBoxci_TextChanged);
            // 
            // textBoxapellidos
            // 
            this.textBoxapellidos.Location = new System.Drawing.Point(213, 62);
            this.textBoxapellidos.Name = "textBoxapellidos";
            this.textBoxapellidos.Size = new System.Drawing.Size(345, 22);
            this.textBoxapellidos.TabIndex = 3;
            // 
            // buscarci
            // 
            this.buscarci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buscarci.Location = new System.Drawing.Point(599, 20);
            this.buscarci.Name = "buscarci";
            this.buscarci.Size = new System.Drawing.Size(101, 36);
            this.buscarci.TabIndex = 4;
            this.buscarci.Text = "Buscar";
            this.buscarci.UseVisualStyleBackColor = true;
            this.buscarci.Click += new System.EventHandler(this.buscarci_Click);
            // 
            // buscarapellidos
            // 
            this.buscarapellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buscarapellidos.Location = new System.Drawing.Point(599, 62);
            this.buscarapellidos.Name = "buscarapellidos";
            this.buscarapellidos.Size = new System.Drawing.Size(101, 36);
            this.buscarapellidos.TabIndex = 5;
            this.buscarapellidos.Text = "Buscar";
            this.buscarapellidos.UseVisualStyleBackColor = true;
            this.buscarapellidos.Click += new System.EventHandler(this.buscarapellidos_Click);
            // 
            // tablabuscador
            // 
            this.tablabuscador.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.tablabuscador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablabuscador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablabuscador.Location = new System.Drawing.Point(38, 111);
            this.tablabuscador.Name = "tablabuscador";
            this.tablabuscador.RowHeadersWidth = 51;
            this.tablabuscador.RowTemplate.Height = 24;
            this.tablabuscador.Size = new System.Drawing.Size(967, 411);
            this.tablabuscador.TabIndex = 6;
            this.tablabuscador.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablabuscador_CellContentClick);
            // 
            // binforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 536);
            this.Controls.Add(this.tablabuscador);
            this.Controls.Add(this.buscarapellidos);
            this.Controls.Add(this.buscarci);
            this.Controls.Add(this.textBoxapellidos);
            this.Controls.Add(this.textBoxci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "binforme";
            this.Text = "pruebas";
            this.Load += new System.EventHandler(this.pruebas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablabuscador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxci;
        private System.Windows.Forms.TextBox textBoxapellidos;
        private System.Windows.Forms.Button buscarci;
        private System.Windows.Forms.Button buscarapellidos;
        private System.Windows.Forms.DataGridView tablabuscador;
    }
}