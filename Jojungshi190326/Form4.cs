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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void toback_btn_Click(object sender, EventArgs e)
        {
            
            ActiveForm.Close();
            
           




        }
         
        private void end_btn_Click(object sender, FormClosingEventArgs e)
        {
            Form3 showForm3 = new Form3();
            showForm3.Visible = true;
        }
        private void end_btn_Click(object sender, EventArgs e)
        {
            Application.ExitThread();


        }
    }
}
