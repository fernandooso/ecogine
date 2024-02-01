namespace interda.vistas
{
    partial class informeobstetrico
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
            this.btnconcldiaginfobst = new System.Windows.Forms.Button();
            this.btnliquamniotico = new System.Windows.Forms.Button();
            this.btnplacenta = new System.Windows.Forms.Button();
            this.btnpresentacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(338, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de sugerencias obstetricas";
            // 
            // btnconcldiaginfobst
            // 
            this.btnconcldiaginfobst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnconcldiaginfobst.Location = new System.Drawing.Point(392, 131);
            this.btnconcldiaginfobst.Name = "btnconcldiaginfobst";
            this.btnconcldiaginfobst.Size = new System.Drawing.Size(270, 45);
            this.btnconcldiaginfobst.TabIndex = 1;
            this.btnconcldiaginfobst.Text = "Conclusion/Diagnostico";
            this.btnconcldiaginfobst.UseVisualStyleBackColor = true;
            this.btnconcldiaginfobst.Click += new System.EventHandler(this.btnconcldiaginfobst_Click);
            // 
            // btnliquamniotico
            // 
            this.btnliquamniotico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnliquamniotico.Location = new System.Drawing.Point(392, 197);
            this.btnliquamniotico.Name = "btnliquamniotico";
            this.btnliquamniotico.Size = new System.Drawing.Size(270, 45);
            this.btnliquamniotico.TabIndex = 2;
            this.btnliquamniotico.Text = "Liquido amniotico";
            this.btnliquamniotico.UseVisualStyleBackColor = true;
            this.btnliquamniotico.Click += new System.EventHandler(this.btnliquamniotico_Click);
            // 
            // btnplacenta
            // 
            this.btnplacenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnplacenta.Location = new System.Drawing.Point(392, 264);
            this.btnplacenta.Name = "btnplacenta";
            this.btnplacenta.Size = new System.Drawing.Size(270, 45);
            this.btnplacenta.TabIndex = 3;
            this.btnplacenta.Text = "Placenta";
            this.btnplacenta.UseVisualStyleBackColor = true;
            this.btnplacenta.Click += new System.EventHandler(this.btnplacenta_Click);
            // 
            // btnpresentacion
            // 
            this.btnpresentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnpresentacion.Location = new System.Drawing.Point(392, 336);
            this.btnpresentacion.Name = "btnpresentacion";
            this.btnpresentacion.Size = new System.Drawing.Size(270, 45);
            this.btnpresentacion.TabIndex = 4;
            this.btnpresentacion.Text = "Presentacion";
            this.btnpresentacion.UseVisualStyleBackColor = true;
            this.btnpresentacion.Click += new System.EventHandler(this.btnpresentacion_Click);
            // 
            // informeobstetrico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 540);
            this.Controls.Add(this.btnpresentacion);
            this.Controls.Add(this.btnplacenta);
            this.Controls.Add(this.btnliquamniotico);
            this.Controls.Add(this.btnconcldiaginfobst);
            this.Controls.Add(this.label1);
            this.Name = "informeobstetrico";
            this.Text = "informeobstetrico";
            this.Load += new System.EventHandler(this.informeobstetrico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnconcldiaginfobst;
        private System.Windows.Forms.Button btnliquamniotico;
        private System.Windows.Forms.Button btnplacenta;
        private System.Windows.Forms.Button btnpresentacion;
    }
}