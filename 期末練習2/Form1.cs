using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期末練習2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(txt_height.Text) == 0)
                {
                    MessageBox.Show("身高不能為0");
                }
                else
                {
                    double height = double.Parse(txt_height.Text) / 100;
                    double weight = double.Parse(txt_weight.Text);
                    double bmi = weight / (height * height);
                    txt_result.Text = bmi.ToString("F2");
                }
            }catch (Exception ex) { MessageBox.Show("請輸入有效數字"); }
        }   
    }
}
