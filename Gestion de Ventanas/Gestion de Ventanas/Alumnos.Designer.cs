namespace Gestion_de_Ventanas
{
    partial class Alumnos
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
            this.txt_Nombre_comp = new System.Windows.Forms.TextBox();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.chk_M = new System.Windows.Forms.CheckBox();
            this.chk_F = new System.Windows.Forms.CheckBox();
            this.chk_ti = new System.Windows.Forms.CheckBox();
            this.chk_od = new System.Windows.Forms.CheckBox();
            this.btn_reg = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.txt_dc = new System.Windows.Forms.TextBox();
            this.cmb_curso = new System.Windows.Forms.ComboBox();
            this.cmb_horario = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_Nombre_comp
            // 
            this.txt_Nombre_comp.Location = new System.Drawing.Point(239, 39);
            this.txt_Nombre_comp.Name = "txt_Nombre_comp";
            this.txt_Nombre_comp.Size = new System.Drawing.Size(272, 22);
            this.txt_Nombre_comp.TabIndex = 0;
            // 
            // txt_edad
            // 
            this.txt_edad.Location = new System.Drawing.Point(239, 120);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(76, 22);
            this.txt_edad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre Completo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha de nacimiento: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Edad: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Curso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Horario";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(239, 83);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(200, 22);
            this.dtp_fecha.TabIndex = 10;
            // 
            // chk_M
            // 
            this.chk_M.AutoSize = true;
            this.chk_M.Location = new System.Drawing.Point(239, 164);
            this.chk_M.Name = "chk_M";
            this.chk_M.Size = new System.Drawing.Size(90, 20);
            this.chk_M.TabIndex = 11;
            this.chk_M.Text = "Masculino";
            this.chk_M.UseVisualStyleBackColor = true;
            // 
            // chk_F
            // 
            this.chk_F.AutoSize = true;
            this.chk_F.Location = new System.Drawing.Point(403, 165);
            this.chk_F.Name = "chk_F";
            this.chk_F.Size = new System.Drawing.Size(89, 20);
            this.chk_F.TabIndex = 12;
            this.chk_F.Text = "Femenino";
            this.chk_F.UseVisualStyleBackColor = true;
            // 
            // chk_ti
            // 
            this.chk_ti.AutoSize = true;
            this.chk_ti.Location = new System.Drawing.Point(92, 335);
            this.chk_ti.Name = "chk_ti";
            this.chk_ti.Size = new System.Drawing.Size(44, 20);
            this.chk_ti.TabIndex = 13;
            this.chk_ti.Text = "T.I";
            this.chk_ti.UseVisualStyleBackColor = true;
            // 
            // chk_od
            // 
            this.chk_od.AutoSize = true;
            this.chk_od.Location = new System.Drawing.Point(215, 335);
            this.chk_od.Name = "chk_od";
            this.chk_od.Size = new System.Drawing.Size(124, 20);
            this.chk_od.TabIndex = 14;
            this.chk_od.Text = "Otro documento";
            this.chk_od.UseVisualStyleBackColor = true;
            // 
            // btn_reg
            // 
            this.btn_reg.Location = new System.Drawing.Point(12, 418);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(92, 34);
            this.btn_reg.TabIndex = 15;
            this.btn_reg.Text = "Regsitrar";
            this.btn_reg.UseVisualStyleBackColor = true;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(482, 418);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(92, 34);
            this.btn_salir.TabIndex = 16;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // txt_dc
            // 
            this.txt_dc.Location = new System.Drawing.Point(215, 375);
            this.txt_dc.Name = "txt_dc";
            this.txt_dc.Size = new System.Drawing.Size(150, 22);
            this.txt_dc.TabIndex = 17;
            // 
            // cmb_curso
            // 
            this.cmb_curso.FormattingEnabled = true;
            this.cmb_curso.Location = new System.Drawing.Point(239, 229);
            this.cmb_curso.Name = "cmb_curso";
            this.cmb_curso.Size = new System.Drawing.Size(272, 24);
            this.cmb_curso.TabIndex = 18;
            // 
            // cmb_horario
            // 
            this.cmb_horario.FormattingEnabled = true;
            this.cmb_horario.Location = new System.Drawing.Point(239, 281);
            this.cmb_horario.Name = "cmb_horario";
            this.cmb_horario.Size = new System.Drawing.Size(272, 24);
            this.cmb_horario.TabIndex = 19;
            // 
            // Profesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 468);
            this.Controls.Add(this.cmb_horario);
            this.Controls.Add(this.cmb_curso);
            this.Controls.Add(this.txt_dc);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.chk_od);
            this.Controls.Add(this.chk_ti);
            this.Controls.Add(this.chk_F);
            this.Controls.Add(this.chk_M);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_edad);
            this.Controls.Add(this.txt_Nombre_comp);
            this.Name = "Profesores";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Nombre_comp;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.CheckBox chk_M;
        private System.Windows.Forms.CheckBox chk_F;
        private System.Windows.Forms.CheckBox chk_ti;
        private System.Windows.Forms.CheckBox chk_od;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.TextBox txt_dc;
        private System.Windows.Forms.ComboBox cmb_curso;
        private System.Windows.Forms.ComboBox cmb_horario;
    }
}