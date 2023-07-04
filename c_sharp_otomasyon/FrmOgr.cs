using c_sharp_otomasyon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OgrKayit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace OgrAra
{
    public partial class FrmOgr : Form
    {
        
        public FrmOgr()
        {

        }
        List<ogrenci> ogrAra = null;
        List<InsaatOgrenci> ogrAra2 = null; //inşaat
      

        public FrmOgr(List<ogrenci> _ogrAra)
        {
            InitializeComponent();
            ogrAra = _ogrAra;
        }
        //inşaat öğrenci listesi
        public FrmOgr(List<InsaatOgrenci> ogrAra2_)
        {
            InitializeComponent();
            ogrAra2 = ogrAra2_;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c_sharp_otomasyon.c_sharp_otomasyon f1 = new c_sharp_otomasyon.c_sharp_otomasyon();
            f1.Show();
            Close();
        }

        public void Temizle()
        {
            txtAra.Clear();
            txtAd.Clear();
            txtBolum.Clear();
            txtCinsiyet.Clear();
            txtMCNo.Clear();
            txtNo.Clear();
            txtSinif.Clear();
            txtSoyad.Clear();
            txtyas.Clear();
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAra.Text))
            {
                MessageBox.Show("Lütfen No Girin");
            }
            else
            {
                string aranan = txtAra.Text.Trim().ToUpper();
                for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                        {
                            if (cell.Value != null)
                            {
                                if (cell.Value.ToString().ToUpper() == aranan)
                                {
                                    txtNo.Text = ogrAra[i].OkulNo;
                                    txtSinif.Text = ogrAra[i].Sinif;
                                    txtBolum.Text = ogrAra[i].Bolum;
                                    txtMCNo.Text = ogrAra[i].McNo;
                                    txtAd.Text = ogrAra[i].Ad;
                                    txtSoyad.Text = ogrAra[i].Soyad;
                                    txtyas.Text = ogrAra[i].Yas;
                                    txtCinsiyet.Text = ogrAra[i].Cinsiyet;
                                    break;
                                }
                            }
                        }
                    }
                }
            
                string aranan2 = txtAra.Text.Trim().ToUpper();
                for (int i = 0; i <= dataGridView2.Rows.Count - 1; i++)
                {
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        foreach (DataGridViewCell cell in dataGridView2.Rows[i].Cells)
                        {
                            if (cell.Value != null)
                            {
                                if (cell.Value.ToString().ToUpper() == aranan2)
                                {
                                    txtNo.Text = ogrAra2[i].OkulNo;
                                    txtSinif.Text = ogrAra2[i].Sinif;
                                    txtBolum.Text = ogrAra2[i].Bolum;
                                    txtMCNo.Text = ogrAra2[i].McNo;
                                    txtAd.Text = ogrAra2[i].Ad;
                                    txtSoyad.Text = ogrAra2[i].Soyad;
                                    txtyas.Text = ogrAra2[i].Yas;
                                    txtCinsiyet.Text = ogrAra2[i].Cinsiyet;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }
        public void btnGuncelle_Click(object sender, EventArgs e)
        {
            string ArananMcNo = txtMCNo.Text.Trim().ToUpper();
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            if (cell.Value.ToString().ToUpper() == ArananMcNo)
                            {
                                ogrAra[i].OkulNo = txtNo.Text;
                                ogrAra[i].Sinif = txtSinif.Text;
                                ogrAra[i].Bolum = txtBolum.Text;
                                ogrAra[i].McNo = txtMCNo.Text;
                                ogrAra[i].Ad = txtAd.Text;
                                ogrAra[i].Soyad = txtSoyad.Text;
                                ogrAra[i].Yas = txtyas.Text;
                                ogrAra[i].Cinsiyet = txtCinsiyet.Text;
                                break;
                            }
                        }
                    }
                }
            }
            for (int i = 0; i <= dataGridView2.Rows.Count - 1; i++)
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    foreach (DataGridViewCell cell in dataGridView2.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            if (cell.Value.ToString().ToUpper() == ArananMcNo)
                            {
                                ogrAra2[i].OkulNo = txtNo.Text;
                                ogrAra2[i].Sinif = txtSinif.Text;
                                ogrAra2[i].Bolum = txtBolum.Text;
                                ogrAra2[i].McNo = txtMCNo.Text;
                                ogrAra2[i].Ad = txtAd.Text;
                                ogrAra2[i].Soyad = txtSoyad.Text;
                                ogrAra2[i].Yas = txtyas.Text;
                                ogrAra2[i].Cinsiyet = txtCinsiyet.Text;
                                break;
                            }
                        }
                    }
                }
            }
            this.dataGridView1.Refresh();
            this.dataGridView1.Parent.Refresh();
            this.dataGridView2.Refresh();
            this.dataGridView2.Parent.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ogrKayitBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void FrmOgr_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ogrAra;
            dataGridView2.DataSource = ogrAra2;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            
            string ArananMcNo = txtMCNo.Text.Trim().ToUpper();
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            if (cell.Value.ToString().ToUpper() == ArananMcNo)
                            {
                                ogrAra[i] = null;
                                break;
                            }
                        }
                    }
                }
            }
            for (int i = 0; i <= dataGridView2.Rows.Count - 1; i++)
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    foreach (DataGridViewCell cell in dataGridView2.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            if (cell.Value.ToString().ToUpper() == ArananMcNo)
                            {
                                ogrAra2[i] = null;
                                break;
                            }
                        }
                    }
                }
            }
            Temizle();

            this.dataGridView1.Refresh();
            this.dataGridView1.Parent.Refresh();
            this.dataGridView2.Refresh();
            this.dataGridView2.Parent.Refresh();

        }

        private void btnNot_Click(object sender, EventArgs e)
        {
            if (txtBolum.Text == "Insaat")
            {
                FrmBolum2 d = new FrmBolum2();
                d.ShowDialog();
            }
            else
            {
                FrmBilgisayar c = new FrmBilgisayar();
                c.ShowDialog();
            }
        }
    }
}
