using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jojungshi190326
{
    public partial class Form2 : Form
    {
        public static string platform { get;set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            platform = platform_cmb.Text;

            //ActiveForm.Visible = false;               // 현재 폼을 닫고 Form3를 보여줌.
            Form3 showForm3 = new Form3();
            showForm3.Show();
        }
        private void Form2_closing(object sender, FormClosingEventArgs e)
        {
            

            Form1 fm1=new Form1();
            fm1.Visible=true;
            

        }
        private void Form1_closed(object sender, FormClosedEventArgs e)
        {

            Application.ExitThread();




        }
    }
}
