using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Nhân_Sự
{
    public partial class GUIPhongBan : Form
    {
        private bool isexit = true;
        private bool n = false;
        private PhongBanBLL phongBanBLL;
        public GUIPhongBan()
        {
            InitializeComponent();
            phongBanBLL = new PhongBanBLL();
            showAllPhongBan();
        }

        public void showAllPhongBan()
        {
            DataTable dt = phongBanBLL.getAllPhongBan();
            dataGridView2.DataSource = dt;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=help&oq=help&aqs=chrome..69i57j0i512j0i131i433i512j0i512j69i61j69i60l3.4629j0j7&sourceid=chrome&ie=UTF-8");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                PhongBanDTO tblPhongBan = new PhongBanDTO();
                tblPhongBan.MaPhong = textBoxMaPhong.Text;
                if (phongBanBLL.deletePhongBan(tblPhongBan))
                {
                    showAllPhongBan();
                    MessageBox.Show("Xóa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                    MessageBox.Show("Đã có lỗi xảy ra vui lòng thử lại!!!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkNhap())
            {
                PhongBanDTO tblPhongBan = new PhongBanDTO();
                tblPhongBan.MaPhong = textBoxMaPhong.Text;
                tblPhongBan.TenPhong = textBoxTenPhong.Text;
                tblPhongBan.SoLuongNhanVien = int.Parse(textBoxSoLuongNhanVien.Text);
                tblPhongBan.NgayThanhLap = dateTimePicker1.Value;
                tblPhongBan.GhiChu = textBoxGhiChu.Text;

                if (phongBanBLL.insertPhongBan(tblPhongBan))
                {
                    showAllPhongBan();
                    MessageBox.Show("Thêm thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                    MessageBox.Show("Đã có lỗi xảy ra vui lòng thử lại!!!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBoxMaPhong.Text = "";
            textBoxTenPhong.Text = "";
            textBoxSoLuongNhanVien.Text = "";
            textBoxGhiChu.Text = "";
            showAllPhongBan();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormDepartment_Load(object sender, EventArgs e)
        {
            textBoxMaPhong.Text = "";
            textBoxTenPhong.Text = "";
            textBoxSoLuongNhanVien.Text = "";
            dateTimePicker1.Text = "1/1/2000";
            textBoxMaPhong.Focus();
            showAllPhongBan();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                textBoxMaPhong.Text = dataGridView2.Rows[i].Cells["MaPhong"].Value.ToString();
                textBoxTenPhong.Text = dataGridView2.Rows[i].Cells["TenPhong"].Value.ToString();
                textBoxSoLuongNhanVien.Text = dataGridView2.Rows[i].Cells["SoLuongNhanVien"].Value.ToString();
                dateTimePicker1.Text = dataGridView2.Rows[i].Cells["NgayThanhLap"].Value.ToString();
                textBoxGhiChu.Text = dataGridView2.Rows[i].Cells["GhiChu"].Value.ToString();
            }
        }

        private bool checkNhap()
        {
            if (textBoxMaPhong.Text == "" || dateTimePicker1.Text == "" || textBoxTenPhong.Text == "")
            {
                MessageBox.Show("Bạn vui lòng nhập đầy đủ thông tin vào ô có đánh dấu (*)", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (checkNhap())
            {
                PhongBanDTO tblPhongBan = new PhongBanDTO();
                tblPhongBan.MaPhong = textBoxMaPhong.Text;
                tblPhongBan.TenPhong = textBoxTenPhong.Text;
                tblPhongBan.SoLuongNhanVien = int.Parse(textBoxSoLuongNhanVien.Text);
                tblPhongBan.NgayThanhLap = dateTimePicker1.Value;
                tblPhongBan.GhiChu = textBoxGhiChu.Text;

                if (phongBanBLL.updatePhongBan(tblPhongBan))
                {
                    showAllPhongBan();
                    MessageBox.Show("Sửa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                    MessageBox.Show("Đã có lỗi xảy ra vui lòng thử lại!!!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            if (isexit)
            {
                if (MessageBox.Show("Bạn muốn thoát chương trình?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Application.Exit();
            }
        }
        private const int WM_MCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);

        private void mix(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(Handle, WM_MCLBUTTONDOWN, HTCAPTION, 0);
        }
    }
}
