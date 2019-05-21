﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace QuanLyBanVeChuyenBay
{
    public partial class frmNhanLich : Form
    {
        Form main;
        public frmNhanLich(Form frmMain)
        {
            InitializeComponent();
            this.main = frmMain;
        }

        string MACHUYENBAYCUOI;

        //string strconn2 = @"Data Source=DESKTOP-JLJ2TBG;Initial Catalog=QLBanVeChuyenBay;Integrated Security=True";

        string strconn2 = @"Data Source=DESKTOP-TA2HS1O\SQLEXPRESS;Initial Catalog=QLBanVeChuyenBay;Integrated Security=True"; //cua ha anh

        private void Connection()
        {
            SqlConnection conn = new SqlConnection(strconn2);
            try
            {
                conn.Open();
                string sql = "SELECT * FROM SANBAY";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                DataTable table2 = new DataTable();
                DataTable table3 = new DataTable();
                adapter.Fill(table);
                adapter.Fill(table2);
                adapter.Fill(table3);
              
                cmbSanBayDi.DataSource = table;
                cmbSanBayDi.DisplayMember = "TenSanBay";
                cmbSanBayDi.ValueMember = "MaSanBay";
              
                cmbSanBayDen.DataSource = table2;
                cmbSanBayDen.DisplayMember = "TenSanBay";
                cmbSanBayDen.ValueMember = "MaSanBay";

                cmbTenSBTrungGian.DataSource = table3;
                cmbTenSBTrungGian.DisplayMember = "TenSanBay";
                cmbTenSBTrungGian.ValueMember = "MaSanBay";

                command.ExecuteNonQuery();

                //Lay ma chuyen bay cuoi cung va cap nhat len 1
                string sql2 = "select Max(MaCB) as LastID from CHUYENBAY";
                SqlCommand command2 = new SqlCommand(sql2, conn);
                SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
                DataSet dataSet = new DataSet();
                adapter2.Fill(dataSet, "MaCB");
                DataTable table4 = dataSet.Tables["MaCB"];
               
                    foreach (DataRow row in table4.Rows)
                    {
                        foreach (DataColumn col in table4.Columns)
                        {
                            MACHUYENBAYCUOI = row[col].ToString();
                        if (MACHUYENBAYCUOI == "") // neu chua co CB nao trong danh sach
                            MACHUYENBAYCUOI = "CB00";
                        }
                    }
                    string macb = MACHUYENBAYCUOI.Substring(2);
                    int socb = Int32.Parse(macb);
                    socb = socb + 1;
                    bool flag = false;
                    if (socb < 10)
                        flag = true;
                    if (flag == true)
                    {
                        txtMaCB.Text = "CB0" + socb.ToString();
                    }
                    else
                        txtMaCB.Text = "CB" + socb.ToString();
                
               
            }
            catch (InvalidOperationException ex)
            {
                //xu ly khi ket noi co van de
                MessageBox.Show("Khong the mo ket noi hoac ket noi da mo truoc do");
            }
            catch (Exception ex)
            {
                //xu ly khi ket noi co van de
                MessageBox.Show("Ket noi xay ra loi hoac doc du lieu bi loi");
            }
            finally
            {
                //Dong ket noi sau khi thao tac ket thuc
                conn.Close();
            }
        }
       
   
        private void frmNhanLich_Load(object sender, EventArgs e)
        {
            Connection();
            DateTime dt = DateTime.Now;
            dateTimePicker1.MinDate = dt;
           

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void tSbtnDanhSachCB_Click(object sender, EventArgs e)
        {
            Form danhsachcb = new frmDanSachCB(this);
            this.Hide();
            danhsachcb.Show();
        }

        private void tSbtnDanhSachSB_Click(object sender, EventArgs e)
        {
            Form danhsachsb = new frmDanhSachSB(this);
            this.Hide();
            danhsachsb.Show();
        }
  
        public virtual string ValueMember { get; set; }

        string MASB;
        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn2);
           
            try
            {
                string MACB = txtMaCB.Text;
                string SANBAYDI = cmbSanBayDi.SelectedValue.ToString();
                string SANBAYDEN = cmbSanBayDen.SelectedValue.ToString();
                int THOIGIANBAY = Int32.Parse(txtThGianBay.Text);
                int SOGHEH1 = Int32.Parse(txtSoGheH1.Text);
                int SOGHEH2 = Int32.Parse(txtSoGheH2.Text);
                int GIAVE = Int32.Parse(txtGiaVe.Text);
                // DateTime NGAYBAY = DateTime.ParseExact(dateTimePicker1.Text, "dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture);
                DateTime NGAYBAY = dateTimePicker1.Value;
    
                //string t = dateTimePicker1.Text;
                //string tt = t.Substring(17);
               
                //if (tt == "PM")
                //{
                //    MessageBox.Show(".");
                ////    string date = t.Substring(0, 11); //ngaythang 
                ////    int h = Int32.Parse(t.Substring(12, 13)) + 12;
                ////    string strhour = h.ToString();  //gio
                ////    string m = t.Substring(14, 16); //phut

                ////    string datetime = date + strhour + m;
                ////    MessageBox.Show(datetime);
                //}
                ////if(tt=="PM")
                ////{
                ////    NGAYBAY = DateTime.ParseExact(datetime, "dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture);
                ////}
               
                conn.Open();
                String sqlQuery = "insert into [QLBanVeChuyenBay].[dbo].[CHUYENBAY] values ( " + "@MaCB, @SanBayDi, @SanBayDen,@NgayGio,@ThoiGianBay,@SLGheHang1,@SLGheHang2,@GiaVe)";
                SqlCommand command = new SqlCommand(sqlQuery, conn);
                command.Parameters.AddWithValue("@MaCB", MACB);
                command.Parameters.AddWithValue("@SanBayDi", SANBAYDI);
                command.Parameters.AddWithValue("@SanBayDen", SANBAYDEN);
                command.Parameters.AddWithValue("@NgayGio", NGAYBAY);
                command.Parameters.AddWithValue("@ThoiGianBay", THOIGIANBAY);
                command.Parameters.AddWithValue("@SLGheHang1", SOGHEH1);
                command.Parameters.AddWithValue("@SLGheHang2", SOGHEH2);
                command.Parameters.AddWithValue("@GiaVe", GIAVE);
                command.ExecuteNonQuery();

                string TENSBTG = dataSanBayTG.CurrentRow.Cells[1].EditedFormattedValue.ToString();

                if (TENSBTG != "")
                {
                    string sql = "SELECT MaSanBay FROM SANBAY WHERE TenSanBay=@TenSanBay";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@TenSanBay", TENSBTG);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "MaSB");
                    DataTable table = dataSet.Tables["MaSB"];

                    foreach (DataRow row in table.Rows)
                    {
                        foreach (DataColumn col in table.Columns)
                        {
                            MASB = row[col].ToString();

                        }
                    }

                    object value = cmd.ExecuteScalar();

                    string MATG = dataSanBayTG.CurrentRow.Cells[0].EditedFormattedValue.ToString();
                    string TGDUNG = dataSanBayTG.CurrentRow.Cells[2].EditedFormattedValue.ToString();
                    string GHICHU = dataSanBayTG.CurrentRow.Cells[3].EditedFormattedValue.ToString();
                    string sqlQuery2 = "insert into [QLBanVeChuyenBay].[dbo].[TRUNGGIAN] values ( " + "@MaTrungGian,@MaCB,@MaSanBay,@ThoiGianDung,@GhiChu)";
                    SqlCommand command3 = new SqlCommand(sqlQuery2, conn);
                    command3.Parameters.AddWithValue("@MaTrungGian", MATG);
                    command3.Parameters.AddWithValue("@MaCB", MACB);
                    command3.Parameters.AddWithValue("@MaSanBay", MASB); //check lai ma san bay nhe, khong dung input.are u here yes
                    command3.Parameters.AddWithValue("@ThoiGianDung", TGDUNG);
                    command3.Parameters.AddWithValue("@GhiChu", GHICHU);

                    command3.ExecuteNonQuery();

                }
                

                MessageBox.Show("Thêm chuyến bay thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);


                string MATT = "TT" + txtMaCB.Text.Substring(2);
                string sqlQuery3 = "insert into[QLBanVeChuyenBay].[dbo].[TINHTRANG] values(" + "@MaTinhTrang, @MaCB, @SLGheTrongH1, @SLGheTrongH2,@TongSoGhe, @TongSoGheTrong,@TongSoGheDat)";
                SqlCommand command4= new SqlCommand(sqlQuery3, conn);
                command4.Parameters.AddWithValue("@MaTinhTrang", MATT);
                command4.Parameters.AddWithValue("@MaCB", MACB);
                command4.Parameters.AddWithValue("@SLGheTrongH1", SOGHEH1);
                command4.Parameters.AddWithValue("@SLGheTrongH2", SOGHEH2);
                command4.Parameters.AddWithValue("@TongSoGhe", SOGHEH1 + SOGHEH2);
                command4.Parameters.AddWithValue("@TongSoGheTrong", SOGHEH1+ SOGHEH2);
                command4.Parameters.AddWithValue("@TongSoGheDat", 0);
                command4.ExecuteNonQuery();

                txtMaCB.Text = "";
                cmbSanBayDi.Text= "";
                cmbSanBayDen.Text = "";
                dateTimePicker1.Text = "";
                txtSoGheH1.Text = "";
                txtSoGheH2.Text = "";
                txtThGianBay.Text = "";
                txtGiaVe.Text = "";
            }
            catch (InvalidOperationException ex)
            {
                //xu ly khi ket noi co van de
                MessageBox.Show("Khong the mo ket noi hoac ket noi da mo truoc do");
            }
            catch (Exception ex)
            {
                //xu ly khi ket noi co van de
                // MessageBox.Show("Ket noi xay ra loi hoac doc du lieu bi loi");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Dong ket noi sau khi thao tac ket thuc
                conn.Close();
            }
        } 
    }
}
