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
    public partial class GUIUser : Form
    {
        private bool isexit = true;
        private UserBLL userBLL;
        private int id;
        public GUIUser()
        {
            InitializeComponent();
            userBLL = new UserBLL();
            showAllUsers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (checkNhap())
            {
                UsersDTO tblUsers = new UsersDTO();
                tblUsers.Id = id;
                tblUsers.Username = textBoxTaiKhoan.Text;
                tblUsers.Password = textBoxMatKhau.Text;
                tblUsers.AccountTypes = comboBox1.Text;


                if (userBLL.insertUser(tblUsers))
                {
                    showAllUsers();
                    MessageBox.Show("Thêm thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                    MessageBox.Show("Đã có lỗi xảy ra vui lòng thử lại!!!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                UsersDTO tblUsers = new UsersDTO();
                tblUsers.Username = textBoxTaiKhoan.Text;
                tblUsers.Id = id;
                if (userBLL.deleteUser(tblUsers))
                {
                    showAllUsers();
                    MessageBox.Show("Xóa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                    MessageBox.Show("Đã có lỗi xảy ra vui lòng thử lại!!!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void buttonsua_Click(object sender, EventArgs e)
        {
            if (checkNhap())
            {
                UsersDTO tblUsers = new UsersDTO();
                tblUsers.Username = textBoxTaiKhoan.Text;
                tblUsers.Password = textBoxMatKhau.Text;
                tblUsers.AccountTypes = comboBox1.Text;

                if (userBLL.updateUser(tblUsers))
                {
                    showAllUsers();
                    MessageBox.Show("Sửa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                    MessageBox.Show("Username không được chỉnh sửa!!!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        private void buttonlammoi_Click(object sender, EventArgs e)
        {
            textBoxTaiKhoan.Text = "";
            textBoxMatKhau.Text = "";
            comboBox1.Text = "";

            showAllUsers();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            if (isexit)
            {
                if (MessageBox.Show("Bạn muốn thoát chương trình?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Application.Exit();
            }         
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            textBoxTaiKhoan.Text = "";
            textBoxMatKhau.Text = "";
            comboBox1.Text = "";
            textBoxTaiKhoan.Focus();
            showAllUsers();
        }
        public void showAllUsers()
        {
            DataTable dt = userBLL.getAllUser();
            dataGridView2.DataSource = dt;
        }

        private bool checkNhap()
        {
            if (textBoxTaiKhoan.Text == "" || textBoxMatKhau.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Bạn vui lòng nhập đầy đủ thông tin vào ô có đánh dấu (*)", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                id = Int32.Parse(dataGridView2.Rows[i].Cells["Id"].Value.ToString());
                textBoxTaiKhoan.Text = dataGridView2.Rows[i].Cells["Username"].Value.ToString();
                textBoxMatKhau.Text = dataGridView2.Rows[i].Cells["Password"].Value.ToString();
                comboBox1.Text = dataGridView2.Rows[i].Cells["AccessRights"].Value.ToString();
            }
        }
        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                id = Int32.Parse(dataGridView2.Rows[i].Cells["Id"].Value.ToString());
                textBoxTaiKhoan.Text = dataGridView2.Rows[i].Cells["Username"].Value.ToString();
                textBoxMatKhau.Text = dataGridView2.Rows[i].Cells["Password"].Value.ToString();
                comboBox1.Text = dataGridView2.Rows[i].Cells["AccessRights"].Value.ToString();
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
