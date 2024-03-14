using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GTA;
using GTA.UI;

namespace GTA_Watermark
{
    public class Class1 : Script
    {
        private TextElement m = null; //main
        private TextElement s = null; //sub

        public Class1()
        {
            Tick += onTick;

            ScriptSettings ini = ScriptSettings.Load(@"scripts\GTA_Watermark.ini");
            string main = "";
            string sub = "";
            float mainS = 0;
            float subS = 0;
            /// iniのデータを読み込む (セクション、キー、デフォルト値)
            main = ini.GetValue<string>("Caption", "Main", "Activate Grand Theft Auto V");
            sub = ini.GetValue<string>("Caption", "Sub", "Go to Settings to activate Grand Theft Auto V.");
            mainS = ini.GetValue<float>("Scale", "Main", 0.4f); //末尾にFをつけてFloatをキャスト(明示的変換）。
            subS = ini.GetValue<float>("Scale", "Sub", 0.3f); //末尾にFをつけてFloatをキャスト(明示的変換）。

            PointF pm = new PointF(960, 620); // PointFはX,Yの座標。
            PointF ps = new PointF(960, 640); // PointFはX,Yの座標。
            m = new TextElement(main, pm, mainS); 
            s = new TextElement(sub, ps, subS);
            m.Alignment = Alignment.Left; //左揃え
            s.Alignment = Alignment.Left; //左揃え
            m.Color = Color.FromArgb(128,255,255,255);
            s.Color = Color.FromArgb(128,255,255,255);
        }

        private void onTick(object sender, EventArgs e)
        {
            m.ScaledDraw();
            s.ScaledDraw();
        }
    }
}
