using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using c_sharp_otomasyon;
using OgrAra;
using OgrKayit;
using static OgrKayit.OgrKayit;







namespace NotKaydi
{
    public partial class NotKaydi : Form
    {

        
        public NotKaydi()
        {
            InitializeComponent();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            c_sharp_otomasyon.c_sharp_otomasyon f1 = new c_sharp_otomasyon.c_sharp_otomasyon();
            f1.Show();
            Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            c_sharp_otomasyon.FrmBolum2 h = new c_sharp_otomasyon.FrmBolum2();
            h.Show();
            Hide();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            c_sharp_otomasyon.FrmBilgisayar b = new c_sharp_otomasyon.FrmBilgisayar();
            b.Show();
            Hide();


        }

        private void NotKaydi_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
