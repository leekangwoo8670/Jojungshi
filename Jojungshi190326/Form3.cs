using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jojungshi190326
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void toback_btn1_Click(object sender, EventArgs e)
        {
            //this.Visible = false; 
            
           
            ActiveForm.Close();

        }

        private void IMMSHI_Click(object sender, EventArgs e)
        {
            ActiveForm.Visible = false;
            // 현재 폼을 닫고 Form4를 보여줌.
            Form4 showForm4 = new Form4();
            showForm4.Show();
            
        }
        private void Form1_closed(object sender, FormClosedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Fill 전달 전에 DataSet객체 생성
            DataSet ds = new DataSet();

            // DataAdapter는 자동으로 Connection을
            // 핸들링한다. conn.Open() 불필요.
            string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\test.accdb";
            OleDbConnection conn = new OleDbConnection(connStr);

            string sql = "SELECT * FROM sheet1";
            OleDbDataAdapter adp = new OleDbDataAdapter(sql, conn);
            adp.Fill(ds);

            // 가져온 데이타를 DataGridView 컨트롤에 
            // 바인딩한 예.
            dataGridView1.DataSource = ds.Tables[0];

            MessageBox.Show(Form2.platform);

        }
    }
}
