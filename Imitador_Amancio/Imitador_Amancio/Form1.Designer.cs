namespace Imitador_Amancio
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
            this.gb_original = new System.Windows.Forms.GroupBox();
            this.nud_1 = new System.Windows.Forms.NumericUpDown();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.cmb_1 = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.chb_opcion6 = new System.Windows.Forms.CheckBox();
            this.chb_opcion5 = new System.Windows.Forms.CheckBox();
            this.chb_opcion4 = new System.Windows.Forms.CheckBox();
            this.rb_opcion3 = new System.Windows.Forms.RadioButton();
            this.rb_opcion2 = new System.Windows.Forms.RadioButton();
            this.rb_opcion1 = new System.Windows.Forms.RadioButton();
            this.gb_espejo = new System.Windows.Forms.GroupBox();
            this.nud_espejo2 = new System.Windows.Forms.NumericUpDown();
            this.chb_espejo_opcion5 = new System.Windows.Forms.CheckBox();
            this.cmb_espejo2 = new System.Windows.Forms.ComboBox();
            this.rb_espejo_opcion1 = new System.Windows.Forms.RadioButton();
            this.tb_espejo_2 = new System.Windows.Forms.TextBox();
            this.rb_espejo_opcion2 = new System.Windows.Forms.RadioButton();
            this.chb_espejo_opcion6 = new System.Windows.Forms.CheckBox();
            this.rb_espejo_opcion3 = new System.Windows.Forms.RadioButton();
            this.chb_espejo_opcion4 = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.lb_1 = new System.Windows.Forms.Label();
            this.lb_2 = new System.Windows.Forms.Label();
            this.gb_original.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_1)).BeginInit();
            this.gb_espejo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_espejo2)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_original
            // 
            this.gb_original.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gb_original.Controls.Add(this.lb_1);
            this.gb_original.Controls.Add(this.progressBar1);
            this.gb_original.Controls.Add(this.nud_1);
            this.gb_original.Controls.Add(this.splitter2);
            this.gb_original.Controls.Add(this.cmb_1);
            this.gb_original.Controls.Add(this.splitter1);
            this.gb_original.Controls.Add(this.tb_1);
            this.gb_original.Controls.Add(this.chb_opcion6);
            this.gb_original.Controls.Add(this.chb_opcion5);
            this.gb_original.Controls.Add(this.chb_opcion4);
            this.gb_original.Controls.Add(this.rb_opcion3);
            this.gb_original.Controls.Add(this.rb_opcion2);
            this.gb_original.Controls.Add(this.rb_opcion1);
            this.gb_original.ForeColor = System.Drawing.Color.Black;
            this.gb_original.Location = new System.Drawing.Point(1, 2);
            this.gb_original.Name = "gb_original";
            this.gb_original.Size = new System.Drawing.Size(476, 188);
            this.gb_original.TabIndex = 0;
            this.gb_original.TabStop = false;
            this.gb_original.Text = "Original";
            // 
            // nud_1
            // 
            this.nud_1.Location = new System.Drawing.Point(307, 120);
            this.nud_1.Name = "nud_1";
            this.nud_1.Size = new System.Drawing.Size(120, 22);
            this.nud_1.TabIndex = 10;
            this.nud_1.ValueChanged += new System.EventHandler(this.nud_1_ValueChanged);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(6, 18);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 167);
            this.splitter2.TabIndex = 9;
            this.splitter2.TabStop = false;
            // 
            // cmb_1
            // 
            this.cmb_1.FormattingEnabled = true;
            this.cmb_1.Items.AddRange(new object[] {
            "prueba 1",
            "prueba 2",
            "prueba 3"});
            this.cmb_1.Location = new System.Drawing.Point(306, 77);
            this.cmb_1.Name = "cmb_1";
            this.cmb_1.Size = new System.Drawing.Size(121, 24);
            this.cmb_1.TabIndex = 8;
            this.cmb_1.SelectedIndexChanged += new System.EventHandler(this.cmb_1_SelectedIndexChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(3, 18);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 167);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // tb_1
            // 
            this.tb_1.Location = new System.Drawing.Point(307, 40);
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(120, 22);
            this.tb_1.TabIndex = 6;
            this.tb_1.TextChanged += new System.EventHandler(this.tb_1_TextChanged);
            // 
            // chb_opcion6
            // 
            this.chb_opcion6.AutoSize = true;
            this.chb_opcion6.Location = new System.Drawing.Point(187, 94);
            this.chb_opcion6.Name = "chb_opcion6";
            this.chb_opcion6.Size = new System.Drawing.Size(82, 20);
            this.chb_opcion6.TabIndex = 5;
            this.chb_opcion6.Text = "Opcion 6";
            this.chb_opcion6.UseVisualStyleBackColor = true;
            this.chb_opcion6.CheckedChanged += new System.EventHandler(this.chb_opcion6_CheckedChanged);
            // 
            // chb_opcion5
            // 
            this.chb_opcion5.AutoSize = true;
            this.chb_opcion5.Location = new System.Drawing.Point(187, 67);
            this.chb_opcion5.Name = "chb_opcion5";
            this.chb_opcion5.Size = new System.Drawing.Size(82, 20);
            this.chb_opcion5.TabIndex = 4;
            this.chb_opcion5.Text = "Opcion 5";
            this.chb_opcion5.UseVisualStyleBackColor = true;
            this.chb_opcion5.CheckedChanged += new System.EventHandler(this.chb_opcion5_CheckedChanged);
            // 
            // chb_opcion4
            // 
            this.chb_opcion4.AutoSize = true;
            this.chb_opcion4.Location = new System.Drawing.Point(187, 40);
            this.chb_opcion4.Name = "chb_opcion4";
            this.chb_opcion4.Size = new System.Drawing.Size(82, 20);
            this.chb_opcion4.TabIndex = 3;
            this.chb_opcion4.Text = "Opcion 4";
            this.chb_opcion4.UseVisualStyleBackColor = true;
            this.chb_opcion4.CheckedChanged += new System.EventHandler(this.chb_opcion4_CheckedChanged);
            // 
            // rb_opcion3
            // 
            this.rb_opcion3.AutoSize = true;
            this.rb_opcion3.Location = new System.Drawing.Point(26, 91);
            this.rb_opcion3.Name = "rb_opcion3";
            this.rb_opcion3.Size = new System.Drawing.Size(81, 20);
            this.rb_opcion3.TabIndex = 2;
            this.rb_opcion3.TabStop = true;
            this.rb_opcion3.Text = "Opcion 3";
            this.rb_opcion3.UseVisualStyleBackColor = true;
            this.rb_opcion3.CheckedChanged += new System.EventHandler(this.rb_opcion3_CheckedChanged);
            // 
            // rb_opcion2
            // 
            this.rb_opcion2.AutoSize = true;
            this.rb_opcion2.Location = new System.Drawing.Point(26, 65);
            this.rb_opcion2.Name = "rb_opcion2";
            this.rb_opcion2.Size = new System.Drawing.Size(81, 20);
            this.rb_opcion2.TabIndex = 1;
            this.rb_opcion2.TabStop = true;
            this.rb_opcion2.Text = "Opcion 2";
            this.rb_opcion2.UseVisualStyleBackColor = true;
            this.rb_opcion2.CheckedChanged += new System.EventHandler(this.rb_opcion2_CheckedChanged);
            // 
            // rb_opcion1
            // 
            this.rb_opcion1.AutoSize = true;
            this.rb_opcion1.Location = new System.Drawing.Point(26, 39);
            this.rb_opcion1.Name = "rb_opcion1";
            this.rb_opcion1.Size = new System.Drawing.Size(78, 20);
            this.rb_opcion1.TabIndex = 0;
            this.rb_opcion1.TabStop = true;
            this.rb_opcion1.Text = "Opcion1";
            this.rb_opcion1.UseVisualStyleBackColor = true;
            this.rb_opcion1.CheckedChanged += new System.EventHandler(this.rb_opcion1_CheckedChanged);
            // 
            // gb_espejo
            // 
            this.gb_espejo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gb_espejo.Controls.Add(this.lb_2);
            this.gb_espejo.Controls.Add(this.progressBar2);
            this.gb_espejo.Controls.Add(this.nud_espejo2);
            this.gb_espejo.Controls.Add(this.chb_espejo_opcion5);
            this.gb_espejo.Controls.Add(this.cmb_espejo2);
            this.gb_espejo.Controls.Add(this.rb_espejo_opcion1);
            this.gb_espejo.Controls.Add(this.tb_espejo_2);
            this.gb_espejo.Controls.Add(this.rb_espejo_opcion2);
            this.gb_espejo.Controls.Add(this.chb_espejo_opcion6);
            this.gb_espejo.Controls.Add(this.rb_espejo_opcion3);
            this.gb_espejo.Controls.Add(this.chb_espejo_opcion4);
            this.gb_espejo.Location = new System.Drawing.Point(4, 193);
            this.gb_espejo.Name = "gb_espejo";
            this.gb_espejo.Size = new System.Drawing.Size(476, 188);
            this.gb_espejo.TabIndex = 1;
            this.gb_espejo.TabStop = false;
            this.gb_espejo.Text = "Espejo";
            // 
            // nud_espejo2
            // 
            this.nud_espejo2.Enabled = false;
            this.nud_espejo2.Location = new System.Drawing.Point(304, 111);
            this.nud_espejo2.Name = "nud_espejo2";
            this.nud_espejo2.Size = new System.Drawing.Size(120, 22);
            this.nud_espejo2.TabIndex = 19;
            // 
            // chb_espejo_opcion5
            // 
            this.chb_espejo_opcion5.AutoSize = true;
            this.chb_espejo_opcion5.Enabled = false;
            this.chb_espejo_opcion5.Location = new System.Drawing.Point(184, 58);
            this.chb_espejo_opcion5.Name = "chb_espejo_opcion5";
            this.chb_espejo_opcion5.Size = new System.Drawing.Size(82, 20);
            this.chb_espejo_opcion5.TabIndex = 15;
            this.chb_espejo_opcion5.Text = "Opcion 5";
            this.chb_espejo_opcion5.UseVisualStyleBackColor = true;
            // 
            // cmb_espejo2
            // 
            this.cmb_espejo2.Enabled = false;
            this.cmb_espejo2.FormattingEnabled = true;
            this.cmb_espejo2.Location = new System.Drawing.Point(303, 68);
            this.cmb_espejo2.Name = "cmb_espejo2";
            this.cmb_espejo2.Size = new System.Drawing.Size(121, 24);
            this.cmb_espejo2.TabIndex = 18;
            // 
            // rb_espejo_opcion1
            // 
            this.rb_espejo_opcion1.AutoSize = true;
            this.rb_espejo_opcion1.Enabled = false;
            this.rb_espejo_opcion1.Location = new System.Drawing.Point(23, 30);
            this.rb_espejo_opcion1.Name = "rb_espejo_opcion1";
            this.rb_espejo_opcion1.Size = new System.Drawing.Size(78, 20);
            this.rb_espejo_opcion1.TabIndex = 11;
            this.rb_espejo_opcion1.TabStop = true;
            this.rb_espejo_opcion1.Text = "Opcion1";
            this.rb_espejo_opcion1.UseVisualStyleBackColor = true;
            // 
            // tb_espejo_2
            // 
            this.tb_espejo_2.Enabled = false;
            this.tb_espejo_2.Location = new System.Drawing.Point(304, 31);
            this.tb_espejo_2.Name = "tb_espejo_2";
            this.tb_espejo_2.Size = new System.Drawing.Size(120, 22);
            this.tb_espejo_2.TabIndex = 17;
            // 
            // rb_espejo_opcion2
            // 
            this.rb_espejo_opcion2.AutoSize = true;
            this.rb_espejo_opcion2.Enabled = false;
            this.rb_espejo_opcion2.Location = new System.Drawing.Point(23, 56);
            this.rb_espejo_opcion2.Name = "rb_espejo_opcion2";
            this.rb_espejo_opcion2.Size = new System.Drawing.Size(81, 20);
            this.rb_espejo_opcion2.TabIndex = 12;
            this.rb_espejo_opcion2.TabStop = true;
            this.rb_espejo_opcion2.Text = "Opcion 2";
            this.rb_espejo_opcion2.UseVisualStyleBackColor = true;
            // 
            // chb_espejo_opcion6
            // 
            this.chb_espejo_opcion6.AutoSize = true;
            this.chb_espejo_opcion6.Enabled = false;
            this.chb_espejo_opcion6.Location = new System.Drawing.Point(184, 85);
            this.chb_espejo_opcion6.Name = "chb_espejo_opcion6";
            this.chb_espejo_opcion6.Size = new System.Drawing.Size(82, 20);
            this.chb_espejo_opcion6.TabIndex = 16;
            this.chb_espejo_opcion6.Text = "Opcion 6";
            this.chb_espejo_opcion6.UseVisualStyleBackColor = true;
            // 
            // rb_espejo_opcion3
            // 
            this.rb_espejo_opcion3.AutoSize = true;
            this.rb_espejo_opcion3.Enabled = false;
            this.rb_espejo_opcion3.Location = new System.Drawing.Point(23, 82);
            this.rb_espejo_opcion3.Name = "rb_espejo_opcion3";
            this.rb_espejo_opcion3.Size = new System.Drawing.Size(81, 20);
            this.rb_espejo_opcion3.TabIndex = 13;
            this.rb_espejo_opcion3.TabStop = true;
            this.rb_espejo_opcion3.Text = "Opcion 3";
            this.rb_espejo_opcion3.UseVisualStyleBackColor = true;
            // 
            // chb_espejo_opcion4
            // 
            this.chb_espejo_opcion4.AutoSize = true;
            this.chb_espejo_opcion4.Enabled = false;
            this.chb_espejo_opcion4.Location = new System.Drawing.Point(184, 31);
            this.chb_espejo_opcion4.Name = "chb_espejo_opcion4";
            this.chb_espejo_opcion4.Size = new System.Drawing.Size(82, 20);
            this.chb_espejo_opcion4.TabIndex = 14;
            this.chb_espejo_opcion4.Text = "Opcion 4";
            this.chb_espejo_opcion4.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(28, 147);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(241, 23);
            this.progressBar1.TabIndex = 20;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(25, 154);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(241, 23);
            this.progressBar2.TabIndex = 21;
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Location = new System.Drawing.Point(97, 154);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(109, 16);
            this.lb_1.TabIndex = 21;
            this.lb_1.Text = "COMPLETADO!!!";
            // 
            // lb_2
            // 
            this.lb_2.AutoSize = true;
            this.lb_2.Location = new System.Drawing.Point(94, 161);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(109, 16);
            this.lb_2.TabIndex = 22;
            this.lb_2.Text = "COMPLETADO!!!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 382);
            this.Controls.Add(this.gb_espejo);
            this.Controls.Add(this.gb_original);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_original.ResumeLayout(false);
            this.gb_original.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_1)).EndInit();
            this.gb_espejo.ResumeLayout(false);
            this.gb_espejo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_espejo2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_original;
        private System.Windows.Forms.GroupBox gb_espejo;
        private System.Windows.Forms.CheckBox chb_opcion4;
        private System.Windows.Forms.RadioButton rb_opcion3;
        private System.Windows.Forms.RadioButton rb_opcion2;
        private System.Windows.Forms.RadioButton rb_opcion1;
        private System.Windows.Forms.CheckBox chb_opcion6;
        private System.Windows.Forms.CheckBox chb_opcion5;
        private System.Windows.Forms.NumericUpDown nud_1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.ComboBox cmb_1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.NumericUpDown nud_espejo2;
        private System.Windows.Forms.CheckBox chb_espejo_opcion5;
        private System.Windows.Forms.ComboBox cmb_espejo2;
        private System.Windows.Forms.RadioButton rb_espejo_opcion1;
        private System.Windows.Forms.TextBox tb_espejo_2;
        private System.Windows.Forms.RadioButton rb_espejo_opcion2;
        private System.Windows.Forms.CheckBox chb_espejo_opcion6;
        private System.Windows.Forms.RadioButton rb_espejo_opcion3;
        private System.Windows.Forms.CheckBox chb_espejo_opcion4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.Label lb_2;
    }
}

