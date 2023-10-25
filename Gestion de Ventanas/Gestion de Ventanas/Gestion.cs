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
    public partial class Gestion : Form
    {
        public Gestion()
        {
            InitializeComponent();
        }

        private void menu_prf_Click(object sender, EventArgs e)
        {
            Profesores prf = new Profesores();
            prf.Show();
        }

        private void menu_alum_Click(object sender, EventArgs e)
        {
            Alumnos alm = new Alumnos();
            alm.Show();
        }
    }
}
