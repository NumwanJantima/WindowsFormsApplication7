using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        //ปุ่มแปลงเลขฐาน//
        private void btnConvert_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(txtInput.Text);           //ประกาศตัวแปรรับค่าตัวเลขเข้ามา//
            txtBinary.Text = Convert.ToString(Num, 2);    //แปลงเลขที่รับเข้ามาเป็นเลขฐาน 2//
            txtOctal.Text = Convert.ToString(Num, 8);     //แปลงเลขที่รับเข้ามาเป็นเลขฐาน 8//
            txtDecimal.Text = Num.ToString();             //แปลงเลขที่รับเข้ามาเป็นเลขฐาน 10//
            txtHex.Text = Convert.ToString(Num, 16);      //แปลงเลขที่รับเข้ามาเป็นเลขฐาน 16//
        }
        //ปุ่มลบข้อมูลใน textbox ทั้งหมด//
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtBinary.Clear();
            txtOctal.Clear();
            txtDecimal.Clear();
            txtHex.Clear();
        }
        //ปุ่มออกจากโปรแกรม//
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
