﻿namespace QuanLyBanVeChuyenBay
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSuaDoiQD = new System.Windows.Forms.Button();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.btnDSKH = new System.Windows.Forms.Button();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.btnNhanLich = new System.Windows.Forms.Button();
            this.btnDanhSach = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSbtnCaiDat = new System.Windows.Forms.ToolStripDropDownButton();
            this.frontChữToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.màuNềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tSbtnHelp = new System.Windows.Forms.ToolStripDropDownButton();
            this.nhậnLịchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bánVéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tSbtnDangXuat = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tài khoản:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(174, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bán Vé Máy Bay";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSuaDoiQD);
            this.groupBox2.Controls.Add(this.btnDoanhThu);
            this.groupBox2.Controls.Add(this.btnDSKH);
            this.groupBox2.Controls.Add(this.btnTraCuu);
            this.groupBox2.Controls.Add(this.btnNhanLich);
            this.groupBox2.Controls.Add(this.btnDanhSach);
            this.groupBox2.Location = new System.Drawing.Point(12, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 172);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnSuaDoiQD
            // 
            this.btnSuaDoiQD.Location = new System.Drawing.Point(224, 102);
            this.btnSuaDoiQD.Name = "btnSuaDoiQD";
            this.btnSuaDoiQD.Size = new System.Drawing.Size(91, 47);
            this.btnSuaDoiQD.TabIndex = 2;
            this.btnSuaDoiQD.Text = "Sửa Đổi QĐ";
            this.btnSuaDoiQD.UseVisualStyleBackColor = true;
            this.btnSuaDoiQD.Click += new System.EventHandler(this.btnSuaDoiQD_Click);
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.Location = new System.Drawing.Point(366, 102);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(91, 47);
            this.btnDoanhThu.TabIndex = 1;
            this.btnDoanhThu.Text = "Báo cáo doanh thu";
            this.btnDoanhThu.UseVisualStyleBackColor = true;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // btnDSKH
            // 
            this.btnDSKH.Location = new System.Drawing.Point(366, 33);
            this.btnDSKH.Name = "btnDSKH";
            this.btnDSKH.Size = new System.Drawing.Size(91, 47);
            this.btnDSKH.TabIndex = 1;
            this.btnDSKH.Text = "Danh Sách Khách Hàng";
            this.btnDSKH.UseVisualStyleBackColor = true;
            this.btnDSKH.Click += new System.EventHandler(this.btnDSKH_Click_1);
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(75, 102);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(91, 47);
            this.btnTraCuu.TabIndex = 1;
            this.btnTraCuu.Text = "Tra Cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // btnNhanLich
            // 
            this.btnNhanLich.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNhanLich.Location = new System.Drawing.Point(75, 33);
            this.btnNhanLich.Name = "btnNhanLich";
            this.btnNhanLich.Size = new System.Drawing.Size(91, 47);
            this.btnNhanLich.TabIndex = 1;
            this.btnNhanLich.Text = "Nhận lịch chuyến bay";
            this.btnNhanLich.UseVisualStyleBackColor = true;
            this.btnNhanLich.Click += new System.EventHandler(this.btnNhanLich_Click);
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.Location = new System.Drawing.Point(224, 33);
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.Size = new System.Drawing.Size(91, 47);
            this.btnDanhSach.TabIndex = 1;
            this.btnDanhSach.Text = "Danh Sách Chuyến Bay";
            this.btnDanhSach.UseVisualStyleBackColor = true;
            this.btnDanhSach.Click += new System.EventHandler(this.btnDanhSach_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSbtnCaiDat,
            this.tSbtnHelp,
            this.tSbtnDangXuat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(547, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tSbtnCaiDat
            // 
            this.tSbtnCaiDat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frontChữToolStripMenuItem,
            this.màuNềnToolStripMenuItem,
            this.etcToolStripMenuItem});
            this.tSbtnCaiDat.Image = ((System.Drawing.Image)(resources.GetObject("tSbtnCaiDat.Image")));
            this.tSbtnCaiDat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSbtnCaiDat.Name = "tSbtnCaiDat";
            this.tSbtnCaiDat.Size = new System.Drawing.Size(73, 22);
            this.tSbtnCaiDat.Text = "&Cài đặt";
            // 
            // frontChữToolStripMenuItem
            // 
            this.frontChữToolStripMenuItem.Name = "frontChữToolStripMenuItem";
            this.frontChữToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.frontChữToolStripMenuItem.Text = "Front chữ";
            this.frontChữToolStripMenuItem.Click += new System.EventHandler(this.frontChữToolStripMenuItem_Click);
            // 
            // màuNềnToolStripMenuItem
            // 
            this.màuNềnToolStripMenuItem.Name = "màuNềnToolStripMenuItem";
            this.màuNềnToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.màuNềnToolStripMenuItem.Text = "Màu nền";
            // 
            // etcToolStripMenuItem
            // 
            this.etcToolStripMenuItem.Name = "etcToolStripMenuItem";
            this.etcToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.etcToolStripMenuItem.Text = "etc";
            // 
            // tSbtnHelp
            // 
            this.tSbtnHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậnLịchToolStripMenuItem,
            this.bánVéToolStripMenuItem,
            this.ectToolStripMenuItem});
            this.tSbtnHelp.Image = ((System.Drawing.Image)(resources.GetObject("tSbtnHelp.Image")));
            this.tSbtnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSbtnHelp.Name = "tSbtnHelp";
            this.tSbtnHelp.Size = new System.Drawing.Size(61, 22);
            this.tSbtnHelp.Text = "Help";
            // 
            // nhậnLịchToolStripMenuItem
            // 
            this.nhậnLịchToolStripMenuItem.Name = "nhậnLịchToolStripMenuItem";
            this.nhậnLịchToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.nhậnLịchToolStripMenuItem.Text = "Nhận lịch ";
            // 
            // bánVéToolStripMenuItem
            // 
            this.bánVéToolStripMenuItem.Name = "bánVéToolStripMenuItem";
            this.bánVéToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.bánVéToolStripMenuItem.Text = "Bán vé";
            // 
            // ectToolStripMenuItem
            // 
            this.ectToolStripMenuItem.Name = "ectToolStripMenuItem";
            this.ectToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.ectToolStripMenuItem.Text = "ect";
            // 
            // tSbtnDangXuat
            // 
            this.tSbtnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("tSbtnDangXuat.Image")));
            this.tSbtnDangXuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSbtnDangXuat.Name = "tSbtnDangXuat";
            this.tSbtnDangXuat.Size = new System.Drawing.Size(80, 22);
            this.tSbtnDangXuat.Text = "&Đăng xuất";
            this.tSbtnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 414);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDanhSach;
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.Button btnDSKH;
        private System.Windows.Forms.Button btnNhanLich;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tSbtnCaiDat;
        private System.Windows.Forms.ToolStripMenuItem frontChữToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem màuNềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tSbtnDangXuat;
        private System.Windows.Forms.ToolStripMenuItem etcToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tSbtnHelp;
        private System.Windows.Forms.ToolStripMenuItem nhậnLịchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bánVéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ectToolStripMenuItem;
        private System.Windows.Forms.Button btnSuaDoiQD;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Label label3;
    }
}