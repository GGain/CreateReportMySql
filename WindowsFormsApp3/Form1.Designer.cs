
namespace WindowsFormsApp3
{
    partial class Form1
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.guinhanlieukeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpcDataSet = new WindowsFormsApp3.rpcDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.guinhanlieukeTableAdapter = new WindowsFormsApp3.rpcDataSetTableAdapters.guinhanlieukeTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.guinhanlieukeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpcDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // guinhanlieukeBindingSource
            // 
            this.guinhanlieukeBindingSource.DataMember = "guinhanlieuke";
            this.guinhanlieukeBindingSource.DataSource = this.rpcDataSet;
            // 
            // rpcDataSet
            // 
            this.rpcDataSet.DataSetName = "rpcDataSet";
            this.rpcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // guinhanlieukeTableAdapter
            // 
            this.guinhanlieukeTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "viewGuiNhanLieuKe";
            reportDataSource2.Value = this.guinhanlieukeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp3.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 40);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1114, 556);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày Nhận";
            // 
            // dateTimeNgayNhan
            // 
            this.dateTimeNgayNhan.CustomFormat = "";
            this.dateTimeNgayNhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNgayNhan.Location = new System.Drawing.Point(122, 12);
            this.dateTimeNgayNhan.Name = "dateTimeNgayNhan";
            this.dateTimeNgayNhan.Size = new System.Drawing.Size(132, 20);
            this.dateTimeNgayNhan.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 40);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 596);
            this.Controls.Add(this.dateTimeNgayNhan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guinhanlieukeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpcDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource guinhanlieukeBindingSource;
        private rpcDataSet rpcDataSet;
        private rpcDataSetTableAdapters.guinhanlieukeTableAdapter guinhanlieukeTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker dateTimeNgayNhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

