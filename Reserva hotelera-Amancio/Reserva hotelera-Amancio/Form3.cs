using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reserva_hotelera_Amancio
{
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
            
        }

        private void rb_congreso_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_congreso.Checked == true)
            {
                lb_jornadas.Enabled = true;
                nup_num_jornadas.Enabled = true;            
                rb_habitacion_si.Enabled = true;
                rb_habitacion_no.Enabled = true;
            }else
            {
                lb_jornadas.Enabled = false;
                nup_num_jornadas.Enabled = false;
                rb_habitacion_si.Enabled = false;
                rb_habitacion_no.Enabled = false;
            }
        }

        private void rb_habitacion_si_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_habitacion_si.Checked == true)
            {
                lb_habitaciones_num.Visible = true;
                nup_habitaciones.Visible = true;
            }
            else
            {
                lb_habitaciones_num.Visible = false;
                nup_habitaciones.Visible = false;
            }
        }

        public void setLB(String a)
        {
            lb_usuario_reg.Text = lb_usuario_reg.Text + " " + a;
        }
  

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rb_pedircita_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_pedircita.Checked == true)
            {
                lb_citachef.Visible = true;
                tb_correo.Visible = true;
                lb_introcorreo.Visible = true;
            }else
            {
                lb_citachef.Visible = false;
                tb_correo .Visible = false;
                lb_introcorreo .Visible = false;
            }
            
        }
    }
}
