using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * 2019/03/26 - 이도형
 * 현재 다른 폼 창을 띄우는 작업은 가능하나, 기존 창이 닫히지 않고 새로운 폼이 열림
 * 폼 2의 조건 형식을 그대로 유지한 채로 폼 3을 열고 
 * 폼 3의 리스트를 그대로 유지한 채로 폼 4를 열고
 * 뒤로 버튼을 누르면 현재 폼만 종료하도록 하고 싶음
 * this.Visible = false; 로 하면 마지막 폼 4를 마치고 종료 버튼을 눌러도 프로세스가
 * 종료되지 않는 현상 발생
 * 
 */





namespace Jojungshi190326
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {

            ActiveForm.Visible = false;       // 현재 폼을 닫고 Form2를 보여줌.
            Form2 showForm2 = new Form2();
            showForm2.Show();

            

            
        }
        private void Form1_closed(object sender, FormClosedEventArgs e)
        {

            Application.ExitThread();
            



        }
    }
}
