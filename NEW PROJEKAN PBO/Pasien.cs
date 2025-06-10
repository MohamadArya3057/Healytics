using NEW_PROJEKAN_PBO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEW_PROJEKAN_PBO
{
    public partial class Pasien1 : Form
    {
        Obat obat;
        Alat alat;
        Transaksi transaksi;
        Laporan laporan;

        public Pasien1()
        {
            InitializeComponent();
            mdiProp();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.White;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (obat == null)
            {
                obat = new Obat();
                obat.FormClosed += Obat_FormClosed;
                obat.MdiParent = this;
                obat.Show();
            }
            else
            {
                obat.Activate();
            }
        }

        private void Obat_FormClosed(object? sender, FormClosedEventArgs e)
        {
            obat = null;
        }

        private void Pasien_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void Button2_Click(object sender, EventArgs e)
        { 
        
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        bool sidebarExpand = true;
        private void sidebarTransisi_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 50)
                {
                    sidebarExpand = false;
                    sidebarTransisi.Stop();

                    pnPasien.Width = sidebar.Width;
                    pnObat.Width = sidebar.Width;
                    pnAlat.Width = sidebar.Width;
                    pnTransaksi.Width = sidebar.Width;
                    pnLaporan.Width = sidebar.Width;
                    pnLogout.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 225)
                {
                    sidebarExpand = true;
                    sidebarTransisi.Stop();

                    pnPasien.Width = sidebar.Width;
                    pnObat.Width = sidebar.Width;
                    pnAlat.Width = sidebar.Width;
                    pnTransaksi.Width = sidebar.Width;
                    pnLaporan.Width = sidebar.Width;
                    pnLogout.Width = sidebar.Width;
                }
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            sidebarTransisi.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (alat == null)
            {
                alat = new Alat();
                alat.FormClosed += Alat_FormClosed;
                alat.MdiParent = this;
                alat.Show();
            }
            else
            {
                alat.Activate();
            }
        }

        private void Alat_FormClosed(object? sender, FormClosedEventArgs e)
        {
            alat = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (transaksi == null)
            {
                transaksi = new Transaksi();
                transaksi.FormClosed += Transaksi_FormClosed;
                transaksi.MdiParent = this;
                transaksi.Show();
            }
            else
            {
                transaksi.Activate();
            }
        }

        private void Transaksi_FormClosed(object? sender, FormClosedEventArgs e)
        {
            transaksi = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (laporan == null)
            {
                laporan = new Laporan();
                laporan.FormClosed += Laporan_FormClosed;
                laporan.MdiParent = this;
                laporan.Show();
            }
            else
            {
                laporan.Activate();
            }
        }

        private void Laporan_FormClosed(object? sender, FormClosedEventArgs e)
        {
            laporan = null;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                this.Hide(); 
                Awal awal = new Awal();
                awal.Show(); 
            }
        }
    }
}
