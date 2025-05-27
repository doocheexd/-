using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽卡模擬器
{
    // 最終版抽卡類別
    public class PityGacha : GachaBase
    {
        private double currentRate = 5.0; // 初始超稀有機率為 5%

        public override string Draw(out string infoText)
        {
            int roll = random.Next(100); // 產生 0~99 的亂數
            string result;

            if (roll < currentRate)
            {
                result = "（超稀有）"; // 命中機率範圍 → 中超稀有
                currentRate = 5.0;       // 命中後重置機率為初始值
            }
            else if (roll < 80)
            {
                result = "（普通）";     // 80% 以下 → 普通
                currentRate += 5.0;      // 未命中則提升超稀有機率
            }
            else
            {
                result = "（稀有）";     // 80% 以上但沒中超稀有 → 稀有
                currentRate += 5.0;      // 同樣提升超稀有機率
            }

            if (currentRate > 100.0)
                currentRate = 100.0;     // 超稀有機率上限為 100%

            infoText = $"目前超稀有機率：{currentRate}%"; // 回傳說明文字
            return result;
        }
    }
}
