using NEW_PROJEKAN_PBO.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NEW_PROJEKAN_PBO.Model;

namespace NEW_PROJEKAN_PBO
{
    public partial class Alat : Form
    {
        private readonly AlatController controller = new AlatController();
        private int selectedId = -1;
        public Alat()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dgvAlat.DataSource = null;
            dgvAlat.DataSource = controller.GetAll();
        }

        private void Alat_Load(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            var daftaralat = new DaftarAlat
            {
                Nama = textNama.Text,
                Stock = (int)numStock.Value
            };
            controller.Add(daftaralat);
            ClearForm();
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) return;
            var daftaralat = new DaftarAlat
            {
                Id = selectedId,
                Nama = textNama.Text,
                Stock = (int)numStock.Value
            };
            controller.Update(daftaralat);
            ClearForm();
            LoadData();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) return;
            controller.Delete(selectedId);
            ClearForm();
            LoadData();
        }

        private void dgvAlat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvAlat.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["Id"].Value);
                textNama.Text = row.Cells["Nama"].Value.ToString();
                numStock.Value = Convert.ToDecimal(row.Cells["Stock"].Value);
            }
        }
        private void ClearForm()
        {
            textNama.Clear();
            numStock.Value = 0;
            selectedId = -1;
            dgvAlat.ClearSelection();
        }
    }
}
