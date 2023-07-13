using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lentille_conv_et_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 lentilleconvergente = new Form2();
            lentilleconvergente.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 lentilledivergente = new Form3();
            lentilledivergente.Show();
        }
    }
}
