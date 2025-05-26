using NEW_PROJEKAN_PBO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NEW_PROJEKAN_PBO.Controller;

namespace NEW_PROJEKAN_PBO
{
    public partial class formPasien2 : Form
    {
        private PasienController controller = new PasienController();
        private int selectedIndex = -1;
        public formPasien2()
        {
            InitializeComponent();
            cmbJenisKelamin.Items.AddRange(new string[] { "Laki-laki", "Perempuan" });
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dgvDataPasien.DataSource = null;
            dgvDataPasien.DataSource = controller.GetAll();
            dgvDataPasien.ClearSelection();
        }

        private void pasien2form(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            var datapasien = new DataPasien
            {
                Nama = textNama.Text,
                Alamat = textAlamat.Text,
                JenisKelamin = cmbJenisKelamin.Text,
            };
            controller.Add(datapasien);
            ClearForm();
            RefreshGrid();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedIndex >= 0)
            {
                controller.Delete(selectedIndex);
                ClearForm();
                RefreshGrid();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (selectedIndex >= 0)
            {
                var updated = new DataPasien
                {
                    Id = controller.GetAll()[selectedIndex].Id,
                    Nama = textNama.Text,
                    Alamat = textAlamat.Text,
                    JenisKelamin = cmbJenisKelamin.Text,
                };
                controller.Update(selectedIndex, updated);
                ClearForm();
                RefreshGrid();
            }
        }

        private void dgvDataPasien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedIndex = e.RowIndex;
                var datapasien = controller.GetAll()[selectedIndex];
                textNama.Text = datapasien.Nama;
                textAlamat.Text = datapasien.Alamat;
                cmbJenisKelamin.Text = datapasien.JenisKelamin;
            }
        }
        private void ClearForm()
        {
            textNama.Clear();
            textAlamat.Clear();
            cmbJenisKelamin.SelectedIndex = -1;
            selectedIndex = -1;
        }
    }
}
