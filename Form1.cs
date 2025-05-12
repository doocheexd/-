using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace 抽卡模擬器
{
    public partial class Form1 : Form
    {
        Random random = new Random();
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
            Standard,
            Guarantee,
            Pity
        }

        private GachaMode currentMode = GachaMode.Standard;

        public Form1()
        {
            InitializeComponent();
            label2.Text = "目前模式：標準版抽卡";
        }

        // 按鈕事件：依照目前模式執行對應抽卡邏輯
        private void button1_Click(object sender, EventArgs e)
        {
            switch (currentMode)
            {
                case GachaMode.Standard:
                    DrawStandard();
                    break;
                case GachaMode.Guarantee:
                    DrawGuarantee();
                    break;
                case GachaMode.Pity:
                    DrawPity();
                    break;
            }
        }

        // ===== 三種模式的抽卡邏輯 =====

        private void DrawStandard()
        {
            int roll = random.Next(100);
            string result;

            if (roll < 80)
                result = characters[random.Next(0, 3)];
            else if (roll < 95)
                result = characters[random.Next(3, 5)];
            else
                result = characters[5];

            label1.Text = $"你抽到了：{result}";
        }

        private void DrawGuarantee()
        {
            label1.Text = "（保底模式尚未實作）";
        }

        private void DrawPity()
        {
            label1.Text = "（最終版模式尚未實作）";
        }

        // ===== 選單事件：切換抽卡模式 =====

        private void 標準版ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentMode = GachaMode.Standard;
            label2.Text = "目前模式：標準版抽卡";
        }

        private void 加強版ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentMode = GachaMode.Guarantee;
            label2.Text = "目前模式：加強版（保底）抽卡";
        }

        private void 最終版ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentMode = GachaMode.Pity;
            label2.Text = "目前模式：最終版（機率提升）抽卡";
        }
    }
}
