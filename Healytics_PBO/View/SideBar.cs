﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Healytics_PBO.View
{
    public partial class SideBar : Form
    {
        Pasien pasien;
        Obat obat;
        Alat alat;
        Gejala gejala;
        Transaksi transaksi;

        public SideBar()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
            this.Load += SideBar_Load;
        }

        bool laporanExpand = false;

        private void btnPasien_Click(object sender, EventArgs e)
        {
            if (pasien == null)
            {
                pasien = new Pasien();
                pasien.FormClosed += Pasien_FormClosed;
                pasien.MdiParent = this;
                pasien.Dock = DockStyle.Fill;
                pasien.Show();
            }
            else
            {
                pasien.Activate();
            }
        }

        private void Pasien_FormClosed(object? sender, FormClosedEventArgs e)
        {
            pasien = null;
        }

        private void btnObat_Click(object sender, EventArgs e)
        {
            if (obat == null)
            {
                obat = new Obat();
                obat.FormClosed += Obat_FormClosed;
                obat.MdiParent = this;
                obat.Dock = DockStyle.Fill;
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

        private void btnAlat_Click(object sender, EventArgs e)
        {
            if (alat == null)
            {
                alat = new Alat();
                alat.FormClosed += Alat_FormClosed;
                alat.MdiParent = this;
                alat.Dock = DockStyle.Fill;
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

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            if (transaksi == null)
            {
                transaksi = new Transaksi();
                transaksi.FormClosed += Transaksi_FormClosed;
                transaksi.MdiParent = this;
                transaksi.Dock = DockStyle.Fill;
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                var loginForm = new Login();
                loginForm.Show();
                this.Close();
            }
        }

        private void btnGejala_Click(object sender, EventArgs e)
        {
            if (gejala == null)
            {
                gejala = new Gejala();
                gejala.FormClosed += Gejala_FormClosed;
                gejala.MdiParent = this;
                gejala.Dock = DockStyle.Fill;
                gejala.Show();
            }
            else
            {
                gejala.Activate();
            }
        }

        private void Gejala_FormClosed(object? sender, FormClosedEventArgs e)
        {
            gejala = null;
        }

        private void SideBar_Load(object sender, EventArgs e)
        {
            if (pasien == null)
            {
                pasien = new Pasien();
                pasien.MdiParent = this;
                pasien.Dock = DockStyle.Fill;
                pasien.FormClosed += Pasien_FormClosed;
                pasien.Show();
            }
        }
    }
}
