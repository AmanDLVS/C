using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lista_pelicuals_Amancio
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    pB1.Image = Properties.Resources.starwars1;
                    break;
                case 1:
                        pB1.Image = Properties.Resources.starwars2;
                    break; 
                case 2:
                        pB1.Image = Properties.Resources.starwars3;
                    break;
            }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_añadir_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
        }
    }
}
