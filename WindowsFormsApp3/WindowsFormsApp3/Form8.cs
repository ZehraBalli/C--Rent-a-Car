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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        galerimEntities db = new galerimEntities();
        private void cmbtcno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            var tc = db.tbl_musteri.ToList();
            cmbtcno.DataSource = tc;
            cmbtcno.DisplayMember = "tc";
            cmbtcno.ValueMember = "id";

            var plaka = db.tbl_arac.ToList();
            comboBox2.DataSource = plaka;
            comboBox2.DisplayMember = "plaka";
            comboBox2.ValueMember = "id";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            //ekle
            tbl_kiralama b = new tbl_kiralama();//bilgileri kaydetmesi için

            b.tc = cmbtcno.Text;
            b.plaka = comboBox2.Text;
            b.alis_tarihi = dateTimePicker1.Text;
            b.veris_tarihi = dateTimePicker2.Text;
            b.ucret = int.Parse(txtucret.Text);
            

            db.tbl_kiralama.Add(b);
            db.SaveChanges();
            MessageBox.Show("Kayıt eklendi");
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            //güncelle
            int z = int.Parse(txtid.Text);
            var kiralama = db.tbl_kiralama.Find(z);
            kiralama.tc = cmbtcno.Text;
            kiralama.plaka = comboBox2.Text;
            kiralama.alis_tarihi = dateTimePicker1.Text;
            kiralama.veris_tarihi = dateTimePicker2.Text;
            kiralama.ucret = int.Parse(txtucret.Text);
            db.SaveChanges();
            MessageBox.Show("Araç bilgisi güncellenmiştir.");

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            //sil
            int y = int.Parse(txtid.Text);
            var kiralama = db.tbl_kiralama.Find(y);
            db.tbl_kiralama.Remove(kiralama);
            db.SaveChanges();
            MessageBox.Show("İşlem silinmiştir.");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //seçme işlemi için yani txt lara yazsın diye
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            cmbtcno.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtucret.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
           
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form5 fr5 = new Form5();
            fr5.ShowDialog();
            this.Hide();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            //listele
            dataGridView1.DataSource = (from x in db.tbl_kiralama
                                        select new
                                        {
                                            x.id,
                                            x.tc,
                                            x.plaka,
                                            x.alis_tarihi,
                                            x.veris_tarihi,
                                            x.ucret,
                                            
                                        }).ToList();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
