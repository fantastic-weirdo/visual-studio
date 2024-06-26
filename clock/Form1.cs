using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clock
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
            comboboxInitialzation();  // 下拉選單初始化
        }
        List<string> hours = new List<string>();            // 小時清單
        List<string> minutes = new List<string>();          // 分鐘清單   

        // 下拉選單初始化
        private void comboboxInitialzation()
        {
            // 設定小時下拉選單的選單內容，建立小時的清單，數字範圍為00-23
            for (int i = 0; i <= 23; i++)
                cmbHour.Items.Add(string.Format("{0:00}", i));
            cmbHour.SelectedIndex = 0;
            for (int i = 0; i <= 23; i++)
                cmbHour1.Items.Add(string.Format("{0:00}", i));
            cmbHour1.SelectedIndex = 0;
            for (int i = 0; i <= 23; i++)
                cmbHour2.Items.Add(string.Format("{0:00}", i));
            cmbHour2.SelectedIndex = 0;
            for (int i = 0; i <= 23; i++)
                cmbHour3.Items.Add(string.Format("{0:00}", i));
            cmbHour3.SelectedIndex = 0;
            for (int i = 0; i <= 23; i++)
                cmbHour4.Items.Add(string.Format("{0:00}", i));
            cmbHour4.SelectedIndex = 0;
            // 設定分鐘下拉選單的選單內容，建立分鐘的清單，數字範圍為00-59
            for (int i = 0; i <= 59; i++)
                cmbMin.Items.Add(string.Format("{0:00}", i));
            cmbMin.SelectedIndex = 0;
            for (int i = 0; i <= 59; i++)
                cmbMin1.Items.Add(string.Format("{0:00}", i));
            cmbMin1.SelectedIndex = 0;
            for (int i = 0; i <= 59; i++)
                cmbMin2.Items.Add(string.Format("{0:00}", i));
            cmbMin2.SelectedIndex = 0;
            for (int i = 0; i <= 59; i++)
                cmbMin3.Items.Add(string.Format("{0:00}", i));
            cmbMin3.SelectedIndex = 0;
            for (int i = 0; i <= 59; i++)
                cmbMin4.Items.Add(string.Format("{0:00}", i));
            cmbMin4.SelectedIndex = 0;
        }
        private void timerClcok_Tick(object sender, EventArgs e)
        {

        }

        private void timerAlert_Tick(object sender, EventArgs e)
        {

        }
    }
}
