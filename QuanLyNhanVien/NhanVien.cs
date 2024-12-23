using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTinHoc
{
    [Serializable]
    public class NhanVien
    {
        private string maNV;
        private string hoTen;
        private DateTime ngaySinh;
        private string queQuan;
        private float luongCoBan;
        private float heSoLuong;
        private float luong;
        public NhanVien()
        {
            this.maNV = null;
            this.hoTen = null;
            this.ngaySinh = DateTime.Now;
            this.queQuan = null;
            this.luongCoBan = 0;
            this.heSoLuong = 0;
        }
        public NhanVien(string maNV, string hoTen, DateTime ngaySinh, string queQuan, float luongCoBan, float heSoLuong)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.queQuan = queQuan;
            this.luongCoBan = luongCoBan;
            this.heSoLuong = heSoLuong;
        }
        public string MaNV
        {
            get { return this.maNV; }
            set { this.maNV = value; }
        }
        public string HoTen
        {
            get { return this.hoTen; }
            set { this.hoTen = value; }
        }
        public DateTime NgaySinh
        {
            get { return this.ngaySinh; }
            set { this.ngaySinh = value; }
        }
        public string QueQuan
        {
            get { return this.queQuan; }
            set { this.queQuan = value; }
        }
        public float LuongCoBan
        {
            get { return this.luongCoBan; }
            set { this.luongCoBan = value; }
        }
        public float HeSoLuong
        {
            get { return this.heSoLuong; }
            set { this.heSoLuong = value; }
        }
        public float tinhLuong()
        {
            return this.luongCoBan * this.heSoLuong;
        }
        public float Luong
        {
            get { return tinhLuong(); }
        }

    }
}
