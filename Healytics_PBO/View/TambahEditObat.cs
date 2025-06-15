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
    public partial class TambahEditObat : Form
    {
        private string type;
        public ObatModel obat;
        private List<KategoriObatModel> kategoriList;

        public TambahEditObat(string type)
        {
            InitializeComponent();
            this.type = type;
        }

        private void TambahEditObat_Load(object sender, EventArgs e)
        {
            LoadKategoriToComboBox();

            if (type == "Tambah")
            {
                this.Text = "Tambah Data Obat";
                btnSimpan.Text = "Tambahkan";
            }
            else
            {
                this.Text = "Update Data Obat";
                btnSimpan.Text = "Perbarui";

                if (obat != null)
                {
                    txtNamaObat.Text = obat.nama_obat;
                    txtHarga.Text = obat.harga.ToString();
                    txtStok.Text = obat.stock.ToString();
                    comboKategori.SelectedValue = obat.id_kategori;
                }
            }
        }

        private void LoadKategoriToComboBox()
        {
            var controller = new KategoriObatController();
            kategoriList = controller.GetAll();

            comboKategori.DataSource = kategoriList;
            comboKategori.DisplayMember = "nama_kategori";
            comboKategori.ValueMember = "ID";
            comboKategori.SelectedIndex = -1;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtNamaObat.Text == "" || txtHarga.Text == "" || txtStok.Text == "" || comboKategori.SelectedIndex == -1)
            {
                MessageBox.Show("Semua data wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ObatModel data = new ObatModel
            {
                nama_obat = txtNamaObat.Text,
                stock = int.Parse(txtHarga.Text),
                harga = decimal.Parse(txtStok.Text),
                id_kategori = (int)comboKategori.SelectedValue
            };

            var controller = new ObatController();

            if (type == "Tambah")
            {
                controller.Insert(data);
                MessageBox.Show("Data Obat berhasil ditambahkan!", "Informasi");
            }
            else
            {
                data.ID = obat.ID;
                controller.Update(data);
                MessageBox.Show("Data Obat berhasil diperbarui.", "Informasi");
            }
            this.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
