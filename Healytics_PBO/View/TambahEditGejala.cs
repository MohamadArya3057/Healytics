using Healytics_PBO.Model;
using System;
using System.Windows.Forms;

namespace Healytics_PBO.View
{
    public partial class TambahEditGejala : Form
    {
        public GejalaModel gejala; 
        private string mode;

        public TambahEditGejala(string mode) 
        {
            this.mode = mode;
        }

        private void TambahEditGejala_Load(object sender, EventArgs e)
        {
            if (mode == "Update" && gejala != null)
            {
                txtNamaGejala.Text = gejala.Nama_Gejala;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // logic simpan/update ke database
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
