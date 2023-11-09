using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dibujos_animados_Amancio
{
    public partial class form_juego : Form
    {
        Random r = new Random();
        int cont_bombas = 2;
        int contador_aciertos = 0;
        int max_aciertos = 0;

       
        public form_juego()
        { 
            InitializeComponent();
            asignBombas();
        }
        private void asignBombas()
        {
            switch(cont_bombas){
                case 1:
                    max_aciertos = 8;
                    break;
                case 2:
                    max_aciertos = 7;
                    break;
                case 3:
                    max_aciertos = 6;
                    break;
            }
        }
      
        private void bombita(object sender, EventArgs e)
        {
            
            
            if (cont_bombas >= 0)
            {
                Button btna = (Button)sender;
                if (r.Next(0,2)==1)
                {
                    
                    btna.Image = Properties.Resources.explosion;
                    cont_bombas--;
                    btna.Enabled = false;
                }
                else
                {
                    btna.Visible = false;
                    contador_aciertos++;
                    lbcont.Text = contador_aciertos + "";
                }
            }else
            {
                MessageBox.Show("HAS PERDIDO", "Derrota");
                groupBox1.Enabled = false;
            }
            if (contador_aciertos == max_aciertos)
            {
                MessageBox.Show("HAS GANADO", "Victoria");

            }
            else if (cont_bombas == 0)
            {
                MessageBox.Show("HAS PERDIDO", "Derrota");
                groupBox1.Enabled = false;
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            cont_bombas = Decimal.ToInt32(numericUpDown1.Value);
            asignBombas();
        }

        //Perdon por el metodo pero lo hice de correprisas, me habria gustado usar arrayList para poder organizar todos los botones y usarlo mas scomodo pero lo hice a lo bruto :(
        private void btn_resetear_Click(object sender, EventArgs e)
        {
            //No se me habilitaban todos los botones por lo que lo hice a mano :(
            groupBox1.Enabled = true;
            
            btn1_juego.Enabled = true;
            btn2_juego.Enabled = true;
            btn3_juego.Enabled = true;
            btn4_juego.Enabled = true;
            btn5_juego.Enabled = true;
            btn6_juego.Enabled = true;
            btn7_juego.Enabled = true;
            btn8_juego.Enabled = true;
            btn9_juego.Enabled = true;

            btn1_juego.Visible = true;
            btn2_juego.Visible = true;
            btn3_juego.Visible = true;
            btn4_juego.Visible = true;
            btn5_juego.Visible = true;
            btn6_juego.Visible = true;
            btn7_juego.Visible = true;
            btn8_juego.Visible = true;
            btn9_juego.Visible = true;

            btn1_juego.Image = null;
            btn2_juego.Image = null;
            btn3_juego.Image = null;
            btn4_juego.Image = null;
            btn5_juego.Image = null;
            btn6_juego.Image = null;
            btn7_juego.Image = null;
            btn8_juego.Image = null;
            btn9_juego.Image = null;
                     
            lbcont.Text = 0+"";
            contador_aciertos = 0;
            cont_bombas = Decimal.ToInt32(numericUpDown1.Value);
        }
    }
}
