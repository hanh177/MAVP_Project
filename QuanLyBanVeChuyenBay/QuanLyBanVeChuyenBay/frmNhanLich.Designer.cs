﻿namespace QuanLyBanVeChuyenBay
{
    partial class frmNhanLich
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanLich));
            this.MaCB = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SanBayDi = new System.Windows.Forms.Label();
            this.btnSanBayDen = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDanhSach = new System.Windows.Forms.ToolStripDropDownButton();
            this.Help = new System.Windows.Forms.ToolStripButton();
            this.btnSetting = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MaCB
            // 
            this.MaCB.AutoSize = true;
            this.MaCB.Location = new System.Drawing.Point(31, 74);
            this.MaCB.Name = "MaCB";
            this.MaCB.Size = new System.Drawing.Size(85, 13);
            this.MaCB.TabIndex = 1;
            this.MaCB.Text = "&Mã Chuyến Bay:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 2;
            // 
            // SanBayDi
            // 
            this.SanBayDi.AutoSize = true;
            this.SanBayDi.Location = new System.Drawing.Point(31, 123);
            this.SanBayDi.Name = "SanBayDi";
            this.SanBayDi.Size = new System.Drawing.Size(63, 13);
            this.SanBayDi.TabIndex = 8;
            this.SanBayDi.Text = "&Sân Bay Đi:";
            // 
            // btnSanBayDen
            // 
            this.btnSanBayDen.AutoSize = true;
            this.btnSanBayDen.Location = new System.Drawing.Point(31, 175);
            this.btnSanBayDen.Name = "btnSanBayDen";
            this.btnSanBayDen.Size = new System.Drawing.Size(73, 13);
            this.btnSanBayDen.TabIndex = 9;
            this.btnSanBayDen.Text = "Sân Bay Đến:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(152, 220);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(191, 20);
            this.textBox7.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(152, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(152, 172);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(191, 21);
            this.comboBox2.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(488, 217);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(191, 20);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ngày Bay:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tổng Thời Gian Bay:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(488, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 20);
            this.textBox2.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(398, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "SL Ghế Hạng 1:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(398, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "SL Ghế Hạng 2:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(488, 120);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(191, 20);
            this.textBox3.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "NHẬN LỊCH CHUYẾN BAY";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(238, 428);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 41);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(388, 428);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 41);
            this.btnThoat.TabIndex = 26;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDanhSach,
            this.Help,
            this.btnSetting});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(723, 25);
            this.toolStrip1.TabIndex = 28;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhSach.Image")));
            this.btnDanhSach.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.Size = new System.Drawing.Size(83, 22);
            this.btnDanhSach.Text = "&DS C.Bay";
            // 
            // Help
            // 
            this.Help.Image = ((System.Drawing.Image)(resources.GetObject("Help.Image")));
            this.Help.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(52, 22);
            this.Help.Text = "&Help";
            this.Help.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(65, 22);
            this.btnSetting.Text = "&Cài Đặt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Giá Vé:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(488, 163);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(191, 20);
            this.textBox4.TabIndex = 30;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.ColTime,
            this.ColNote});
            this.dataGridView1.Location = new System.Drawing.Point(34, 290);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 124);
            this.dataGridView1.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Thông tin sân bay trung gian:\r\n";
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Tên sân bay trung gian";
            this.ColName.Name = "ColName";
            // 
            // ColTime
            // 
            this.ColTime.HeaderText = "Thời gian dừng";
            this.ColTime.Name = "ColTime";
            // 
            // ColNote
            // 
            this.ColNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNote.HeaderText = "Ghi chú";
            this.ColNote.Name = "ColNote";
            // 
            // frmNhanLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 481);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.btnSanBayDen);
            this.Controls.Add(this.SanBayDi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MaCB);
            this.Name = "frmNhanLich";
            this.Text = "Nhận Lịch Chuyến Bay";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MaCB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label SanBayDi;
        private System.Windows.Forms.Label btnSanBayDen;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Help;
        private System.Windows.Forms.ToolStripDropDownButton btnDanhSach;
        private System.Windows.Forms.ToolStripButton btnSetting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNote;
    }
}