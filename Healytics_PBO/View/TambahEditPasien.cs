using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Healytics_PBO.Controller;
using Healytics_PBO.Model;

namespace Healytics_PBO.View
{
    public partial class TambahEditPasien : Form
    {
        private string type;
        public PasienModel pasien;
        private List<DesaModel> desaList;

        public TambahEditPasien(string type)
        {
            InitializeComponent();
            this.type = type;
        }

        private void TambahEditPasien_Load(object sender, EventArgs e)
        {
            LoadDesaToComboBox();

            if (type == "Tambah")
            {
                this.Text = "Tambah Data Pasien";
                btnSimpan.Text = "Tambahkan";
            }
            else
            {
                this.Text = "Update Data Pasien";
                btnSimpan.Text = "Perbarui";

                if (pasien != null)
                {
                    txtNamaPasien.Text = pasien.nama_pasien;
                    txtUmur.Text = pasien.umur.ToString();
                    comboDesa.SelectedValue = pasien.id_desa;
                }
            }
        }

        private void LoadDesaToComboBox()
        {
            var controller = new DesaController();
            desaList = controller.GetAll();

            comboDesa.DataSource = desaList;
            comboDesa.DisplayMember = "nama_desa";
            comboDesa.ValueMember = "ID";
            comboDesa.SelectedIndex = -1;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtNamaPasien.Text == "" || txtUmur.Text == "" || comboDesa.SelectedIndex == -1)
            {
                MessageBox.Show("Semua data wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PasienModel data = new PasienModel
            {
                nama_pasien = txtNamaPasien.Text,
                umur = int.Parse(txtUmur.Text),
                id_desa = (int)comboDesa.SelectedValue
            };

            var controller = new PasienController();

            if (type == "Tambah")
            {
                controller.Insert(data);
                MessageBox.Show("Data Pasien berhasil ditambahkan!", "Informasi");
            }
            else
            {
                data.ID = pasien.ID;
                controller.Update(data);
                MessageBox.Show("Data Pasien berhasil diperbarui.", "Informasi");
            }

            this.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
