using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Healytics_PBO.Model;
using Healytics_PBO.Controller;

namespace Healytics_PBO.View
{
    public partial class TambahEditAlat : Form
    {
        private string type;
        public AlatModel alat;

        public TambahEditAlat(string type)
        {
            InitializeComponent();
            this.type = type;
        }

        private void TambahEditAlat_Load(object sender, EventArgs e)
        {
            if (type == "Tambah")
            {
                this.Text = "Tambah Data Alat";
                btnSimpan.Text = "Tambahkan";
            }
            else
            {
                this.Text = "Update Data Alat";
                btnSimpan.Text = "Perbarui";

                if (alat != null)
                {
                    txtNamaAlat.Text = alat.nama_alat;
                    txtStok.Text = alat.stock.ToString();
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtNamaAlat.Text == "" || txtStok.Text == "")
            {
                MessageBox.Show("Semua data wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AlatModel data = new AlatModel
            {
                nama_alat = txtNamaAlat.Text,
                stock = int.Parse(txtStok.Text)
            };

            var controller = new AlatController();

            if (type == "Tambah")
            {
                controller.Insert(data);
                MessageBox.Show("Data Alat berhasil ditambahkan!", "Informasi");
            }
            else
            {
                data.ID = alat.ID;
                controller.Update(data);
                MessageBox.Show("Data Alat berhasil diperbarui.", "Informasi");
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
