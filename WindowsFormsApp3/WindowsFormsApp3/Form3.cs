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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        galerimEntities db = new galerimEntities();
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            tbl_musteri k = new tbl_musteri();//bilgileri kaydetmesi için
            k.tc = bmtxttc.Text;
            k.adi_soyadi = bmtxadsoyad.Text;
            k.cinsiyet = bmtxtcinsiyet.Text;
            k.telefon = bmttxttelefon.Text;
            k.dogum_tarihi = bmttxtdogumtarihi.Text;
            k.ehliyet_no = bmttxtehliyetno.Text;
            k.sifre = bmttxtsifre.Text;
            db.tbl_musteri.Add(k);
            db.SaveChanges();
            MessageBox.Show("Kayıt eklendi");
        }

        private void bunifuThinButton24_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.tbl_musteri.ToList();
        }
    }
}
