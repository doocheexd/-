using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽卡模擬器
{
    // 加強版抽卡類別
    public class GuaranteeGacha : GachaBase
    {
        private int pityCounter = 0; // 保底計數器

        public override string Draw(out string infoText)
        {
            pityCounter++; // 每抽一次就遞增計數器

            string result;
            if (pityCounter >= 10)
            {
                result = characters[5] + "（觸發保底）"; // 第 10 抽保底出超稀有
                pityCounter = 0; // 抽中後重置
            }
            else
            {
                int roll = random.Next(100);
                if (roll < 80)
                    result = characters[random.Next(0, 3)];     // 普通
                else if (roll < 95)
                    result = characters[random.Next(3, 5)];     // 稀有
                else
                {
                    result = characters[5];                    // 超稀有
                    pityCounter = 0;                            // 中超稀有也重置保底
                }
            }

            infoText = $"離保底還剩：{10 - pityCounter} 抽"; // 回傳保底剩餘抽數
            return result;
        }
    }
}
