using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imitador_Amancio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lb_1.Visible = false;
            lb_2.Visible = false;    
        }

        

        private void rb_opcion1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_opcion1.Checked)
            {
                rb_espejo_opcion1.Checked = true;
            }

        }

        private void rb_opcion2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_opcion2.Checked)
            {
                rb_espejo_opcion2.Checked = true;
            }
        }

        private void rb_opcion3_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_opcion3.Checked)
            {
                rb_espejo_opcion3.Checked = true;
            }
        }

        private void chb_opcion4_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_opcion4.Checked)
            {
                chb_espejo_opcion4.Checked= true;
            }
            else
            {
                chb_espejo_opcion4.Checked = false;
            }
        }

        private void chb_opcion5_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_opcion5.Checked)
            {
                chb_espejo_opcion5.Checked = true;
            }
            else
            {
                chb_espejo_opcion5.Checked = false;
            }
        }

        private void chb_opcion6_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_opcion6.Checked)
            {
                chb_espejo_opcion6.Checked = true;
            }
            else
            {
                chb_espejo_opcion6.Checked = false;
            }
        }

        private void tb_1_TextChanged(object sender, EventArgs e)
        {
            tb_espejo_2.Text = tb_1.Text;
        }

        private void nud_1_ValueChanged(object sender, EventArgs e)
        {
            nud_espejo2.Value = nud_1.Value;
            try
            { 
            progressBar1.Value = ((int)nud_1.Value) * 10;
            progressBar2.Value = ((int)nud_1.Value) * 10;
            }catch (Exception ex)
            {
                progressBar1.Visible = false;
                progressBar2.Visible = false;   
                lb_1.Visible = true;
                lb_2.Visible = true;
                
            }
        }

        private void cmb_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_espejo2.Text = cmb_1.SelectedItem.ToString();

        }
    }
}
