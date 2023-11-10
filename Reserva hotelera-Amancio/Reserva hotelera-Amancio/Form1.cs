using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Reserva_hotelera_Amancio
{
    public partial class Form1 : Form
    {
        String user;
        String pass;
        ToolTip tultip = new ToolTip();
        
        public Form1()
        {
            InitializeComponent();
            tultip.SetToolTip(pb_mostrarpass, "Mostrar contraseña");
            tultip.SetToolTip(pb_vercontraseña,"Ocultar contraseña");
            tultip.SetToolTip(lb_titulo, "Titulo del salon");
            tultip.SetToolTip(lb_usuario,"Insertar nombre del usuario (en la cuenta), esto se conectaria a una base de datos");
            tultip.SetToolTip(lb_pass, "Insertar contraseña del usuario, en el caso de que se conectase a una base de datos");
        }
        public String getUser()
        {
            return user;
        }
        public void setUser(String us)
        {
            this.user = us;
        }

      

        public void setPass(String p)
        {
            this.pass = p;
        }
        private void lbk_aboutus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData as string);
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            lbk_aboutus.Links.Add(0, 30, "https://github.com/AmanDLVS");
            lbk_Redes.Links.Add(0,30, "https://github.com/AmanDLVS");
            lbk_SoporteCliente.Links.Add(0, 30, "https://github.com/AmanDLVS");
        }

        private void lbk_Redes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData as string);

        }

        private void lbk_SoporteCliente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData as string);

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[a-zA-ZñÑ]*$");

            if (regex.IsMatch(tb_user.Text) && regex.IsMatch(tb_pass.Text))
            {
                if (tb_user.Text!="" && tb_pass.Text!="") { 
                Form3 f3 = new Form3();
                f3.setLB(tb_user.Text);
                f3.ShowDialog();
                }else
                {
                    MessageBox.Show("No se permiten campos en blanco");
                    tb_user.Text = "";
                    tb_pass.Text = "";
                }
            }
            else
            {
                MessageBox.Show("El formato de nombnre de usuario no es correcto\nPorfavor ingrese solamente letras, mayusculas o minusculas. ", "Error");
            }
            
            
        }

        private void pb_mostrarpass_Click(object sender, EventArgs e)
        {
            pb_mostrarpass.Visible = false ;
            pb_vercontraseña.Visible = true;
            tb_pass.PasswordChar = '\0';
        }

        private void pb_vercontraseña_Click(object sender, EventArgs e)
        {
            pb_mostrarpass.Visible = true;
            pb_vercontraseña.Visible = false;
            tb_pass.PasswordChar = '*';
        }

        private void lb_usuario_Click(object sender, EventArgs e)
        {

        }

        private void lb_pass_Click(object sender, EventArgs e)
        {

        }
    }
}
