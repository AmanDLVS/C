namespace Reserva_hotelera_Amancio
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
            this.lb_titulo = new System.Windows.Forms.Label();
            this.lbk_aboutus = new System.Windows.Forms.LinkLabel();
            this.lbk_Redes = new System.Windows.Forms.LinkLabel();
            this.lbk_SoporteCliente = new System.Windows.Forms.LinkLabel();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.lb_usuario = new System.Windows.Forms.Label();
            this.lb_pass = new System.Windows.Forms.Label();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.pb_mostrarpass = new System.Windows.Forms.PictureBox();
            this.pb_vercontraseña = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_mostrarpass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_vercontraseña)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lb_titulo.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = System.Drawing.Color.White;
            this.lb_titulo.Location = new System.Drawing.Point(28, 9);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(731, 108);
            this.lb_titulo.TabIndex = 0;
            this.lb_titulo.Text = "SALON HABANA";
            // 
            // lbk_aboutus
            // 
            this.lbk_aboutus.AutoSize = true;
            this.lbk_aboutus.BackColor = System.Drawing.Color.Transparent;
            this.lbk_aboutus.LinkColor = System.Drawing.Color.White;
            this.lbk_aboutus.Location = new System.Drawing.Point(165, 446);
            this.lbk_aboutus.Name = "lbk_aboutus";
            this.lbk_aboutus.Size = new System.Drawing.Size(59, 16);
            this.lbk_aboutus.TabIndex = 5;
            this.lbk_aboutus.TabStop = true;
            this.lbk_aboutus.Text = "About us";
            this.lbk_aboutus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbk_aboutus_LinkClicked);
            // 
            // lbk_Redes
            // 
            this.lbk_Redes.AutoSize = true;
            this.lbk_Redes.BackColor = System.Drawing.Color.Transparent;
            this.lbk_Redes.LinkColor = System.Drawing.Color.White;
            this.lbk_Redes.Location = new System.Drawing.Point(319, 446);
            this.lbk_Redes.Name = "lbk_Redes";
            this.lbk_Redes.Size = new System.Drawing.Size(97, 16);
            this.lbk_Redes.TabIndex = 6;
            this.lbk_Redes.TabStop = true;
            this.lbk_Redes.Text = "Rede Sociales";
            this.lbk_Redes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbk_Redes_LinkClicked);
            // 
            // lbk_SoporteCliente
            // 
            this.lbk_SoporteCliente.AutoSize = true;
            this.lbk_SoporteCliente.BackColor = System.Drawing.Color.Transparent;
            this.lbk_SoporteCliente.LinkColor = System.Drawing.Color.White;
            this.lbk_SoporteCliente.Location = new System.Drawing.Point(476, 446);
            this.lbk_SoporteCliente.Name = "lbk_SoporteCliente";
            this.lbk_SoporteCliente.Size = new System.Drawing.Size(113, 16);
            this.lbk_SoporteCliente.TabIndex = 7;
            this.lbk_SoporteCliente.TabStop = true;
            this.lbk_SoporteCliente.Text = "Soporte al Cliente";
            this.lbk_SoporteCliente.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbk_SoporteCliente_LinkClicked);
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(241, 175);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(243, 22);
            this.tb_user.TabIndex = 8;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(241, 262);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.Size = new System.Drawing.Size(243, 22);
            this.tb_pass.TabIndex = 9;
            // 
            // lb_usuario
            // 
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.BackColor = System.Drawing.Color.Transparent;
            this.lb_usuario.ForeColor = System.Drawing.Color.White;
            this.lb_usuario.Location = new System.Drawing.Point(238, 146);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(60, 16);
            this.lb_usuario.TabIndex = 10;
            this.lb_usuario.Text = "Usuario: ";
            this.lb_usuario.Click += new System.EventHandler(this.lb_usuario_Click);
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.BackColor = System.Drawing.Color.Transparent;
            this.lb_pass.ForeColor = System.Drawing.Color.White;
            this.lb_pass.Location = new System.Drawing.Point(238, 243);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(82, 16);
            this.lb_pass.TabIndex = 11;
            this.lb_pass.Text = "Contraseña: ";
            this.lb_pass.Click += new System.EventHandler(this.lb_pass_Click);
            // 
            // btn_entrar
            // 
            this.btn_entrar.Location = new System.Drawing.Point(406, 337);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(143, 33);
            this.btn_entrar.TabIndex = 13;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(241, 337);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(159, 33);
            this.btn_registrar.TabIndex = 14;
            this.btn_registrar.Text = "No estoy registrado";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // pb_mostrarpass
            // 
            this.pb_mostrarpass.BackColor = System.Drawing.Color.Transparent;
            this.pb_mostrarpass.Image = global::Reserva_hotelera_Amancio.Properties.Resources.iconomostrarpass;
            this.pb_mostrarpass.Location = new System.Drawing.Point(490, 252);
            this.pb_mostrarpass.Name = "pb_mostrarpass";
            this.pb_mostrarpass.Size = new System.Drawing.Size(59, 41);
            this.pb_mostrarpass.TabIndex = 15;
            this.pb_mostrarpass.TabStop = false;
            this.pb_mostrarpass.Click += new System.EventHandler(this.pb_mostrarpass_Click);
            // 
            // pb_vercontraseña
            // 
            this.pb_vercontraseña.BackColor = System.Drawing.Color.Transparent;
            this.pb_vercontraseña.Image = global::Reserva_hotelera_Amancio.Properties.Resources.pass;
            this.pb_vercontraseña.Location = new System.Drawing.Point(490, 252);
            this.pb_vercontraseña.Name = "pb_vercontraseña";
            this.pb_vercontraseña.Size = new System.Drawing.Size(59, 41);
            this.pb_vercontraseña.TabIndex = 16;
            this.pb_vercontraseña.TabStop = false;
            this.pb_vercontraseña.Click += new System.EventHandler(this.pb_vercontraseña_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Reserva_hotelera_Amancio.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(824, 514);
            this.Controls.Add(this.pb_mostrarpass);
            this.Controls.Add(this.pb_vercontraseña);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.lb_pass);
            this.Controls.Add(this.lb_usuario);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.lbk_SoporteCliente);
            this.Controls.Add(this.lbk_Redes);
            this.Controls.Add(this.lbk_aboutus);
            this.Controls.Add(this.lb_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_mostrarpass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_vercontraseña)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.LinkLabel lbk_aboutus;
        private System.Windows.Forms.LinkLabel lbk_Redes;
        private System.Windows.Forms.LinkLabel lbk_SoporteCliente;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label lb_usuario;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.PictureBox pb_mostrarpass;
        private System.Windows.Forms.PictureBox pb_vercontraseña;
    }
}

