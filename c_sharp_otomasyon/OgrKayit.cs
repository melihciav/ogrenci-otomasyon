using c_sharp_otomasyon;
using OgrAra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NotKaydi.NotKaydi;


namespace OgrKayit
{
    public partial class OgrKayit : Form
    {
        List<ogrenci> _ogrenciList = new List<ogrenci>();
        List<ogrenci> Insaat_ogrenciList = new List<ogrenci>();

        public void Temizle()
        {
            txtmcNo.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            cbxSinif.ResetText();
            txtCinsiyet.Clear();
            txtOgrNo.Clear();
            cbxBolum.ResetText();
            txtYas.Clear();
        }
        public OgrKayit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c_sharp_otomasyon.c_sharp_otomasyon f1 = new c_sharp_otomasyon.c_sharp_otomasyon();
            f1.Show();
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void btnKaydet_Click(object sender, EventArgs e)
        {
            FrmOgr a = new FrmOgr(_ogrenciList);
            FrmOgr b = new FrmOgr(Insaat_ogrenciList);
            a.ShowDialog();
            b.ShowDialog();
        }

        private void txtmcNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }

        public void rchText_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            if (rbErkek.Checked)
            {
                txtCinsiyet.Text = "Erkek";
            }
            if (rbKadın.Checked)
            {
                txtCinsiyet.Text = "Kadın";
            }
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtmcNo.Text) || string.IsNullOrWhiteSpace(txtOgrNo.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text) || string.IsNullOrWhiteSpace(cbxBolum.Text))
            {
                MessageBox.Show("Lütfen boş bırakmayın");
            }
            else
            {
                ogrenci student = new ogrenci();
                student.McNo = txtmcNo.Text;
                student.Ad = txtAd.Text;
                student.Soyad = txtSoyad.Text;
                student.Sinif = cbxSinif.Text;
                student.Cinsiyet = txtCinsiyet.Text;
                student.OkulNo = txtOgrNo.Text;
                student.Bolum = cbxBolum.Text;
                student.Yas = txtYas.Text;

                if (student.Bolum == "Insaat")
                {
                    Insaat_ogrenciList.Add(student);
                }
                else
                {
                    _ogrenciList.Add(student);
                }

                Temizle();
            }
        }


    }
}
