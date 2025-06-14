using System;
using System.Windows.Forms;
using Healytics_PBO.Model;
using Healytics_PBO.Controller;

namespace Healytics_PBO.View
{
<<<<<<< HEAD
    public partial class TambahEditGejala : Form
=======
    public partial class TambahEditGejala : Form 
>>>>>>> bd465975ca0516bf317454e70d88417eda14e04d
    {
        public GejalaModel gejala;
        private string mode;

        public TambahEditGejala(string mode)
        {
            InitializeComponent();
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
            string nama = txtNamaGejala.Text.Trim();
            if (string.IsNullOrEmpty(nama))
            {
                MessageBox.Show("Nama gejala tidak boleh kosong.");
                return;
            }

            GejalaController controller = new GejalaController();

            if (mode == "Tambah")
            {
                controller.Insert(new GejalaModel { Nama_Gejala = nama });
                MessageBox.Show("Data berhasil ditambahkan.");
            }
            else if (mode == "Update" && gejala != null)
            {
                gejala.Nama_Gejala = nama;
                controller.Update(gejala);
                MessageBox.Show("Data berhasil diperbarui.");
            }

            this.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
