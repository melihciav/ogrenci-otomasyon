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

namespace c_sharp_otomasyon
{
    public partial class c_sharp_otomasyon : Form
    {
        public c_sharp_otomasyon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrKayit.OgrKayit f2 = new OgrKayit.OgrKayit();
            f2.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OgrAra.FrmOgr f5 = new OgrAra.FrmOgr();
            f5.Show();
            Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            NotKaydi.NotKaydi f3 = new NotKaydi.NotKaydi();
            f3.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void c_sharp_otomasyon_Load(object sender, EventArgs e)
        {

        }
    }
}
