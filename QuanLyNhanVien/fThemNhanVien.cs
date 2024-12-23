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
    public partial class fThemNhanVien : Form
    {
        DataGridView data;
        DanhSachNhanVien dsNhanVien;
        public fThemNhanVien()
        {
            InitializeComponent();
        }
        public fThemNhanVien(DataGridView dt,DanhSachNhanVien ds)
        {
            InitializeComponent();
            dsNhanVien = ds;
            data = dt;
        }
        private void btnThem_Click(object sender, EventArgs e)
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
            float heSoLuong=float.Parse(txtHeSoLuong.Text);
            NhanVien nv = new NhanVien(maNV,hoTen,ngaySinh,queQuan,luongCoBan,heSoLuong);
           
            if (dsNhanVien.Them(nv))
            {
                MessageBox.Show("Đã thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            HienThiDanhSachNhanVien(data, dsNhanVien.getDanhSachNhanVien());
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
        private void HienThiDanhSachNhanVien(DataGridView dgv,List<NhanVien> ds)
        {
            dgv.DataSource = null;
            dgv.DataSource = ds;
            dgv.Refresh();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có hủy thêm nhân viên không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void fThemNhanVien_Load(object sender, EventArgs e)
        {
            List<NhanVien> nhanVien = dsNhanVien.getDanhSachNhanVien();
            HienThiDanhSachNhanVien(data, dsNhanVien.getDanhSachNhanVien());

        }
    }
}
