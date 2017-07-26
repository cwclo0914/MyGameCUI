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
        /// <summary>
        /// エフェクトなしのカード
        /// </summary>
        /// <param name="name">名前</param>
        /// <param name="cost">コスト</param>
        /// <param name="faction">勢力</param>
        public Card(string name, int cost, int faction)
        {
            Name = name;
            Cost = cost;
            Faction = faction;
        }

        /// <summary>
        /// エフェクト1つのカード
        /// </summary>
        /// <param name="name">名前</param>
        /// <param name="cost">コスト</param>
        /// <param name="faction">勢力</param>
        /// <param name="eff1">1つめのエフェクト（インスタンス"new xxxEffect()"で入力してください）</param>
        public Card(string name, int cost, int faction, Effect eff1)
        {
            Name = name;
            Cost = cost;
            Faction = faction;
            CardEffect.Add(eff1);
        }

        /// <summary>
        /// エフェクト2つのカード
        /// </summary>
        /// <param name="name">名前</param>
        /// <param name="cost">コスト</param>
        /// <param name="faction">勢力</param>
        /// <param name="eff1">1つめのエフェクト（インスタンス"new xxxEffect()"で入力してください）</param>
        /// <param name="eff2">2つめのエフェクト（インスタンス"new xxxEffect()"で入力してください）</param>
        public Card(string name, int cost, int faction, Effect eff1, Effect eff2)
        {
            Name = name;
            Cost = cost;
            Faction = faction;
            CardEffect.Add(eff1);
            CardEffect.Add(eff2);
        }

        /// <summary>
        /// エフェクト3つのカード
        /// </summary>
        /// <param name="name">名前</param>
        /// <param name="cost">コスト</param>
        /// <param name="faction">勢力</param>
        /// <param name="eff1">1つめのエフェクト（インスタンス"new xxxEffect()"で入力してください）</param>
        /// <param name="eff2">2つめのエフェクト（インスタンス"new xxxEffect()"で入力してください）</param>
        /// <param name="eff3">3つめのエフェクト（インスタンス"new xxxEffect()"で入力してください）</param>
        public Card(string name, int cost, int faction, Effect eff1, Effect eff2, Effect eff3)
        {
            Name = name;
            Cost = cost;
            Faction = faction;
            CardEffect.Add(eff1);
            CardEffect.Add(eff2);
            CardEffect.Add(eff3);
        }

        // プロパティ
        public string Name { get; set; }
        public int Cost { get; set; }
        public int Faction { get; set; }
        public int CardType { get; set; }
        public List<Effect> CardEffect { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        // public string FrameImage { get; set; }
        // public string CardImage { get; set; }

        // メソッド

    }
}
