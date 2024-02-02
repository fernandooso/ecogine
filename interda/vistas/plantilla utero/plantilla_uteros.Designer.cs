namespace interda.vistas
{
    partial class plantilla_uteros
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_nombre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_plantilla = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Plantilla útero";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.comboBox_nombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 100);
            this.panel1.TabIndex = 9;
            // 
            // comboBox_nombre
            // 
            this.comboBox_nombre.AllowDrop = true;
            this.comboBox_nombre.FormattingEnabled = true;
            this.comboBox_nombre.IntegralHeight = false;
            this.comboBox_nombre.ItemHeight = 16;
            this.comboBox_nombre.Location = new System.Drawing.Point(408, 40);
            this.comboBox_nombre.Name = "comboBox_nombre";
            this.comboBox_nombre.Size = new System.Drawing.Size(396, 24);
            this.comboBox_nombre.TabIndex = 4;
            this.comboBox_nombre.SelectedIndexChanged += new System.EventHandler(this.comboBox_nombre_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // textBox_plantilla
            // 
            this.textBox_plantilla.Location = new System.Drawing.Point(176, 248);
            this.textBox_plantilla.Multiline = true;
            this.textBox_plantilla.Name = "textBox_plantilla";
            this.textBox_plantilla.Size = new System.Drawing.Size(757, 221);
            this.textBox_plantilla.TabIndex = 13;
            this.textBox_plantilla.TextChanged += new System.EventHandler(this.textBox_plantilla_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Plantilla útero";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(176, 124);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(504, 22);
            this.textBox_nombre.TabIndex = 11;
            this.textBox_nombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre:";
            // 
            // plantilla_uteros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1020, 508);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_plantilla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.label3);
            this.Name = "plantilla_uteros";
            this.Text = "plantilla_uteros";
            this.Load += new System.EventHandler(this.plantilla_uteros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_plantilla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Label label3;
    }
}