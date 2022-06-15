using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3
{
    public partial class FormGuiNhanLieuKe : Form
    {
        public FormGuiNhanLieuKe()
        {
            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rpcDataSet.guinhanlieuke' table. You can move, or remove it, as needed.
            //this.guinhanlieukeTableAdapter.Fill(this.rpcDataSet.guinhanlieuke);

            //this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime ngayNhan = dateTimeNgayNhan.Value;
            //Khai báo câu lệnh SQL
            String tblName = "rpc.guinhanlieuke";
            String fieldName = "NGAYNHANLK";
            var sqlQuerryStr = String.Format("Select * from {0} Where STR_TO_DATE({1}, '%d/%m/%Y') BETWEEN '{2:yyyy-MM-dd}' AND '{2:yyyy-MM-dd}'", tblName, fieldName,ngayNhan);
            //String sqlQuerryStr = "Select * from rpc.guinhanlieuke Where STR_TO_DATE(NGAYNHANLK, '%d/%m/%Y') BETWEEN '"+"2021-10-2"+"' AND '2021-10-28'";
            string connectionString = "SERVER=" + "localhost" + "; PORT = 3306;" + "DATABASE=rpc" + ";" + "UID=root" + ";" + "PASSWORD=hsv1" + "; charset=utf8";
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            //Truyền vào chuỗi kết nối tới cơ sở dữ liệu
            //Gọi Application.StartupPath để lấy đường dẫn tới thư mục chứa file chạy chương trình 

            MySqlDataAdapter adp = new MySqlDataAdapter(sqlQuerryStr, mySqlConnection);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            //Khai báo chế độ xử lý báo cáo, trong trường hợp này lấy báo cáo ở local
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            //Đường dẫn báo cáo
            reportViewer1.LocalReport.ReportPath = "ReportGuiNhanLieuKe.rdlc";
            //Nếu có dữ liệu
            if (ds.Tables[0].Rows.Count > 0)
            {
                //Tạo nguồn dữ liệu cho báo cáo
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "viewGuiNhanLieuKe";
                rds.Value = ds.Tables[0];
                //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
                reportViewer1.LocalReport.DataSources.Clear();
                //Add dữ liệu vào báo cáo
                reportViewer1.LocalReport.DataSources.Add(rds);
                //Refresh lại báo cáo
                reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("Không có đơn nào vào ngày " + ngayNhan.ToShortDateString(), "Thông Báo!");
            }

        }
    }
}
