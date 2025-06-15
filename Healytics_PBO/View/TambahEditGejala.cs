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
    public partial class TambahEditGejala : Form
    {
        private string type;
        public GejalaModel gejala;

        public TambahEditGejala(string type)
        {
            InitializeComponent();
            this.type = type;
        }

        private void TambahEditGejala_Load(object sender, EventArgs e)
        {
            if (type == "Tambah")
            {
                this.Text = "Tambah Data Gejala";
                btnSimpan.Text = "Tambahkan";
            }
            else
            {
                this.Text = "Update Data Gejala";
                btnSimpan.Text = "Perbarui";

                if (gejala != null)
                {
                    txtNamagGejala.Text = gejala.nama_gejala;
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtNamagGejala.Text == "")
            {
                MessageBox.Show("Semua data wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GejalaModel data = new GejalaModel
            {
                nama_gejala = txtNamagGejala.Text
            };

            var controller = new GejalaController();

            if (type == "Tambah")
            {
                controller.Insert(data);
                MessageBox.Show("Data Gejala berhasil ditambahkan!", "Informasi");
            }
            else
            {
                data.ID = gejala.ID;
                controller.Update(data);
                MessageBox.Show("Data Gejala berhasil diperbarui.", "Informasi");
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
