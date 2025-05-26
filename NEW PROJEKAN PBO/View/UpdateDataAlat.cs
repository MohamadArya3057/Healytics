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

namespace NEW_PROJEKAN_PBO.View
{
    public partial class UpdateDataAlat : Form
    {
        public DaftarAlat AlatData { get; private set; }
        private bool isEdit;
        public UpdateDataAlat(DaftarAlat data = null)
        {
            InitializeComponent();
            if (data != null)
            {
                isEdit = true;
                AlatData = data;
                textNama.Text = data.Nama_alat;
                numStock.Value = data.Stock;
                this.Text = "Edit Alat";
            }
            else
            {
                this.Text = "Tambah Alat";
                AlatData = new DaftarAlat();
            }

            btnSimpan.Click += btnSimpan_Click;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNama.Text))
            {
                MessageBox.Show("Nama alat tidak boleh kosong!");
                return;
            }

            AlatData.Nama_alat = textNama.Text;
            AlatData.Stock = (int)numStock.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
