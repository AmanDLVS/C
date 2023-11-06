namespace lista_pelicuals_Amancio
{
    partial class Form1
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
            this.lb_1 = new System.Windows.Forms.Label();
            this.btn_añadir = new System.Windows.Forms.Button();
            this.lb2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lb3 = new System.Windows.Forms.Label();
            this.pB1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Location = new System.Drawing.Point(29, 71);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(186, 16);
            this.lb_1.TabIndex = 0;
            this.lb_1.Text = "Escribe el titulo de la pelicula: ";
            // 
            // btn_añadir
            // 
            this.btn_añadir.Location = new System.Drawing.Point(159, 119);
            this.btn_añadir.Name = "btn_añadir";
            this.btn_añadir.Size = new System.Drawing.Size(75, 31);
            this.btn_añadir.TabIndex = 2;
            this.btn_añadir.Text = "añadir";
            this.btn_añadir.UseVisualStyleBackColor = true;
            this.btn_añadir.Click += new System.EventHandler(this.btn_añadir_Click);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(44, 169);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(65, 16);
            this.lb2.TabIndex = 3;
            this.lb2.Text = "Peliculas:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "La amenaza fantasma",
            "El ataque de los clones",
            "La venganza los sith "});
            this.comboBox1.Location = new System.Drawing.Point(47, 198);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(286, 134);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(65, 16);
            this.lb3.TabIndex = 5;
            this.lb3.Text = "Cartelera:";
            // 
            // pB1
            // 
            this.pB1.Location = new System.Drawing.Point(374, 149);
            this.pB1.Name = "pB1";
            this.pB1.Size = new System.Drawing.Size(278, 202);
            this.pB1.TabIndex = 6;
            this.pB1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(251, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 22);
            this.textBox1.TabIndex = 7;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(601, 357);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 8;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 388);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pB1);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.btn_añadir);
            this.Controls.Add(this.lb_1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.Button btn_añadir;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.PictureBox pB1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_salir;
    }
}

