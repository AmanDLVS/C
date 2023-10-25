using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Ventanas
{
    public partial class Profesores : Form
    {
        public Profesores()
        {
            InitializeComponent();
            cmb_curso.Items.Add("ESO");
            cmb_curso.Items.Add("DAM");
            cmb_curso.Items.Add("BACH");
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nombre completo: "+txt_Nombre_comp.Text);
            MessageBox.Show("Fecha de nacimiento: "+dtp_fecha.Value);
            MessageBox.Show("Edad: " + txt_edad.Text);
            if (chk_M.Checked)
            {
                MessageBox.Show("Sexo Masculino");
            }else if (chk_F.Checked)
            {
                MessageBox.Show("Sexo Femenino");
            }else
            {
                MessageBox.Show("Sexo no especificado");
            }
            
            MessageBox.Show("Curso: " + cmb_curso.Text);
            MessageBox.Show("Horario: " + cmb_horario.Text);
            if (chk_ti.Checked)
            {
                MessageBox.Show("T.I seleccionado");
            }
            else if (chk_od.Checked)
            {
                MessageBox.Show("Documento: "+txt_dc.Text);
            }
            else
            {
                MessageBox.Show("Archivo no especificado");
            }


        }
    }
}
