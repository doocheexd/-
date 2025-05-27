using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽卡模擬器
{
    // 所有抽卡邏輯的基礎類別
    public abstract class GachaBase
    {
        protected List<string> characters; // 儲存角色稀有度
        protected Random random;           // 產生隨機數

        public GachaBase()
        {
            random = new Random(); // 建立亂數

            // 初始化角色列表：3 普通、2 稀有、1 超稀有
            characters = new List<string>
            {
                "（普通）", "（普通）", "（普通）",
                "（稀有）", "（稀有）",
                "（超稀有）"
            };
        }

        // 定義抽卡方法，讓子類別實作具體邏輯
        public abstract string Draw(out string infoText);
    }
}
