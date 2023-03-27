using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Nhân_Sự
{
    public partial class GUIChartBDC : Form
    {
        private NhanVienBLL nhanVienBLL;
        public GUIChartBDC()
        {
            InitializeComponent();
            nhanVienBLL = new NhanVienBLL();
            Form_Load();
        }
        private void Form_Load()
        {
            chart1.DataSource = nhanVienBLL.chart();
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Họ tên nhân viên";
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Biểu đồ biểu thị lương của từng nhân viên trong tháng";

            chart1.Series["Lương"].XValueMember = "HoVaTen";
            chart1.Series["Lương"].YValueMembers = "LuongThang";
        }
    }
}
