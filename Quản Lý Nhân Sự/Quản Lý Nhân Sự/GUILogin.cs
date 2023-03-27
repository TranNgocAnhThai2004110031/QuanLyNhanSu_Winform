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
    public partial class GUILogin : Form
    {
        private UserBLL userBLL;
        public GUILogin()
        {
            InitializeComponent();
            userBLL = new UserBLL();
            textBoxUsername.Focus();
        }

        private const int WM_MCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);
        private void buttonshow_Click(object sender, EventArgs e)
        {
            if (textBoxPass.PasswordChar == '*')
            {
                buttonhide.BringToFront();
                textBoxPass.PasswordChar = '\0';
            }
        }
        private void buttonhide_Click(object sender, EventArgs e)
        {
            if (textBoxPass.PasswordChar == '\0')
            {
                buttonshow.BringToFront();
                textBoxPass.PasswordChar = '*';
            }
        }
        private void vbButtonLogin_Click(object sender, EventArgs e)
        {
            if (checkLogin(textBoxUsername.Text, textBoxPass.Text))
            {
                GUIMain frmMain = new GUIMain();
                frmMain.Show();
                this.Hide();
                frmMain.logout += FrmMain_logout;
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai tên tài khoản hoặc mật khẩu!!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUsername.Focus();
                return;
            }
        }

        private void FrmMain_logout(object sender, EventArgs e)
        {
            (sender as GUIMain).isexit = false;
            (sender as GUIMain).Close();
            this.Show();
        }


        private bool checkLogin(string name, string pass)
        {
            UsersDTO tblUser = new UsersDTO();
            for (int i = 0; i < userBLL.getAllUser().Rows.Count; i++)
            {
                DataRow dataRow = userBLL.getAllUser().Rows[i];
                string username = dataRow["Username"].ToString();
                string password = dataRow["Password"].ToString();
                string accoountTypes = dataRow["AccessRights"].ToString();
                if (username.Equals(name) &&
                    password.Equals(pass))
                {
                    Const.AccoountTypes = accoountTypes;
                    return true;
                }
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = btn.BackColor == Color.Aqua ? Color.White : Color.Aqua;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = btn.BackColor == Color.Aqua ? Color.Red : Color.Aqua;
            this.WindowState = FormWindowState.Minimized;
        }

        private void mix(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_MCLBUTTONDOWN, HTCAPTION, 0);
        }
    }
}
