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
        public Card(string name, int cost, int faction)
        {
            Name = name;
            Cost = cost;
            Faction = faction;
            LightUp = false;
        }

        /// <summary>
        /// エフェクト1つのカード
        /// </summary>
        /// <param name="eff1">1つめのエフェクト（インスタンス"new xxxEffect()"で入力してください）</param>
        public Card(string name, int cost, int faction, Effect eff1)
        {
            Name = name;
            Cost = cost;
            Faction = faction;
            CardEffect = new List<Effect>();
            CardEffect.Add(eff1);
            LightUp = false;
        }

        /// <summary>
        /// エフェクト2つのカード
        /// </summary>
        /// <param name="eff1">1つめのエフェクト（インスタンス"new xxxEffect()"で入力してください）</param>
        /// <param name="eff2">2つめのエフェクト（インスタンス"new xxxEffect()"で入力してください）</param>
        public Card(string name, int cost, int faction, Effect eff1, Effect eff2)
        {
            Name = name;
            Cost = cost;
            Faction = faction;
            CardEffect.Add(eff1);
            CardEffect.Add(eff2);
            LightUp = false;
        }

        /// <summary>
        /// エフェクト3つのカード
        /// </summary>
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
            LightUp = false;
        }

        // プロパティ
        public string Name { get; set; }
        public int Cost { get; set; }
        /// <summary>
        /// 勢力
        /// </summary>
        public int Faction { get; set; }
        /// <summary>
        /// Settingsの静的変数で設定すること（Monster, Sorcery, Instant）
        /// </summary>
        public int CardType { get; set; }
        /// <summary>
        /// True: フィールドに残る、False: フィールドに残らない
        /// </summary>
        public bool StaysOnField { get; set; }
        /// <summary>
        /// 選択可能のカードが光るのに使用するフラグ
        /// </summary>
        public bool LightUp { get; set; }
        /// <summary>
        /// エフェクトのリスト
        /// </summary>
        public List<Effect> CardEffect { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        // public string FrameImage { get; set; }
        // public string CardImage { get; set; }

        // メソッド
        public virtual void Sleep()
        {
        }

        public virtual void WakeUp()
        {
        }
    }
}
