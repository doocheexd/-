using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽卡模擬器
{
    // 標準版抽卡類別
    public class StandardGacha : GachaBase
    {
        public override string Draw(out string infoText)
        {
            int roll = random.Next(100); // 產生 0~99 的亂數
            string result;

            // 80% 抽到普通角色
            if (roll < 80)
                result = characters[random.Next(0, 3)];
            // 15% 抽到稀有角色
            else if (roll < 95)
                result = characters[random.Next(3, 5)];
            // 5% 抽到超稀有角色
            else
                result = characters[5];

            infoText = ""; // 標準模式沒有額外說明文字
            return result;
        }
    }
}
