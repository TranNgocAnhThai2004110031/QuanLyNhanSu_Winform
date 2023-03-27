using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Quản_Lý_Nhân_Sự.BLL;

namespace Quản_Lý_Nhân_Sự
{
    public partial class GUINhanVien : Form
    {
        private bool isexit = true;
        private bool n = false;
        private NhanVienBLL nhanVienBLL;
        private Import_Export import_Export;
        public GUINhanVien()
        {
            InitializeComponent();
            nhanVienBLL = new NhanVienBLL();
            import_Export = new Import_Export();
        }

        #region none
        private void button4_Click(object sender, EventArgs e)
        {
            textBoxHoVaTen.Text = "";
            dateTimePicker1.Text = "1/1/2000";
            comboBoxMale.Text = "";
            textBoxSdt.Text = "";
            textBoxDiaChi.Text = "";
            comboBoxTrinhdoHocVan.Text = "";
            textBoxEmail.Text = "";
            textBoxChuyenMon.Text = "";
            textBoxMaNhanVien.Text = "";
            comboBoxPhongBan.Text = "";
            textBoxChucVu.Text = "";
            comboBoxState.Text = "";
            textBoxLuong.Text = "";
            textBoxSdt.Text = "";
            textBoxHoVaTen.Focus();
            showAllNhanVien();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (checkNhap())
            {
                NhanVienDTO tblNhanVien = new NhanVienDTO();
                tblNhanVien.MaNhanVien = textBoxMaNhanVien.Text;
                tblNhanVien.HoVaTen = textBoxHoVaTen.Text;
                tblNhanVien.DiaChi = textBoxDiaChi.Text;
                tblNhanVien.SoDienThoai = textBoxPhuCap.Text;
                tblNhanVien.NgaySinh = dateTimePicker1.Text;
                tblNhanVien.GioiTinh = comboBoxMale.Text;
                tblNhanVien.ChucVu = textBoxChucVu.Text;
                tblNhanVien.PhongBan = comboBoxPhongBan.Text;
                tblNhanVien.Luong = float.Parse(textBoxLuong.Text);
                tblNhanVien.PhuCap = float.Parse(textBoxPhuCap.Text);
                tblNhanVien.TrangThai = comboBoxState.Text;
                tblNhanVien.TrinhDoHocVan = comboBoxTrinhdoHocVan.Text;
                tblNhanVien.ChuyenMon = textBoxChuyenMon.Text;
                tblNhanVien.Email = textBoxEmail.Text;

                if (nhanVienBLL.insertNhanVien(tblNhanVien))
                {
                    showAllNhanVien();
                    MessageBox.Show("Thêm thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                    MessageBox.Show("Đã có lỗi xảy ra vui lòng thử lại!!!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        #endregion

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            textBoxHoVaTen.Text = "";
            dateTimePicker1.Text = "1/1/2000";
            comboBoxMale.Text = "";
            textBoxSdt.Text = "";
            textBoxDiaChi.Text = "";
            comboBoxTrinhdoHocVan.Text = "";
            textBoxEmail.Text = "";
            textBoxChuyenMon.Text = "";
            textBoxMaNhanVien.Text = "";
            comboBoxPhongBan.Text = "";
            textBoxChucVu.Text = "";
            comboBoxState.Text = "";
            textBoxLuong.Text = "";
            textBoxPhuCap.Text = "";
            textBoxHoVaTen.Focus();
            showAllNhanVien();
        }
        public void showAllNhanVien()
        {
            DataTable dt = nhanVienBLL.getAllNhanVien();
            dataGridView2.DataSource = dt;
        }

        #region tool windowls
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (n)
            {
                this.WindowState = FormWindowState.Maximized;
                n = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                n = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        private bool checkNhap()
        {
            if (textBoxHoVaTen.Text == "" || dateTimePicker1.Text == "" ||
               textBoxDiaChi.Text == "" || comboBoxMale.Text == "" ||
               textBoxMaNhanVien.Text == "" || textBoxChucVu.Text == "" ||
               textBoxLuong.Text == "" || comboBoxPhongBan.Text == "" ||
               comboBoxState.Text == "" || textBoxPhuCap.Text == "")
            {
                MessageBox.Show("Bạn vui lòng nhập đầy đủ thông tin vào ô có đánh dấu (*)", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                NhanVienDTO tblNhanVien = new NhanVienDTO();
                tblNhanVien.MaNhanVien = textBoxMaNhanVien.Text;
                if (nhanVienBLL.deleteNhanVien(tblNhanVien))
                {
                    showAllNhanVien();
                    MessageBox.Show("Xóa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);

                }
                else
                    MessageBox.Show("Đã có lỗi xảy ra vui lòng thử lại!!!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void buttonedit_Click(object sender, EventArgs e)
        {
            if (checkNhap())
            {
                NhanVienDTO tblNhanVien = new NhanVienDTO();
                tblNhanVien.MaNhanVien = textBoxMaNhanVien.Text;
                tblNhanVien.HoVaTen = textBoxHoVaTen.Text;
                tblNhanVien.DiaChi = textBoxDiaChi.Text;
                tblNhanVien.SoDienThoai = textBoxSdt.Text;
                tblNhanVien.NgaySinh = dateTimePicker1.Text;
                tblNhanVien.GioiTinh = comboBoxMale.Text;
                tblNhanVien.ChucVu = textBoxChucVu.Text;
                tblNhanVien.PhongBan = comboBoxPhongBan.Text;
                tblNhanVien.Luong = float.Parse(textBoxLuong.Text);
                tblNhanVien.PhuCap = float.Parse(textBoxPhuCap.Text);
                tblNhanVien.TrangThai = comboBoxState.Text;
                tblNhanVien.TrinhDoHocVan = comboBoxTrinhdoHocVan.Text;
                tblNhanVien.ChuyenMon = textBoxChuyenMon.Text;
                tblNhanVien.Email = textBoxEmail.Text;

                if (nhanVienBLL.updateNhanVien(tblNhanVien))
                {
                    showAllNhanVien();
                    MessageBox.Show("Sửa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                    MessageBox.Show("Đã có lỗi xảy ra vui lòng thử lại!!!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }

        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (isexit)
            {
                if (MessageBox.Show("Bạn muốn thoát chương trình?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Application.Exit();
            }
        }
        private void buttonRE_Click(object sender, EventArgs e)
        {
            showAllNhanVien();
        }
        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView2.CurrentRow.Index;

            textBoxMaNhanVien.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            textBoxHoVaTen.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            textBoxDiaChi.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
            textBoxSdt.Text = dataGridView2.Rows[i].Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView2.Rows[i].Cells[4].Value.ToString();
            comboBoxMale.Text = dataGridView2.Rows[i].Cells[5].Value.ToString();
            textBoxChucVu.Text = dataGridView2.Rows[i].Cells[6].Value.ToString();
            comboBoxPhongBan.Text = dataGridView2.Rows[i].Cells[7].Value.ToString();
            textBoxLuong.Text = dataGridView2.Rows[i].Cells[8].Value.ToString();
            textBoxPhuCap.Text = dataGridView2.Rows[i].Cells[9].Value.ToString();
            comboBoxState.Text = dataGridView2.Rows[i].Cells[10].Value.ToString();
            comboBoxTrinhdoHocVan.Text = dataGridView2.Rows[i].Cells[11].Value.ToString();
            textBoxChuyenMon.Text = dataGridView2.Rows[i].Cells[12].Value.ToString();
            textBoxEmail.Text = dataGridView2.Rows[i].Cells[13].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Import Excel";
            openFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    import_Export.import_Excel(openFileDialog.FileName, dataGridView2);
                    MessageBox.Show("Nhập file thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nhập file không thành công!\n" + ex.Message);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Report Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    import_Export.export_Excel(saveFileDialog.FileName, dataGridView2);
                    MessageBox.Show("Xuất file thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công!\n" + ex.Message);
                }
            }
        }
    }
}
