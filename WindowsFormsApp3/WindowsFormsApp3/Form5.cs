using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        galerimEntities db = new galerimEntities();
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Form6 fr6 = new Form6();
            fr6.ShowDialog();
            this.Hide();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Form7 fr7 = new Form7();
            fr7.ShowDialog();
            this.Hide();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Form8 fr8 = new Form8();
            fr8.ShowDialog();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
