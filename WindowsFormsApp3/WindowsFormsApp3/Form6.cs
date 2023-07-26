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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        galerimEntities db = new galerimEntities();
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            //ekle
            tbl_arac k = new tbl_arac();//bilgileri kaydetmesi için

            k.plaka = bmtplaka.Text;
            k.marka = bmtmarka.Text;
            k.model = bmtxtmodel.Text;
            k.arac_tipi = bmttxtaractipi.Text;
            k.renk = cmbrenk.Text;
            k.yil = bmtyil.Text;
            k.arac_durum = cmbaracdurum.Text;
            
            db.tbl_arac.Add(k);
            db.SaveChanges();
            MessageBox.Show("Kayıt eklendi");
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            //güncelle
            int z = int.Parse(bmtid.Text);
            var arac = db.tbl_arac.Find(z);
            arac.plaka = bmtplaka.Text;
            arac.marka = bmtmarka.Text;
            arac.model = bmtxtmodel.Text;
            arac.arac_tipi = bmttxtaractipi.Text;
            arac.renk = cmbrenk.Text;
            arac.yil = bmtyil.Text;
            arac.arac_durum = cmbaracdurum.Text;
            
            db.SaveChanges();
            MessageBox.Show("Araç bilgisi güncellenmiştir.");
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
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
            //sil
            int x = int.Parse(bmtid.Text);
            var arac = db.tbl_arac.Find(x);
            db.tbl_arac.Remove(arac);
            db.SaveChanges();
            MessageBox.Show("Araç silinmiştir.");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //seçme işlemi için yani txt lara yazsın diye
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            bmtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            bmtplaka.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            bmtmarka.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            bmtxtmodel.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            bmttxtaractipi.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            cmbrenk.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            bmtyil.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            cmbaracdurum.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //anasayfa
            Form5 fr5 = new Form5();
            fr5.ShowDialog();
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {//arac durumu güncelle
            //güncelle
            int k = int.Parse(bmtid.Text);
            var arac = db.tbl_arac.Find(k);
            cmbaracdurum.Text = "Araç Müsaittir";
            
            arac.arac_durum = cmbaracdurum.Text;
            db.SaveChanges();
            MessageBox.Show("Araç bilgisi güncellenmiştir.");

        }
    }
}
