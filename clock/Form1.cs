using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NAudio.Wave;
using System.IO;
using System.Linq;

namespace clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboboxInitialzation();
            timerClcok.Start();
        }

        List<string> hours = new List<string>();
        List<string> minutes = new List<string>();

        private void comboboxInitialzation()
        {
            for (int i = 0; i <= 23; i++)
            {
                cmbHour.Items.Add(string.Format("{0:00}", i));
                cmbHour1.Items.Add(string.Format("{0:00}", i));
                cmbHour2.Items.Add(string.Format("{0:00}", i));
                cmbHour3.Items.Add(string.Format("{0:00}", i));
                cmbHour4.Items.Add(string.Format("{0:00}", i));
            }
            cmbHour.SelectedIndex = 0;
            cmbHour1.SelectedIndex = 0;
            cmbHour2.SelectedIndex = 0;
            cmbHour3.SelectedIndex = 0;
            cmbHour4.SelectedIndex = 0;

            for (int i = 0; i <= 59; i++)
            {
                cmbMin.Items.Add(string.Format("{0:00}", i));
                cmbMin1.Items.Add(string.Format("{0:00}", i));
                cmbMin2.Items.Add(string.Format("{0:00}", i));
                cmbMin3.Items.Add(string.Format("{0:00}", i));
                cmbMin4.Items.Add(string.Format("{0:00}", i));
            }
            cmbMin.SelectedIndex = 0;
            cmbMin1.SelectedIndex = 0;
            cmbMin2.SelectedIndex = 0;
            cmbMin3.SelectedIndex = 0;
            cmbMin4.SelectedIndex = 0;
        }

        private void timerClcok_Tick(object sender, EventArgs e)
        {
            txtClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private List<string> strSelectTimes = new List<string>();  // 鬧鐘時間設定
        private List<bool> alarmsRung = new List<bool> { false, false, false, false, false }; // 記錄鬧鐘是否響過
        private WaveOutEvent waveOut;
        private AudioFileReader audioFileReader;
        private bool isAlarmPlaying = false;  // 判斷是否有鬧鐘在響

        private void timerAlert_Tick(object sender, EventArgs e)
        {
            string currentTime = DateTime.Now.ToString("HH:mm");

            for (int i = 0; i < strSelectTimes.Count; i++)
            {
                if (strSelectTimes[i] == currentTime && !alarmsRung[i] && !isAlarmPlaying)
                {
                    try
                    {
                        stopWaveOut(); // 确保之前的声音停止

                        string audioFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "alert.wav");
                        audioFileReader = new AudioFileReader(audioFilePath);
                        waveOut = new WaveOutEvent();
                        waveOut.Init(audioFileReader);
                        waveOut.Play();

                        alarmsRung[i] = true; // 設置該鬧鐘為已響過
                        isAlarmPlaying = true; // 設置鬧鐘正在響起
                        btnOff.Enabled = true; // 确保关闭按钮可用
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("無法播放聲音檔，錯誤資訊: " + ex.Message);
                    }
                }
            }

            // 檢查是否所有鬧鐘都已經響過
            if (alarmsRung.All(alarm => alarm))
            {
                btnOn.Enabled = true; // 启用启动按钮
                timerAlert.Stop(); // 停止鬧鐘計時器
            }
        }

        private void stopWaveOut()
        {
            if (waveOut != null)
            {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
            }
            if (audioFileReader != null)
            {
                audioFileReader.Dispose();
                audioFileReader = null;
            }
            isAlarmPlaying = false; // 重置鬧鐘正在響起標志
            btnOff.Enabled = false; // 禁用关闭按钮直到下一个闹钟響起

            // 檢查是否所有鬧鐘都已經響過
            if (alarmsRung.All(alarm => alarm))
            {
                btnOn.Enabled = true; // 启用启动按钮
            }
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            timerAlert.Start();
            btnOn.Enabled = false; // 禁用启动按钮，直到所有闹钟響过
            btnOff.Enabled = false; // 禁用关闭按钮，直到闹钟響起

            strSelectTimes.Clear();
            alarmsRung = new List<bool> { false, false, false, false, false };

            strSelectTimes.Add(cmbHour.SelectedItem.ToString() + ":" + cmbMin.SelectedItem.ToString());
            strSelectTimes.Add(cmbHour1.SelectedItem.ToString() + ":" + cmbMin1.SelectedItem.ToString());
            strSelectTimes.Add(cmbHour2.SelectedItem.ToString() + ":" + cmbMin2.SelectedItem.ToString());
            strSelectTimes.Add(cmbHour3.SelectedItem.ToString() + ":" + cmbMin3.SelectedItem.ToString());
            strSelectTimes.Add(cmbHour4.SelectedItem.ToString() + ":" + cmbMin4.SelectedItem.ToString());
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            stopWaveOut();
            // 檢查是否所有鬧鐘都已經響過
            if (alarmsRung.All(alarm => alarm))
            {
                btnOn.Enabled = true; // 启用启动按钮
            }
        }

       

        private void btnClear_Click_1(object sender, EventArgs e)
        {
           
                stopWaveOut();
                timerAlert.Stop();

                strSelectTimes.Clear();
                alarmsRung = new List<bool> { false, false, false, false, false };
                isAlarmPlaying = false;

                btnOn.Enabled = true;
                btnOff.Enabled = false;

                cmbHour.SelectedIndex = 0;
                cmbHour1.SelectedIndex = 0;
                cmbHour2.SelectedIndex = 0;
                cmbHour3.SelectedIndex = 0;
                cmbHour4.SelectedIndex = 0;
                cmbMin.SelectedIndex = 0;
                cmbMin1.SelectedIndex = 0;
                cmbMin2.SelectedIndex = 0;
                cmbMin3.SelectedIndex = 0;
                cmbMin4.SelectedIndex = 0;
           

        }
    }
}








