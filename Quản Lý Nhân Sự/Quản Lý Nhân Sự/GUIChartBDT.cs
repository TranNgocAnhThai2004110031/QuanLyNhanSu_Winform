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
    public partial class GUIChartBDT : Form
    {
        private PhongBanBLL phongBanBLL;
        public GUIChartBDT()
        {
            InitializeComponent();
            phongBanBLL = new PhongBanBLL();
            Form_Load();
        }
        private void Form_Load()
        {
            chart2.DataSource = phongBanBLL.chart();
            chart2.Series["SoLuong"].XValueMember = "TenPhong";
            chart2.Series["SoLuong"].YValueMembers = "SoLuongNhanVien";
        }
    }
}
