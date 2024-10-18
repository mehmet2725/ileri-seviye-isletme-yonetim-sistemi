using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ileri_seviye_depo_stoğu_projesi
{
    public partial class Yonetici_ekrani : Form
    {
        public Yonetici_ekrani()
        {
            InitializeComponent();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            GirisEkrani girisFormu = new GirisEkrani();
            girisFormu.Show();
            this.Close();
        }
    }
}
