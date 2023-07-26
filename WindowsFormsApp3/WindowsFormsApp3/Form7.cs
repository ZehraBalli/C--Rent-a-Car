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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        galerimEntities db = new galerimEntities();
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form5 fr5 = new Form5();
            fr5.ShowDialog();
            this.Hide();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            //listele
            dataGridView1.DataSource = (from x in db.tbl_musteri
                                        select new
                                        {
                                            x.id,
                                            x.tc,
                                            x.adi_soyadi,
                                            x.cinsiyet,
                                            x.telefon,
                                            x.dogum_tarihi,
                                            x.ehliyet_no,
                                            x.sifre
                                        }).ToList();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            //güncelle
            int z = int.Parse(bmtid.Text);
            var musteri = db.tbl_musteri.Find(z);
            musteri.tc = bmtxttc.Text;
            musteri.adi_soyadi = bmtadsoyad.Text;
            musteri.cinsiyet = bmcinsiyet.Text;
            musteri.telefon = bmtelefon.Text;
            musteri.dogum_tarihi = bmdogumtarihi.Text;
            musteri.ehliyet_no = bmehliyet.Text;
            musteri.sifre = bmsifre.Text;

            db.SaveChanges();
            MessageBox.Show("Araç bilgisi güncellenmiştir.");
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            //sil
            int y = int.Parse(bmtid.Text);
            var musteri = db.tbl_musteri.Find(y);
            db.tbl_musteri.Remove(musteri);
            db.SaveChanges();
            MessageBox.Show("Müşteri silinmiştir.");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //seçme işlemi için yani txt lara yazsın diye
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            bmtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            bmtxttc.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            bmtadsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            bmcinsiyet.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            bmtelefon.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            bmdogumtarihi.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            bmehliyet.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            bmsifre.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
