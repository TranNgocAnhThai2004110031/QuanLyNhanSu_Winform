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
using System.Runtime.InteropServices;

namespace Quản_Lý_Nhân_Sự
{
    public partial class GUIMain : Form
    {
        public bool isexit = true;
        public event EventHandler logout;
        private NhanVienBLL nhanVienBLL;
        private DataTable dt;

        private bool n = false;

        //hien menu bien
        private Form activeForm = null;

        public GUIMain()
        {
            InitializeComponent();
            nhanVienBLL = new NhanVienBLL();
            cutsomsizedesig();
            showAllNhanVien();
        }
        private void cutsomsizedesig()
        {
            panelSYSTEM.Visible = false;
            panelNhanSu.Visible = false;
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isexit)
            {
                if (MessageBox.Show("Bạn muốn thoát chương trình?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    e.Cancel = true;
            }
        }
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isexit)
                Application.Exit();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            phanQuyen();
            textBoxMaNhanViẻn.Text = "";
            textBoxHovaTen.Text = "";
            comboBoxPhongBan.Text = "";

            showAllNhanVien();
        }
        #region hide and show menu
        private void hideMenu()
        {
            if (panelSYSTEM.Visible == true)
            {
                panelSYSTEM.Visible = false;
            }
            if (panelNhanSu.Visible == true)
            {
                panelNhanSu.Visible = false;
            }
        }
        private void showMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        #endregion

        #region menu
        private void buttonHeThong_Click(object sender, EventArgs e)
        {
            showMenu(panelSYSTEM);
        }
        private void buttonQLTK_Click(object sender, EventArgs e)
        {
            GUIUser formUser = new GUIUser();
            formUser.Show();
            hideMenu();
        }
        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
            logout(this, new EventArgs());
            hideMenu();
        }
        private void buttonNhanSu_Click(object sender, EventArgs e)
        {
            showMenu(panelNhanSu);
        }
        private void buttonPhongban_Click(object sender, EventArgs e)
        {
            GUIPhongBan formDepartment = new GUIPhongBan();
            formDepartment.Show();
            hideMenu();
        }
        private void buttonNhanVien_Click(object sender, EventArgs e)
        {
            GUINhanVien formNhanVien = new GUINhanVien();
            formNhanVien.Show();
            hideMenu();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GUIThongKe formThongKe = new GUIThongKe();
            formThongKe.Show();
            hideMenu();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tMọi chi tiết cần hỗ trợ vui lòng liên hệ số điện thoại: \n\t\t\t0123456789", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
        #endregion

        #region chuyen form

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChild.Controls.Add(childForm);
            panelChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #endregion
        private void vbButton1_Click(object sender, EventArgs e)
        {
            string mnv = "";
            string hvt = "";
            string pb = "";
            mnv = textBoxMaNhanViẻn.Text;
            hvt = textBoxHovaTen.Text;
            pb = comboBoxPhongBan.Text;
            if (!string.IsNullOrEmpty(mnv) || !string.IsNullOrEmpty(hvt) || !string.IsNullOrEmpty(pb))
            {
                NhanVienDTO tblNhanVien = new NhanVienDTO();
                tblNhanVien.MaNhanVien = mnv;
                tblNhanVien.HoVaTen = hvt;
                tblNhanVien.PhongBan = pb;
                dt = nhanVienBLL.findNhanVien(mnv, hvt, pb);

                if (dt.Rows.Count > 0)
                {
                    dataGridView2.DataSource = dt;
                }
            }
            else
            {
                showAllNhanVien();
                MessageBox.Show("Không có thông tin phù hợp với yêu cầu của bạn!!!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public void showAllNhanVien()
        {
            dt = nhanVienBLL.getAllNhanVien();
            dataGridView2.DataSource = dt;
        }

        public void phanQuyen()
        {
            if (Const.AccoountTypes.Equals("Admin"))
            {
                buttonQLTK.Enabled = buttonPhongban.Enabled = true;
            }
            else
            {
                buttonQLTK.Enabled = false;
                buttonPhongban.Enabled = false;
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (isexit)
            {
                if (MessageBox.Show("Bạn muốn thoát chương trình?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Application.Exit();
            }
            
        }
        private void button3_Click(object sender, EventArgs e)
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

        private const int WM_MCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);

        private void mix(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_MCLBUTTONDOWN, HTCAPTION, 0);
        }

        private void mix(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_MCLBUTTONDOWN, HTCAPTION, 0);
        }
    }
}