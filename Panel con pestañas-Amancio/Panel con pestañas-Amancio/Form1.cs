using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panel_con_pestañas_Amancio
{
    public partial class Form1 : Form
        
    {
       
        Boolean rock = false;
        Boolean paper = false;
        Boolean scissors = false;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void TabP_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb1.Text = TabP.SelectedTab.Text+" seleccionada";
        }


        private void bt1_Jugar_Click(object sender, EventArgs e)
        {
            try { 
            int enemy = r.Next(1, 4);
            if (rock == true)
            {
                pb1.Image = Properties.Resources.piedra;
                if ( enemy == 3 )
                {
                    pb2.Image = Properties.Resources.piedra; 
                    lb_resul.Text = "EMPATE";
                }else if (enemy == 1)
                {
                    pb2.Image = Properties.Resources.tijeras;
                    lb_resul.Text = "GANASTE";
                }
                else if (enemy == 2)
                    {
                    pb2.Image = Properties.Resources.papel;
                    lb_resul.Text = "PERDISTE";
                }
            }else if (paper == true)
            {
                pb1.Image = Properties.Resources.papel;
                if (enemy == 1)
                {
                    pb2.Image = Properties.Resources.tijeras;
                    lb_resul.Text = "PERDISTE";
                }
                else if (enemy == 3)
                {
                    pb2.Image = Properties.Resources.piedra;
                    lb_resul.Text = "GANASTE";
                }
                    else if(enemy == 2)
                {
                    pb2.Image = Properties.Resources.papel;
                    lb_resul.Text = "EMPATE";
                }
            }else if(scissors == true)
            {
                pb1.Image = Properties.Resources.tijeras;
                if (enemy == 2)
                {
                    pb2.Image = Properties.Resources.tijeras;
                    lb_resul.Text = "EMPATE";
                }
                else if (enemy == 3)
                {
                    pb2.Image = Properties.Resources.piedra;
                    lb_resul.Text = "PERDISTE";
                }
                else if(enemy ==1)
                {
                    pb2.Image = Properties.Resources.papel;
                    lb_resul.Text = "GANASTE";
                }
            }
            else
                {
                    MessageBox.Show("Seleccione una opcion para jugar");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void rb_piedra_CheckedChanged(object sender, EventArgs e)
        {
            rock = true;
            paper = false;
            scissors = false;
        }

        private void rb_tijeras_CheckedChanged(object sender, EventArgs e)
        {
            scissors = true;
            rock = false;
            paper = false;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            scissors = false;
            rock = false;
            paper = false;
            lb_resul.Text = "";
            rb_tijeras.Checked = false;
            rb_piedra.Checked = false;
            rb_papel.Checked = false;
            pb2.Image = null;
            pb1.Image = null;
        }

        private void rb_papel_CheckedChanged(object sender, EventArgs e)
        {
            paper = true;
            rock = false;
            scissors = false;
        }
    }
}
