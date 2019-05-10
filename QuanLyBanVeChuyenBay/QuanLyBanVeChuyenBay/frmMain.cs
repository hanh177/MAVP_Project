﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanVeChuyenBay
{
    public partial class frmMain : Form
    {
        Form login;
        public frmMain(Form frmLogin)
        {
            InitializeComponent();
            this.login = frmLogin;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frontChữToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtUserName.Text = frmLogin.username.ToString();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
           
        }

        private void btnNhanLich_Click(object sender, EventArgs e)
        {
            Form nhanlich = new frmNhanLich(this);
            this.Hide();
            nhanlich.Show();
                
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            Form danhsachcb = new frmDanSachCB(this);
            this.Hide();
            danhsachcb.Show();
        }

         private void btnXemPhieuDatCho_Click(object sender, EventArgs e)
        {
             Form phieudatcho = new frmPhieuDatCho(this);

            this.Hide();
            phieudatcho.Show();
        }
       public void btnXemPhieuDatCho_Clicked(object sender, EventArgs e)
        {
            this.btnXemPhieuDatCho_Click(btnXemPhieuDatCho, EventArgs.Empty);
        }
        private void btnBanVe_Click(object sender, EventArgs e)
        {
            Form banve = new frmBanVe(this);
            this.Hide();
            banve.Show();
        }

        private void btnSuaDoiQD_Click(object sender, EventArgs e)
        {
            Form suadoiqd = new frmSuaDoiQD(this);
            this.Hide();
            suadoiqd.Show();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            Form baocaothang = new frmBaoCaoThang(this);
            this.Hide();
            baocaothang.Show();
        }
    }
}
