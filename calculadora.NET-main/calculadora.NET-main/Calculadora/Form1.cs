using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private String Op1;
        private String Op2;
        private double Res;
        private double Ans;
        private Boolean b;
        private Boolean s;
        private Boolean r;
        private Boolean d;
        private Boolean m;
        private Boolean de;
        private double pesados;

        public Form1()
        {
            InitializeComponent();
            Op1 ="";
            Op2 ="";    
            Res = 0.0; 
            Ans = 0.0;
            b = false;
            s = false;
            r = false;  
            d = false;
            m = false;
            de = false;
            pesados = 9999999999999999999999999999999999999.0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (b == false) {
                
                Op1 = Op1 +"1";
                textBox1.AppendText("1");
            }
            else
            {
                Op2 = Op2 + "1";
                textBox1.AppendText("1");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (b == false)
            {
                Op1 = Op1+"2";
                textBox1.AppendText("2");
            }
            else
            {
                Op2 = Op2+"2";
                textBox1.AppendText("2");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (b == false)
            {
                Op1 = Op1+"3";
                textBox1.AppendText("3");

            }
            else
            {
                Op2 = Op2+"3";
                textBox1.AppendText("3");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (b == false)
            {
                Op1 = Op1 + "4";
                textBox1.AppendText("4");

            }
            else
            {
                Op2 = Op2 + "4";
                textBox1.AppendText("4");

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (b == false)
            {
                Op1 = Op1 + "5";
                textBox1.AppendText("5");
            }
            else
            {
                Op2 = Op2 + "5";
                textBox1.AppendText("5");

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (b == false)
            {
                Op1 = Op1 + "6";
                textBox1.AppendText("6");
            }
            else
            {
                Op2 = Op2 + "6";
                textBox1.AppendText("6");

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (b == false)
            {
                Op1 = Op1 + "7";
                textBox1.AppendText("7");
            }
            else
            {
                Op2 = Op2 + "7";
                textBox1.AppendText("7");

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (b == false)
            {
                Op1 =   Op1 + "8";
                textBox1.AppendText("8");
            }
            else
            {
                Op2 = Op2 + "8";
                textBox1.AppendText("8");

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (b == false)
            {
                Op1 = Op1 + "9";
                textBox1.AppendText("9");

            }
            else
            {

                Op2 = Op2 + "9";
                textBox1.AppendText("9");

            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (b == false)
            {
                Op1 = Op1 + "0";
                textBox1.AppendText("0");
            }
            else
            {
                Op2 = Op2 + "0";
                textBox1.AppendText("0");
            }
        }

        private void btnjastag_Click(object sender, EventArgs e)
        {
            Op1 = "";
            Op2 = "";
            Res = 0;
            textBox1.ResetText();
            r = false;
            s = false;
            d = false;
            b = false;
            m = false;
            de = false;
            btnsuma.Visible = true;
            btnmultiplicar.Visible = true;
            btnresta.Visible = true;
            btndividir.Visible = true;
            button10.Visible = true;
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            de = false;
            m = false;
            d = false;
            r = false;
            s = true;
            b = true;
            textBox1.AppendText(" + ");
            btnsuma.Visible = false;
            btnmultiplicar.Visible = false;
            btnresta.Visible = false;
            btndividir.Visible = false;
            button10.Visible = false;
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            de = false;
            m = false;
            d = false;
            s = false;
            r = true;
            b = true;

            textBox1.AppendText(" - ");
            btnsuma.Visible = false;
            btnmultiplicar.Visible = false;
            btnresta.Visible = false;
            btndividir.Visible = false;
            button10.Visible = false;
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            s = false;
            r = false;
            de = false;
            m = false;
            d = true;
            b = true;
            textBox1.AppendText(" / ");
            textBox1.AppendText(" + ");
            btnsuma.Visible = false;
            btnmultiplicar.Visible = false;
            btnresta.Visible = false;
            btndividir.Visible = false;
            button10.Visible = false;
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            try { 
            double operan1 = double.Parse(Op1);
            double operan2 = double.Parse(Op2);
                
            if(d == true)
            {
                Res = operan1 / operan2;
                
            }else if (s == true)
            {
                Res = operan1 + operan2;
                
            }else if (r == true)
            {
                Res = operan1 - operan2;
               
            }else if (m == true)
            {
                try {

                    Res = operan1 * operan2;

                }catch (System.FormatException exce)
                {
                    MessageBox.Show(exce.ToString());
                 }

            }
            else if (de == true)
            {
                Res = operan1 % operan2;
            }
            Op1 = operan1 + "";
            Op2 = operan2 + "";
            textBox1.ResetText();
                if (Res >pesados)
                {
                    Res = 2.0/0.0;
                }
                textBox1.AppendText(Res+" ");
            r = false;
            s = false;
            d = false;
            b = false;
            m = false;
            de = false;
            Ans = Res;
            Op1 = Res+ "";
            Op2 = "";
            Res = 0.0;
                btnsuma.Visible = true;
                btnmultiplicar.Visible = true;
                btnresta.Visible = true;
                btndividir.Visible = true;
                button10.Visible = true;

            }
            catch (System.FormatException exce)
            {
                textBox1.ResetText();
                textBox1.AppendText("MATH ERROR");
                
            }
            catch (Exception excepti)
            {
                textBox1.ResetText();
                Res = 2.0 / 0.0;
                textBox1.AppendText(Res+"");
            }

        }

        private void btnans_Click(object sender, EventArgs e)
        {
            if (b == false)
            {
                Op1 = Ans+"";
                textBox1.AppendText(Op1 + "");
            }
            else
            {
                Op2 = Ans + "";
                textBox1.AppendText(Op2 + "");

            }
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            de = false;
            r = false;
            s = false;
            d = false;
            b = false;
            m = true;
            b = true;
            textBox1.AppendText(" x ");
            btnsuma.Visible = false;
            btnmultiplicar.Visible = false;
            btnresta.Visible = false;
            btndividir.Visible = false;
            button10.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            r = false;
            s = false;
            d = false;
            b = false;
            m = false;
            de = true;
            b = true;
            textBox1.AppendText(" % ");
            btnsuma.Visible = false;
            btnmultiplicar.Visible = false;
            btnresta.Visible = false;
            btndividir.Visible = false;
            button10.Visible = false;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
