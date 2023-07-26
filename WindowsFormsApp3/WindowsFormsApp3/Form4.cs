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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        galerimEntities db = new galerimEntities();
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //listele
            dataGridView1.DataSource = (from x in db.tbl_arac
                                        select new
                                        {
                                            x.id,
                                            x.plaka,
                                            x.marka,
                                            x.model,
                                            x.arac_tipi,
                                            x.renk,
                                            x.yil,
                                            x.arac_durum,

                                        }).ToList();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //seçme işlemi için yani txt lara yazsın diye
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtplaka.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtmarka.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtmodel.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtaractipi.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtrenk.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtyil.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtaracdurum.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.ShowDialog();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
