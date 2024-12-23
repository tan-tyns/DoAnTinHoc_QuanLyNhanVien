using DoAnTinHoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class fQuanLyNhanVien : Form
    {
        DanhSachNhanVien dsNhanVien = new DanhSachNhanVien();
        private int viTri = -1;
        public fQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void HienThiDanhSachNhanVien(DataGridView dgv, List<NhanVien> ds)
        {
            dgv.DataSource = null;
            dgv.DataSource = ds;
            dgv.Refresh();
        }
        private void fQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            TruyCapDuLieu.KhoiTao();
        }

        private void nhậpDữLiệuTừFileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (TruyCapDuLieu.docFile("DanhSachNhanVien.dat"))
            {
                // Cập nhật danh sách nhân viên từ instance của TruyCapDuLieu
                dsNhanVien = new DanhSachNhanVien(TruyCapDuLieu.KhoiTao().GetDanhSachNhanVien());

                // Nếu đọc thành công, cập nhật DataGridView
                HienThiDanhSachNhanVien(dgvDSNhanVien, dsNhanVien.getDanhSachNhanVien());
            }
            else
            {
                MessageBox.Show("Không thể đọc dữ liệu từ file.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbThem_Click(object sender, EventArgs e)
        {
            fThemNhanVien fAdd = new fThemNhanVien(dgvDSNhanVien, dsNhanVien);
            fAdd.ShowDialog();
        }

        private void xuấtFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool KetQuaGhiFile = TruyCapDuLieu.ghiFile("DanhSachNhanVien.dat");
            if (KetQuaGhiFile == true) MessageBox.Show("Đã Ghi File Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Ghi File thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void tsbSua_Click(object sender, EventArgs e)
        {
            if (viTri == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                fSuaNhanVien fEdit = new fSuaNhanVien(dgvDSNhanVien, dsNhanVien, viTri);
                fEdit.ShowDialog();
            }
        }

        private void dgvDSNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                viTri = e.RowIndex;
            }
        }

        private void tsbXoa_Click(object sender, EventArgs e)
        {
            if (viTri == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; 
            }

           
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa nhân viên này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
               
                if (dsNhanVien.Xoa(viTri)) 
                {
                    MessageBox.Show("Đã xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDanhSachNhanVien(dgvDSNhanVien, dsNhanVien.getDanhSachNhanVien());
                    viTri = -1; 
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi xóa vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (rBLuongCaoNhat.Checked)
            {
                var danhSachNhanVien = dsNhanVien.TimNhanVienCoLuongCaoNhat();  
                HienThiDanhSachNhanVien(dgvDSNhanVien, danhSachNhanVien);
            }
            else if (rBLuongThapNhat.Checked)
            {
                var danhSachNhanVien = dsNhanVien.TimNhanVienCoLuongThapNhat(); 
                HienThiDanhSachNhanVien(dgvDSNhanVien, danhSachNhanVien);
            }
            else if (rBMaNV.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtMaCanTim.Text)) 
                {
                    MessageBox.Show("Vui lòng nhập mã nhân viên bạn cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;  
                }
                else
                {
                    var danhSachNhanVien = dsNhanVien.TimNhanVienTheoMaNV(txtMaCanTim.Text); 
                    HienThiDanhSachNhanVien(dgvDSNhanVien, danhSachNhanVien);
                }
            }
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            if (rBLuongCaoDenThap.Checked)
            {
                var danhSachNhanVien = dsNhanVien.SapXepNhanVienLuongCaoDenThap();
                HienThiDanhSachNhanVien(dgvDSNhanVien, danhSachNhanVien);
            }
            else if (rBLuongThapDenCao.Checked)
            {
                var danhSachNhanVien = dsNhanVien.SapXepLuongThapDenCao();
                HienThiDanhSachNhanVien(dgvDSNhanVien, danhSachNhanVien);
            }
            else if (rBMaNV.Checked)
            {
                var danhSachNhanVien = dsNhanVien.SapXepTheoMaNV();
                HienThiDanhSachNhanVien(dgvDSNhanVien, danhSachNhanVien);
            }
        }

        private void xóaDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tất cả dữ liệu nhân viên không?",
                                          "Xác nhận xóa",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                dsNhanVien = new DanhSachNhanVien(); 


                HienThiDanhSachNhanVien(dgvDSNhanVien, dsNhanVien.getDanhSachNhanVien());

                MessageBox.Show("Đã xóa tất cả dữ liệu nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsbReload_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (dsNhanVien.getDanhSachNhanVien() != null && dsNhanVien.getDanhSachNhanVien().Count > 0)
                {
                    // Làm mới dữ liệu trong DataGridView
                    HienThiDanhSachNhanVien(dgvDSNhanVien, dsNhanVien.getDanhSachNhanVien());
                }
                else
                {
                    // Nếu danh sách rỗng, hiển thị thông báo
                    MessageBox.Show("Danh sách nhân viên trống. Vui lòng thêm nhân viên trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show($"Lỗi khi làm mới danh sách nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
