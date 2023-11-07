namespace Panel_con_pestañas_Amancio
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
            this.TabP = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_reset = new System.Windows.Forms.Button();
            this.rb_tijeras = new System.Windows.Forms.RadioButton();
            this.rb_papel = new System.Windows.Forms.RadioButton();
            this.rb_piedra = new System.Windows.Forms.RadioButton();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.lb_resul = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt1_Jugar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.TabP.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabP
            // 
            this.TabP.Controls.Add(this.tabPage1);
            this.TabP.Controls.Add(this.tabPage2);
            this.TabP.Controls.Add(this.tabPage3);
            this.TabP.Location = new System.Drawing.Point(59, 44);
            this.TabP.Name = "TabP";
            this.TabP.SelectedIndex = 0;
            this.TabP.Size = new System.Drawing.Size(418, 311);
            this.TabP.TabIndex = 0;
            this.TabP.SelectedIndexChanged += new System.EventHandler(this.TabP_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(392, 273);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ficha 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(392, 273);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ficha 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_reset);
            this.tabPage3.Controls.Add(this.rb_tijeras);
            this.tabPage3.Controls.Add(this.rb_papel);
            this.tabPage3.Controls.Add(this.rb_piedra);
            this.tabPage3.Controls.Add(this.pb2);
            this.tabPage3.Controls.Add(this.pb1);
            this.tabPage3.Controls.Add(this.lb_resul);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.bt1_Jugar);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(410, 285);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Juego";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(302, 244);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 15;
            this.btn_reset.Text = "Resetear";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // rb_tijeras
            // 
            this.rb_tijeras.AutoSize = true;
            this.rb_tijeras.Location = new System.Drawing.Point(200, 46);
            this.rb_tijeras.Name = "rb_tijeras";
            this.rb_tijeras.Size = new System.Drawing.Size(56, 17);
            this.rb_tijeras.TabIndex = 14;
            this.rb_tijeras.TabStop = true;
            this.rb_tijeras.Text = "Tijeras";
            this.rb_tijeras.UseVisualStyleBackColor = true;
            this.rb_tijeras.CheckedChanged += new System.EventHandler(this.rb_tijeras_CheckedChanged);
            // 
            // rb_papel
            // 
            this.rb_papel.AutoSize = true;
            this.rb_papel.Cursor = System.Windows.Forms.Cursors.Default;
            this.rb_papel.Location = new System.Drawing.Point(109, 46);
            this.rb_papel.Name = "rb_papel";
            this.rb_papel.Size = new System.Drawing.Size(52, 17);
            this.rb_papel.TabIndex = 13;
            this.rb_papel.TabStop = true;
            this.rb_papel.Text = "Papel";
            this.rb_papel.UseVisualStyleBackColor = true;
            this.rb_papel.CheckedChanged += new System.EventHandler(this.rb_papel_CheckedChanged);
            // 
            // rb_piedra
            // 
            this.rb_piedra.AutoSize = true;
            this.rb_piedra.Location = new System.Drawing.Point(18, 46);
            this.rb_piedra.Name = "rb_piedra";
            this.rb_piedra.Size = new System.Drawing.Size(55, 17);
            this.rb_piedra.TabIndex = 12;
            this.rb_piedra.TabStop = true;
            this.rb_piedra.Text = "Piedra";
            this.rb_piedra.UseVisualStyleBackColor = true;
            this.rb_piedra.CheckedChanged += new System.EventHandler(this.rb_piedra_CheckedChanged);
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(221, 88);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(150, 150);
            this.pb2.TabIndex = 11;
            this.pb2.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(18, 88);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(150, 150);
            this.pb1.TabIndex = 10;
            this.pb1.TabStop = false;
            // 
            // lb_resul
            // 
            this.lb_resul.AutoSize = true;
            this.lb_resul.Location = new System.Drawing.Point(182, 254);
            this.lb_resul.Name = "lb_resul";
            this.lb_resul.Size = new System.Drawing.Size(31, 13);
            this.lb_resul.TabIndex = 9;
            this.lb_resul.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 63);
            this.label2.TabIndex = 5;
            this.label2.Text = "|";
            // 
            // bt1_Jugar
            // 
            this.bt1_Jugar.Location = new System.Drawing.Point(9, 244);
            this.bt1_Jugar.Name = "bt1_Jugar";
            this.bt1_Jugar.Size = new System.Drawing.Size(75, 23);
            this.bt1_Jugar.TabIndex = 3;
            this.bt1_Jugar.Text = "Jugar";
            this.bt1_Jugar.UseVisualStyleBackColor = true;
            this.bt1_Jugar.Click += new System.EventHandler(this.bt1_Jugar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione una:";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(56, 376);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(10, 13);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Ficha no seleccionada";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 409);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.TabP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TabP.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabP;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt1_Jugar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_resul;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.RadioButton rb_tijeras;
        private System.Windows.Forms.RadioButton rb_papel;
        private System.Windows.Forms.RadioButton rb_piedra;
        private System.Windows.Forms.Button btn_reset;
    }
}

