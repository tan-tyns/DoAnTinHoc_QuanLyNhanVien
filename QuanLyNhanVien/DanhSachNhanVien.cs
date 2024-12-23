using DoAnTinHoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    [Serializable]
    public class DanhSachNhanVien
    {
        List<NhanVien> dsNhanVien;

        public DanhSachNhanVien()
        {
            this.dsNhanVien = new List<NhanVien>();
        }
        public DanhSachNhanVien(List<NhanVien> dsNhanVien)
        {
            this.dsNhanVien = dsNhanVien;
        }
        public List<NhanVien> getDanhSachNhanVien()
        {
            return this.dsNhanVien;
        }
        public bool Them(NhanVien nv)
        {
            if (!KiemTraMa(nv.MaNV))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Prevent adding the employee if the code already exists
            }
            dsNhanVien.Add(nv);
            return true;
        }
        public bool KiemTraMa(string ma)
        {
            foreach (NhanVien nv in dsNhanVien)
            {
                if (nv.MaNV.Equals(ma, StringComparison.OrdinalIgnoreCase))
                {
                    return false; // Case-insensitive check for duplicate code
                }
            }

            return true;
        }
        public bool Sua(NhanVien nv,int viTri)
        {
            if (viTri < 0 || viTri >= dsNhanVien.Count)
            {
                MessageBox.Show("Vị trí không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!KiemTraMa(nv.MaNV) && dsNhanVien[viTri].MaNV != nv.MaNV)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            dsNhanVien[viTri] = nv;
            return true;
        }
        public bool Xoa(int viTri)
        {
            if (viTri < 0 || viTri >= dsNhanVien.Count)
            {
                return false;
            }

            dsNhanVien.RemoveAt(viTri);
            return true;
        }
        public List<NhanVien> TimNhanVienCoLuongCaoNhat()
        {
            float luongCaoNhat = dsNhanVien.Max(nv => nv.Luong);
            return dsNhanVien.Where(nv => nv.Luong == luongCaoNhat).ToList();
        }
        public List<NhanVien> TimNhanVienCoLuongThapNhat()
        {
            float luongThapNhat = dsNhanVien.Min(nv => nv.Luong);
            return dsNhanVien.Where(nv => nv.Luong == luongThapNhat).ToList();
        }
        public List<NhanVien> TimNhanVienTheoMaNV(string maNV)
        {  
            if (string.IsNullOrWhiteSpace(maNV))
            {
                return new List<NhanVien>();
            }

            return dsNhanVien.Where(nv => nv.MaNV.Equals(maNV, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public List<NhanVien> SapXepNhanVienLuongCaoDenThap()
        {
            return dsNhanVien.OrderByDescending(nv => nv.Luong).ToList();
        }
        public List<NhanVien> SapXepLuongThapDenCao()
        {
            return dsNhanVien.OrderBy(nv => nv.Luong).ToList();
        }
        public List<NhanVien> SapXepTheoMaNV()
        {
            return dsNhanVien.OrderBy(nv => nv.MaNV).ToList();
        }
    }
}
