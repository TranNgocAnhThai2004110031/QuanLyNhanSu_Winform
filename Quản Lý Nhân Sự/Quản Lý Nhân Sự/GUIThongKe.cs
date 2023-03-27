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
    public partial class GUIThongKe : Form
    {
        private Form currichiren;
        public GUIThongKe()
        {
            InitializeComponent();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            GUIChartBDC chart = new GUIChartBDC();
            chart.Show();
        }
        private void OpenChildForm(Form chilForm)
        {
            if (currichiren != null)
            {
                currichiren.Close();
            }
            currichiren = chilForm;
            chilForm.TopLevel = false;
            chilForm.FormBorderStyle = FormBorderStyle.None;
            chilForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(chilForm);
            panel1.Tag = chilForm;
            chilForm.BringToFront();
            chilForm.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUIChartBDC());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUIChartBDT());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUIReport());
        }
    }
}
