using NotKaydi;
using OgrAra;
using OgrKayit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace c_sharp_otomasyon
{
    public partial class FrmBilgisayar : Form
    {
        string harf;
        public FrmBilgisayar()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmBolum1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NotKaydi.NotKaydi g = new NotKaydi.NotKaydi();
            g.Show();
            Hide();
        }

        public void button4_Click(object sender, EventArgs e)
        {
            int NotVize = Convert.ToInt32(txtVize.Text);
            int NotFinal = Convert.ToInt32(txtFinal.Text);
            float ort = (NotVize*4/10)+(NotFinal*6/10);
            txtOrtr.Text = ort.ToString();

            if (ort >= 0 && ort <= 38)
            {
                harf = "FF";
            }
            else if (ort > 38 && ort <= 45)
            {
                harf = "FD";
            }
            else if (ort > 45 && ort <= 52)
            {
                harf = "DD";
            }
            else if (ort > 52 && ort <= 59)
            {
                harf = "DC";
            }
            else if (ort > 59 && ort <= 66)
            {
                harf = "CC";
            }
            else if (ort > 66 && ort <= 73)
            {
                harf = "CB";
            }
            else if (ort > 73 && ort <= 80)
            {
                harf = "BB";
            }
            else if (ort > 80 && ort <= 87)
            {
                harf = "BA";
            }
            else if (ort > 87 && ort <= 100)
            {
                harf = "AA";
            }

            txtHarf.Text = harf;

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOgr.Text))
            {
                MessageBox.Show("Lütfen No Girin");
            }
            else
            {
                string aranan = txtOgr.Text.Trim().ToUpper();
                string ArananBolum = cmbDers.Text.Trim().ToUpper();
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
                                    
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
