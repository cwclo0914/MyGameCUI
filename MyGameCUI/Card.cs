using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameCUI
{
    abstract class Card
    {
        // フィールド
        
        
        // コンストラクタ
        public Card(string name, int cost, int faction)
        {
            Name = name;
            Cost = cost;
            Faction = faction;
        }

        // プロパティ
        public string Name { get; set; }
        public int Cost { get; set; }
        public int Faction { get; set; }
        public List<Effect> CardEffect { get; set; }
        public abstract int HP { get; set; }
        public abstract int Strength { get; set; }
        // public string FrameImage { get; set; }
        // public string CardImage { get; set; }

        // メソッド
        public abstract void AddEffect();
        // public void LoadImage() { }


    }
}
