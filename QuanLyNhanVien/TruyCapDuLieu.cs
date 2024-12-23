using DoAnTinHoc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    [Serializable]
    public class TruyCapDuLieu
    {
        private static TruyCapDuLieu instance = null;
        private List<NhanVien> dsNhanVien;

        private TruyCapDuLieu()
        {
            dsNhanVien = new List<NhanVien>();
        }

        public static TruyCapDuLieu KhoiTao()
        {
            if (instance == null)
                instance = new TruyCapDuLieu();
            return instance;
        }

        public List<NhanVien> GetDanhSachNhanVien()
        {
            return dsNhanVien;
        }

        public static bool docFile(string tenFile)
        {
            try
            {
                using (FileStream fs = new FileStream(tenFile, FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    instance = (TruyCapDuLieu)bf.Deserialize(fs);
                }
                return true;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File không tìm thấy. Vui lòng kiểm tra đường dẫn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (SerializationException)
            {
                MessageBox.Show("Lỗi giải nén file. File có thể bị hỏng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi không mong muốn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static bool ghiFile(string tenFile)
        {
            try
            {
                using (FileStream fs = new FileStream(tenFile, FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, instance);
                }
                return true;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Quyền truy cập bị từ chối. Vui lòng kiểm tra quyền truy cập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (IOException ioEx)
            {
                MessageBox.Show($"Lỗi I/O: {ioEx.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi không mong muốn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
    }
}
