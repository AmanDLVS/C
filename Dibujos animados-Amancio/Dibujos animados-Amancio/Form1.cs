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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void buscaminasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn1_activity.Visible = false;
            btn2_activity.Visible = false;
            btn3_activity.Visible = false;
            btn4_activity.Visible = false;
            form_juego f = new form_juego();
            f.ShowDialog();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.ShowDialog();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.ShowDialog();
        }

        private void actividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn1_activity.Visible = true;
            btn2_activity.Visible = true;
            btn3_activity.Visible = true;
            btn4_activity.Visible = true;
        }
    }
}
