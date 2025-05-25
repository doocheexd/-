using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace 抽卡模擬器
{
    public partial class Form1 : Form
    {
        Random random = new Random(); // 隨機數產生器

        // 抽卡角色列表（用於標準與加強模式）
        List<string> characters = new List<string>
        {
            "（普通）",
            "（普通）",
            "（普通）",
            "（稀有）",
            "（稀有）",
            "（超稀有）"
        };

        // 抽卡模式列舉
        private enum GachaMode
        {
            Standard,   // 標準版
            Guarantee,  // 加強版（保底機制）
            Pity        // 最終版（機率提升機制）
        }

        private GachaMode currentMode = GachaMode.Standard; // 當前模式預設為標準

        // 動畫與冷卻計時器
        private System.Windows.Forms.Timer animationTimer = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer cooldownTimer = new System.Windows.Forms.Timer();

        // 抽卡動畫用參數
        private string finalResult = "";
        private int animationStep = 0;
        private bool isCooldown = false;

        // 保底機制計數器（加強版使用）
        int pityCounter = 0;

        // 最終版機率（初始為5%，每次未中提升5%，上限100%）
        private double currentRate = 5.0;

        // 抽卡歷史紀錄清單
        List<string> drawHistory = new List<string>();

        public Form1()
        {
            InitializeComponent();
            label2.Text = "目前模式：標準版";
            label3.Visible = false;

            // 設定動畫計時器間隔與事件
            animationTimer.Interval = 100;
            animationTimer.Tick += AnimationTimer_Tick;

            // 冷卻時間設定為 1 秒
            cooldownTimer.Interval = 1000;
            cooldownTimer.Tick += CooldownTimer_Tick;
        }

        // ===== 按下抽卡按鈕後執行 =====
        private void button1_Click(object sender, EventArgs e)
        {
            if (isCooldown) return;

            string result = "";

            // 根據目前選擇的模式進行抽卡
            switch (currentMode)
            {
                case GachaMode.Standard:
                    result = GetStandardResult();
                    break;
                case GachaMode.Guarantee:
                    result = GetGuaranteeResult();
                    break;
                case GachaMode.Pity:
                    result = GetPityResult();
                    break;
            }

            // 啟動動畫並儲存最終結果
            finalResult = result;
            animationStep = 0;
            animationTimer.Start();

            // 啟動冷卻
            isCooldown = true;
            cooldownTimer.Start();
            button1.Enabled = false;
        }

        // ===== 標準版抽卡邏輯（80% 普通, 15% 稀有, 5% 超稀有）=====
        private string GetStandardResult()
        {
            int roll = random.Next(100);
            if (roll < 80)
                return characters[random.Next(0, 3)];
            else if (roll < 95)
                return characters[random.Next(3, 5)];
            else
                return characters[5];
        }

        // ===== 加強版（保底機制，每10抽保證一個超稀有）=====
        private string GetGuaranteeResult()
        {
            pityCounter++;

            if (pityCounter >= 10)
            {
                pityCounter = 0;
                label3.Text = $"離保底還剩：10 抽";
                return characters[5] + "（觸發保底）";
            }

            int roll = random.Next(100);
            string result;

            if (roll < 80)
                result = characters[random.Next(0, 3)];
            else if (roll < 95)
                result = characters[random.Next(3, 5)];
            else
            {
                pityCounter = 0;
                result = characters[5];
            }

            label3.Text = $"離保底還剩：{10 - pityCounter} 抽";
            return result;
        }

        // ===== 最終版（未抽中超稀有則超稀有機率+5%）=====
        private string GetPityResult()
        {
            int roll = random.Next(100);
            string result;

            if (roll < currentRate)
            {
                result = "（超稀有）";
                currentRate = 5.0; // 命中後重置為初始機率
            }
            else if (roll < 80)
            {
                result = "（普通）";
                currentRate += 5.0;
            }
            else
            {
                result = "（稀有）";
                currentRate += 5.0;
            }

            if (currentRate > 100.0)
                currentRate = 100.0;

            label3.Text = $"目前超稀有機率：{currentRate}%";
            return result;
        }

        // ===== 動畫階段（循環閃爍抽卡動畫，結束後顯示結果並紀錄）=====
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            animationStep++;

            switch (animationStep % 3)
            {
                case 0:
                    label1.Text = "你抽到了：（普通）";
                    break;
                case 1:
                    label1.Text = "你抽到了：（稀有）";
                    break;
                case 2:
                    label1.Text = "你抽到了：（超稀有）";
                    break;
            }

            // 動畫執行 10 次後停止，顯示最終結果並記錄
            if (animationStep >= 10)
            {
                animationTimer.Stop();
                label1.Text = $"你抽到了：{finalResult}";

                string logEntry = $"{DateTime.Now:HH:mm:ss} - {label2.Text}：{finalResult}";
                drawHistory.Add(logEntry);
                listBox1.Items.Add(logEntry);
            }
        }

        // ===== 抽卡冷卻結束，啟用按鈕 =====
        private void CooldownTimer_Tick(object sender, EventArgs e)
        {
            cooldownTimer.Stop();
            isCooldown = false;
            button1.Enabled = true;
        }

        // ===== 切換為標準模式 =====
        private void 標準版ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentMode = GachaMode.Standard;
            label2.Text = "目前模式：標準版";
            label3.Visible = false;
            label1.Text = "";
        }

        // ===== 切換為加強模式（保底）=====
        private void 加強版ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentMode = GachaMode.Guarantee;
            label2.Text = "目前模式：加強版";
            pityCounter = 0;
            label3.Visible = true;
            label3.Text = "離保底還剩：10 抽";
            label1.Text = "";
        }

        // ===== 切換為最終版（機率提升）=====
        private void 最終版ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentMode = GachaMode.Pity;
            label2.Text = "目前模式：最終版";
            currentRate = 5.0;
            label3.Visible = true;
            label3.Text = $"目前超稀有機率：{currentRate}%";
            label1.Text = "";
        }

        // ===== 重置抽卡紀錄按鈕事件 =====
        private void buttonResetLog_Click_1(object sender, EventArgs e)
        {
            drawHistory.Clear();
            listBox1.Items.Clear();
        }
    }
}
