using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace 抽卡模擬器
{
    public partial class Form1 : Form
    {
        private GachaBase currentGacha;

        private System.Windows.Forms.Timer animationTimer = new System.Windows.Forms.Timer(); // 動畫輪播計時器
        private System.Windows.Forms.Timer cooldownTimer = new System.Windows.Forms.Timer();  // 冷卻時間計時器

        private string finalResult = "";   // 最終抽卡結果
        private int animationStep = 0;     // 動畫階段用來控制輪播次數
        private bool isCooldown = false;   // 是否處於冷卻狀態

        private List<string> drawHistory = new List<string>(); // 儲存抽卡紀錄

        public Form1()
        {
            InitializeComponent();

            label2.Text = "目前模式：標準版"; // 預設模式顯示為標準版
            label3.Visible = false;        // 說明文字預設隱藏

            currentGacha = new StandardGacha(); // 預設使用標準抽卡邏輯

            animationTimer.Interval = 100;      // 動畫每 0.1 秒更新一次
            animationTimer.Tick += AnimationTimer_Tick;

            cooldownTimer.Interval = 1000;      // 冷卻時間為 1 秒
            cooldownTimer.Tick += CooldownTimer_Tick;
        }

        // 點擊「抽卡」按鈕事件
        private void button1_Click(object sender, EventArgs e)
        {
            if (isCooldown || currentGacha == null) return; // 冷卻中或尚未選模式則不執行

            finalResult = currentGacha.Draw(out string infoText); // 執行抽卡邏輯，取得結果與說明文字
            label3.Text = infoText;
            label3.Visible = !string.IsNullOrEmpty(infoText); // 有內容才顯示文字

            animationStep = 0;         // 重設動畫階段
            animationTimer.Start();    // 開始播放動畫

            isCooldown = true;         // 進入冷卻狀態
            cooldownTimer.Start();     // 開始冷卻計時
            button1.Enabled = false;   // 冷卻期間停用按鈕
        }

        // 抽卡動畫更新事件
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            animationStep++;

            // 輪播顯示抽卡結果（每次變換一種）
            switch (animationStep % 3)
            {
                case 0: label1.Text = "你抽到了：（普通）"; break;
                case 1: label1.Text = "你抽到了：（稀有）"; break;
                case 2: label1.Text = "你抽到了：（超稀有）"; break;
            }

            if (animationStep >= 10)
            {
                animationTimer.Stop(); // 播放完 10 次後停止動畫

                label1.Text = $"你抽到了：{finalResult}"; // 顯示實際抽中的結果

                // 加入紀錄（包含時間與模式）
                string logEntry = $"{DateTime.Now:HH:mm:ss} - {label2.Text}：{finalResult}";
                drawHistory.Add(logEntry);
                listBox1.Items.Add(logEntry); // 顯示在畫面上的紀錄清單
            }
        }

        // 冷卻結束後的事件
        private void CooldownTimer_Tick(object sender, EventArgs e)
        {
            cooldownTimer.Stop();
            isCooldown = false;      // 解除冷卻狀態
            button1.Enabled = true;  // 恢復按鈕可用
        }

        // 切換到標準版模式
        private void 標準版ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentGacha = new StandardGacha();
            label2.Text = "目前模式：標準版";
            label3.Visible = false; // 不顯示額外資訊
            label1.Text = "";
        }

        // 切換到加強版模式
        private void 加強版ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentGacha = new GuaranteeGacha();
            label2.Text = "目前模式：加強版";
            label3.Visible = true;
            label3.Text = "離保底還剩：10 抽"; // 初始顯示保底剩餘次數
            label1.Text = "";
        }

        // 切換到最終版模式
        private void 最終版ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentGacha = new PityGacha();
            label2.Text = "目前模式：最終版";
            label3.Visible = true;
            label3.Text = "目前超稀有機率：5%"; // 初始機率顯示
            label1.Text = "";
        }

        // 清除抽卡紀錄按鈕
        private void buttonResetLog_Click_1(object sender, EventArgs e)
        {
            drawHistory.Clear();         // 清除內部資料
            listBox1.Items.Clear();      // 清除畫面上的項目
        }
    }
}
