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
    public partial class Calisan_Ekrani : Form
    {


        private bool erisimSiparis;
        private bool erisimStok;

        public Calisan_Ekrani(bool erisimSiparis, bool erisimStok)
        {
            InitializeComponent();
            this.erisimSiparis = erisimSiparis;
            this.erisimStok = erisimStok;
        }

        private void Calisan_Ekrani_Load(object sender, EventArgs e)
        {
            if (!erisimSiparis)
            {
                btnSiparisBilgileri.Enabled = false;
            }

            if (!erisimStok)
            {
                btnStokBilgileri.Enabled = false;
            }
        }
        public Calisan_Ekrani()
        {
            InitializeComponent();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
