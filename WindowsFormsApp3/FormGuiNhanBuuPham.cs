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
    public partial class FormGuiNhanBuuPham : Form
    {
        public FormGuiNhanBuuPham()
        {
            InitializeComponent();
        }

        private void FormGuiNhanBuuPham_Load(object sender, EventArgs e)
        {
            //this.nhapguibuuphamTableAdapter.Fill(this.DataSetGuiNhanBuuPham.nhapguibuupham);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime ngayGui = dateTimeNgayNhan.Value;
            //Khai báo câu lệnh SQL
            String tblName = "rpc.nhapguibuupham";
            String fieldName = "NGAYGUI";
            var sqlQuerryStr = String.Format("Select * from {0} Where STR_TO_DATE({1}, '%d/%m/%Y') BETWEEN '{2:yyyy-MM-dd}' AND '{2:yyyy-MM-dd}'", tblName, fieldName, ngayGui);
            string connectionString = "SERVER=" + "localhost" + "; PORT = 3306;" + "DATABASE=rpc" + ";" + "UID=root" + ";" + "PASSWORD=hsv1" + "; charset=utf8";
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            //Truyền vào chuỗi kết nối tới cơ sở dữ liệu
            //Gọi Application.StartupPath để lấy đường dẫn tới thư mục chứa file chạy chương trình 

            MySqlDataAdapter adp = new MySqlDataAdapter(sqlQuerryStr, mySqlConnection);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            //Khai báo chế độ xử lý báo cáo, trong trường hợp này lấy báo cáo ở local
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            //Đường dẫn báo cáo
            this.reportViewer1.LocalReport.ReportPath = "ReportGuiNhanBPham.rdlc";
            //Nếu có dữ liệu
            if (ds.Tables[0].Rows.Count > 0)
            {
                //Tạo nguồn dữ liệu cho báo cáo
                ReportDataSource rds = new ReportDataSource("nhapguibuupham", ds.Tables[0]);
                //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác 
                this.reportViewer1.LocalReport.DataSources.Clear();
                //Add dữ liệu vào báo cáo
                this.reportViewer1.LocalReport.DataSources.Add(rds);
                //nhapguibuuphamBindingSource.DataSource = rds;
                //Refresh lại báo cáo
                this.reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("Không có đơn nào vào ngày " + ngayGui.ToShortDateString(), "Thông Báo!");
            }
        }
    }
}
