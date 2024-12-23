using DoAnTinHoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class fSuaNhanVien : Form
    {
        private int vt;
        DataGridView data;
        DanhSachNhanVien dsNhanVien;
        public fSuaNhanVien()
        {
            InitializeComponent();
        }
        public fSuaNhanVien(DataGridView dt,DanhSachNhanVien ds,int viTri)
        {
            InitializeComponent();
            data = dt;
            dsNhanVien = ds;
            vt= viTri;
            LoadEmployeeData();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string maNV = txtMaNV.Text;
            string hoTen = txtHoTen.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            string queQuan = txtQueQuan.Text;
            float luongCoBan = float.Parse(txtLuongCoBan.Text);
            float heSoLuong = float.Parse(txtHeSoLuong.Text);
            NhanVien nv = new NhanVien(maNV, hoTen, ngaySinh, queQuan, luongCoBan, heSoLuong);

            
            if (dsNhanVien.Sua(nv, vt))
            {
                MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDanhSachNhanVien(data, dsNhanVien.getDanhSachNhanVien());
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Cập nhật nhân viên không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool KiemTraDuLieu()
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text) ||
                string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(txtQueQuan.Text) ||
                string.IsNullOrWhiteSpace(txtLuongCoBan.Text) ||
                string.IsNullOrWhiteSpace(txtHeSoLuong.Text))
            {
                return false;
            }


            if (!float.TryParse(txtLuongCoBan.Text, out _) || !float.TryParse(txtHeSoLuong.Text, out _))
            {
                return false;
            }

            return true;
        }
        private void HienThiDanhSachNhanVien(DataGridView dgv, List<NhanVien> ds)
        {
            dgv.DataSource = null;
            dgv.DataSource = ds;
            dgv.Refresh();
        }
        private void LoadEmployeeData()
        {
            NhanVien currentEmployee = dsNhanVien.getDanhSachNhanVien()[vt];
            txtMaNV.Text = currentEmployee.MaNV;
            txtHoTen.Text = currentEmployee.HoTen;
            txtQueQuan.Text = currentEmployee.QueQuan;
            dtpNgaySinh.Value = currentEmployee.NgaySinh;
            txtLuongCoBan.Text = currentEmployee.LuongCoBan.ToString();
            txtHeSoLuong.Text = currentEmployee.HeSoLuong.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có hủy sửa nhân viên không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
