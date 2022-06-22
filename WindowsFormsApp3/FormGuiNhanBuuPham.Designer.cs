
namespace WindowsFormsApp3
{
    partial class FormGuiNhanBuuPham
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.nhapguibuuphamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpcDataSet = new WindowsFormsApp3.rpcDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimeNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.nhapguibuuphamTableAdapter = new WindowsFormsApp3.rpcDataSetTableAdapters.nhapguibuuphamTableAdapter();
            this.guinhanlieukeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guinhanlieukeTableAdapter = new WindowsFormsApp3.rpcDataSetTableAdapters.guinhanlieukeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nhapguibuuphamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpcDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guinhanlieukeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nhapguibuuphamBindingSource
            // 
            this.nhapguibuuphamBindingSource.DataMember = "nhapguibuupham";
            this.nhapguibuuphamBindingSource.DataSource = this.rpcDataSet;
            // 
            // rpcDataSet
            // 
            this.rpcDataSet.DataSetName = "rpcDataSet";
            this.rpcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimeNgayNhan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1241, 59);
            this.panel1.TabIndex = 0;
            // 
            // dateTimeNgayNhan
            // 
            this.dateTimeNgayNhan.CustomFormat = "";
            this.dateTimeNgayNhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNgayNhan.Location = new System.Drawing.Point(114, 13);
            this.dateTimeNgayNhan.Name = "dateTimeNgayNhan";
            this.dateTimeNgayNhan.Size = new System.Drawing.Size(132, 20);
            this.dateTimeNgayNhan.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ngày Gửi";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(252, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "In";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1241, 391);
            this.panel2.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 81;
            reportDataSource1.Name = "guiBuuPham";
            reportDataSource1.Value = this.nhapguibuuphamBindingSource;
            reportDataSource2.Name = "viewGuiNhanLieuKe";
            reportDataSource2.Value = this.guinhanlieukeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp3.ReportGuiNhanBPham.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1241, 391);
            this.reportViewer1.TabIndex = 0;
            // 
            // nhapguibuuphamTableAdapter
            // 
            this.nhapguibuuphamTableAdapter.ClearBeforeFill = true;
            // 
            // guinhanlieukeBindingSource
            // 
            this.guinhanlieukeBindingSource.DataMember = "guinhanlieuke";
            this.guinhanlieukeBindingSource.DataSource = this.rpcDataSet;
            // 
            // guinhanlieukeTableAdapter
            // 
            this.guinhanlieukeTableAdapter.ClearBeforeFill = true;
            // 
            // FormGuiNhanBuuPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormGuiNhanBuuPham";
            this.Text = "FormGuiNhanBuuPham";
            this.Load += new System.EventHandler(this.FormGuiNhanBuuPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhapguibuuphamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpcDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guinhanlieukeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private rpcDataSet rpcDataSet;
        private System.Windows.Forms.BindingSource nhapguibuuphamBindingSource;
        private rpcDataSetTableAdapters.nhapguibuuphamTableAdapter nhapguibuuphamTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimeNgayNhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource guinhanlieukeBindingSource;
        private rpcDataSetTableAdapters.guinhanlieukeTableAdapter guinhanlieukeTableAdapter;
    }
}