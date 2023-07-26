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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        galerimEntities db = new galerimEntities();
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
         
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            //veritabındaki bilgilerle karşılaştırdım.nesne oluşturup oraya attım.
            tbl_admin z = db.tbl_admin.Where(x => x.kullanici_adi == txtkullaniciadi.Text && x.sifre == txtsifre.Text).SingleOrDefault();
            if (z == null)
            {
                MessageBox.Show("Bilgiler Yanlıştır");
            }
            else if (z != null)
            {
                Form5 frm = new Form5();
                frm.Show();
                this.Hide();
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //üstteki işlemleri burda da yaptım.
            tbl_musteri z = db.tbl_musteri.Where(x => x.tc == bmtxtc.Text && x.sifre == bmtxsifre.Text).SingleOrDefault();
            if (z == null)
            {
                MessageBox.Show("Bilgiler Yanlıştır");
            }
            else if (z != null)
            {
                Form4 frm = new Form4();
                frm.Show();
                this.Hide();
            }
        }
    }
}
