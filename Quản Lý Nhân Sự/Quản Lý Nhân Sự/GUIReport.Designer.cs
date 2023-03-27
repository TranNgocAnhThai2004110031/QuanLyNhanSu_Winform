namespace Quản_Lý_Nhân_Sự
{
    partial class GUIReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.danhSachNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNhanSuDataSet1 = new Quản_Lý_Nhân_Sự.QLNhanSuDataSet1();
            this.danhSachNhanVienTableAdapter = new Quản_Lý_Nhân_Sự.QLNhanSuDataSet1TableAdapters.DanhSachNhanVienTableAdapter();
            this.gradientPanel1 = new GradientPanelDemo.GradientPanel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhanSuDataSet1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // danhSachNhanVienBindingSource
            // 
            this.danhSachNhanVienBindingSource.DataMember = "DanhSachNhanVien";
            this.danhSachNhanVienBindingSource.DataSource = this.qLNhanSuDataSet1;
            // 
            // qLNhanSuDataSet1
            // 
            this.qLNhanSuDataSet1.DataSetName = "QLNhanSuDataSet1";
            this.qLNhanSuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // danhSachNhanVienTableAdapter
            // 
            this.danhSachNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gradientPanel1.ColorCenter = System.Drawing.Color.Empty;
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gradientPanel1.Controls.Add(this.reportViewer1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(878, 474);
            this.gradientPanel1.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackgroundImage = global::Quản_Lý_Nhân_Sự.Properties.Resources.background_11;
            this.reportViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.danhSachNhanVienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Quản_Lý_Nhân_Sự.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(878, 474);
            this.reportViewer1.TabIndex = 1;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 474);
            this.Controls.Add(this.gradientPanel1);
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.danhSachNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhanSuDataSet1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private QLNhanSuDataSet1 qLNhanSuDataSet1;
        private System.Windows.Forms.BindingSource danhSachNhanVienBindingSource;
        private QLNhanSuDataSet1TableAdapters.DanhSachNhanVienTableAdapter danhSachNhanVienTableAdapter;
        private GradientPanelDemo.GradientPanel gradientPanel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}