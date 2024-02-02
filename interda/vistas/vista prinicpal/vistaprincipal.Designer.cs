namespace interda.vistas
{
    partial class vistaprincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vistaprincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxdoctor = new System.Windows.Forms.ComboBox();
            this.comboBoxasistente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxecografo = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxpiepag = new System.Windows.Forms.ComboBox();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btnnuevoinf = new System.Windows.Forms.Button();
            this.btnbuscarinf = new System.Windows.Forms.Button();
            this.btninstitucionencabezado = new System.Windows.Forms.Button();
            this.btninfobstetrico = new System.Windows.Forms.Button();
            this.btntablaobstetrica = new System.Windows.Forms.Button();
            this.btnanatomiafetal = new System.Windows.Forms.Button();
            this.btnpiedepagina = new System.Windows.Forms.Button();
            this.btnplanillautero = new System.Windows.Forms.Button();
            this.btnconclusionanatomia = new System.Windows.Forms.Button();
            this.btnidreferencias = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(101, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ecotomografia Ginecologica y Obstetrica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(35, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Se inicia la sesion de trabajo del doctor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(382, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y la asistente";
            // 
            // comboBoxdoctor
            // 
            this.comboBoxdoctor.FormattingEnabled = true;
            this.comboBoxdoctor.Location = new System.Drawing.Point(35, 101);
            this.comboBoxdoctor.Name = "comboBoxdoctor";
            this.comboBoxdoctor.Size = new System.Drawing.Size(328, 24);
            this.comboBoxdoctor.TabIndex = 3;
            // 
            // comboBoxasistente
            // 
            this.comboBoxasistente.FormattingEnabled = true;
            this.comboBoxasistente.Location = new System.Drawing.Point(386, 101);
            this.comboBoxasistente.Name = "comboBoxasistente";
            this.comboBoxasistente.Size = new System.Drawing.Size(192, 24);
            this.comboBoxasistente.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(35, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Con fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(382, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ecografo";
            // 
            // comboBoxecografo
            // 
            this.comboBoxecografo.FormattingEnabled = true;
            this.comboBoxecografo.Location = new System.Drawing.Point(386, 185);
            this.comboBoxecografo.Name = "comboBoxecografo";
            this.comboBoxecografo.Size = new System.Drawing.Size(192, 24);
            this.comboBoxecografo.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(39, 186);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(299, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(35, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Pie de pagina";
            // 
            // comboBoxpiepag
            // 
            this.comboBoxpiepag.FormattingEnabled = true;
            this.comboBoxpiepag.Location = new System.Drawing.Point(39, 269);
            this.comboBoxpiepag.Name = "comboBoxpiepag";
            this.comboBoxpiepag.Size = new System.Drawing.Size(521, 24);
            this.comboBoxpiepag.TabIndex = 10;
            // 
            // btnactualizar
            // 
            this.btnactualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnactualizar.Location = new System.Drawing.Point(258, 474);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(105, 30);
            this.btnactualizar.TabIndex = 11;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            // 
            // btnnuevoinf
            // 
            this.btnnuevoinf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnnuevoinf.Location = new System.Drawing.Point(616, 75);
            this.btnnuevoinf.Name = "btnnuevoinf";
            this.btnnuevoinf.Size = new System.Drawing.Size(164, 32);
            this.btnnuevoinf.TabIndex = 12;
            this.btnnuevoinf.Text = "Nuevo informe";
            this.btnnuevoinf.UseVisualStyleBackColor = true;
            this.btnnuevoinf.Click += new System.EventHandler(this.btnnuevoinf_Click);
            // 
            // btnbuscarinf
            // 
            this.btnbuscarinf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnbuscarinf.Location = new System.Drawing.Point(616, 113);
            this.btnbuscarinf.Name = "btnbuscarinf";
            this.btnbuscarinf.Size = new System.Drawing.Size(164, 32);
            this.btnbuscarinf.TabIndex = 13;
            this.btnbuscarinf.Text = "Buscar informe";
            this.btnbuscarinf.UseVisualStyleBackColor = true;
            this.btnbuscarinf.Click += new System.EventHandler(this.btnbuscarinf_Click);
            // 
            // btninstitucionencabezado
            // 
            this.btninstitucionencabezado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btninstitucionencabezado.Location = new System.Drawing.Point(616, 152);
            this.btninstitucionencabezado.Name = "btninstitucionencabezado";
            this.btninstitucionencabezado.Size = new System.Drawing.Size(164, 73);
            this.btninstitucionencabezado.TabIndex = 14;
            this.btninstitucionencabezado.Text = "Institucion/Encabezado de pagina";
            this.btninstitucionencabezado.UseVisualStyleBackColor = true;
            this.btninstitucionencabezado.Click += new System.EventHandler(this.btninstitucionencabezado_Click);
            // 
            // btninfobstetrico
            // 
            this.btninfobstetrico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btninfobstetrico.Location = new System.Drawing.Point(616, 310);
            this.btninfobstetrico.Name = "btninfobstetrico";
            this.btninfobstetrico.Size = new System.Drawing.Size(164, 59);
            this.btninfobstetrico.TabIndex = 15;
            this.btninfobstetrico.Text = "Informe Obstetrico";
            this.btninfobstetrico.UseVisualStyleBackColor = true;
            this.btninfobstetrico.Click += new System.EventHandler(this.btninfobstetrico_Click);
            // 
            // btntablaobstetrica
            // 
            this.btntablaobstetrica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btntablaobstetrica.Location = new System.Drawing.Point(616, 375);
            this.btntablaobstetrica.Name = "btntablaobstetrica";
            this.btntablaobstetrica.Size = new System.Drawing.Size(164, 59);
            this.btntablaobstetrica.TabIndex = 16;
            this.btntablaobstetrica.Text = "Tablas Obstetricas";
            this.btntablaobstetrica.UseVisualStyleBackColor = true;
            this.btntablaobstetrica.Click += new System.EventHandler(this.btntablaobstetrica_Click);
            // 
            // btnanatomiafetal
            // 
            this.btnanatomiafetal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnanatomiafetal.Location = new System.Drawing.Point(616, 440);
            this.btnanatomiafetal.Name = "btnanatomiafetal";
            this.btnanatomiafetal.Size = new System.Drawing.Size(164, 32);
            this.btnanatomiafetal.TabIndex = 17;
            this.btnanatomiafetal.Text = "Anatomia fetal";
            this.btnanatomiafetal.UseVisualStyleBackColor = true;
            this.btnanatomiafetal.Click += new System.EventHandler(this.btnanatomiafetal_Click);
            // 
            // btnpiedepagina
            // 
            this.btnpiedepagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnpiedepagina.Location = new System.Drawing.Point(616, 482);
            this.btnpiedepagina.Name = "btnpiedepagina";
            this.btnpiedepagina.Size = new System.Drawing.Size(164, 32);
            this.btnpiedepagina.TabIndex = 18;
            this.btnpiedepagina.Text = "Pie de pagina";
            this.btnpiedepagina.UseVisualStyleBackColor = true;
            this.btnpiedepagina.Click += new System.EventHandler(this.btnpiedepagina_Click);
            // 
            // btnplanillautero
            // 
            this.btnplanillautero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnplanillautero.Location = new System.Drawing.Point(616, 520);
            this.btnplanillautero.Name = "btnplanillautero";
            this.btnplanillautero.Size = new System.Drawing.Size(164, 56);
            this.btnplanillautero.TabIndex = 19;
            this.btnplanillautero.Text = "Planilla utero";
            this.btnplanillautero.UseVisualStyleBackColor = true;
            this.btnplanillautero.Click += new System.EventHandler(this.btnplanillautero_Click);
            // 
            // btnconclusionanatomia
            // 
            this.btnconclusionanatomia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnconclusionanatomia.Location = new System.Drawing.Point(616, 582);
            this.btnconclusionanatomia.Name = "btnconclusionanatomia";
            this.btnconclusionanatomia.Size = new System.Drawing.Size(164, 56);
            this.btnconclusionanatomia.TabIndex = 20;
            this.btnconclusionanatomia.Text = "Conclusion anatomia";
            this.btnconclusionanatomia.UseVisualStyleBackColor = true;
            this.btnconclusionanatomia.Click += new System.EventHandler(this.btnconclusionanatomia_Click);
            // 
            // btnidreferencias
            // 
            this.btnidreferencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnidreferencias.Location = new System.Drawing.Point(616, 231);
            this.btnidreferencias.Name = "btnidreferencias";
            this.btnidreferencias.Size = new System.Drawing.Size(164, 73);
            this.btnidreferencias.TabIndex = 21;
            this.btnidreferencias.Text = "ID referencias";
            this.btnidreferencias.UseVisualStyleBackColor = true;
            this.btnidreferencias.Click += new System.EventHandler(this.btnidreferencias_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(222, 510);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 182);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(39, 323);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(521, 123);
            this.textBox1.TabIndex = 23;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(123, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(321, 24);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 84);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(321, 46);
            this.textBox2.TabIndex = 25;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(71, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Mail 1";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(160, 146);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(264, 22);
            this.textBox3.TabIndex = 27;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(160, 199);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(264, 22);
            this.textBox4.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(71, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Mail 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(71, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Texto de salida mail";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(75, 287);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(408, 112);
            this.textBox5.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(786, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 664);
            this.panel1.TabIndex = 32;
            // 
            // vistaprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1353, 716);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnidreferencias);
            this.Controls.Add(this.btnconclusionanatomia);
            this.Controls.Add(this.btnplanillautero);
            this.Controls.Add(this.btnpiedepagina);
            this.Controls.Add(this.btnanatomiafetal);
            this.Controls.Add(this.btntablaobstetrica);
            this.Controls.Add(this.btninfobstetrico);
            this.Controls.Add(this.btninstitucionencabezado);
            this.Controls.Add(this.btnbuscarinf);
            this.Controls.Add(this.btnnuevoinf);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.comboBoxpiepag);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxecografo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxasistente);
            this.Controls.Add(this.comboBoxdoctor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "vistaprincipal";
            this.Text = "vistaprincipal";
            this.Load += new System.EventHandler(this.vistaprincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxdoctor;
        private System.Windows.Forms.ComboBox comboBoxasistente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxecografo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxpiepag;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btnnuevoinf;
        private System.Windows.Forms.Button btnbuscarinf;
        private System.Windows.Forms.Button btninstitucionencabezado;
        private System.Windows.Forms.Button btninfobstetrico;
        private System.Windows.Forms.Button btntablaobstetrica;
        private System.Windows.Forms.Button btnanatomiafetal;
        private System.Windows.Forms.Button btnpiedepagina;
        private System.Windows.Forms.Button btnplanillautero;
        private System.Windows.Forms.Button btnconclusionanatomia;
        private System.Windows.Forms.Button btnidreferencias;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Panel panel1;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
    }
}