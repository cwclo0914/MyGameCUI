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
        /// <param name="owner">所有者</param>
        public Card(string name, int cost, int faction, Entity owner)
        {
            Name = name;
            Cost = cost;
            Faction = faction;
            Owner = owner;
            if (Owner == GameInfo.EntityAttacking)
                Opponent = GameInfo.EntityDefending;
            else
                Opponent = GameInfo.EntityAttacking;
            LightUp = false;
        }

        /// <summary>
        /// エフェクト1つのカード
        /// </summary>
        /// <param name="name">名前</param>
        /// <param name="cost">コスト</param>
        /// <param name="faction">勢力</param>
        /// <param name="owner">所有者</param>
        /// <param name="eff1">1つめのエフェクト（インスタンス"new xxxEffect()"で入力してください）</param>
        public Card(string name, int cost, int faction, Entity owner, Effect eff1)
        {
            Name = name;
            Cost = cost;
            Faction = faction;
            Owner = owner;
            if (Owner == GameInfo.EntityAttacking)
                Opponent = GameInfo.EntityDefending;
            else
                Opponent = GameInfo.EntityAttacking;
            LightUp = false;
            CardEffect = new List<Effect>();
            CardEffect.Add(eff1);
        }

        /// <summary>
        /// エフェクト2つのカード
        /// </summary>
        /// <param name="name">名前</param>
        /// <param name="cost">コスト</param>
        /// <param name="faction">勢力</param>
        /// <param name="owner">所有者</param>
        /// <param name="eff1">1つめのエフェクト（インスタンス"new xxxEffect()"で入力してください）</param>
        /// <param name="eff2">2つめのエフェクト（インスタンス"new xxxEffect()"で入力してください）</param>
        public Card(string name, int cost, int faction, Entity owner, Effect eff1, Effect eff2)
        {
            Name = name;
            Cost = cost;
            Faction = faction;
            Owner = owner;
            if (Owner == GameInfo.EntityAttacking)
                Opponent = GameInfo.EntityDefending;
            else
                Opponent = GameInfo.EntityAttacking;
            LightUp = false;
            CardEffect = new List<Effect>();
            CardEffect.Add(eff1);
            CardEffect.Add(eff2);
        }

        /// <summary>
        /// エフェクト3つのカード
        /// </summary>
        /// <param name="name">名前</param>
        /// <param name="cost">コスト</param>
        /// <param name="faction">勢力</param>
        /// <param name="owner">所有者</param>
        /// <param name="eff1">1つめのエフェクト（インスタンス"new xxxEffect()"で入力してください）</param>
        /// <param name="eff2">2つめのエフェクト（インスタンス"new xxxEffect()"で入力してください）</param>
        /// <param name="eff3">3つめのエフェクト（インスタンス"new xxxEffect()"で入力してください）</param>
        public Card(string name, int cost, int faction, Entity owner, Effect eff1, Effect eff2, Effect eff3)
        {
            Name = name;
            Cost = cost;
            Faction = faction;
            Owner = owner;
            if (Owner == GameInfo.EntityAttacking)
                Opponent = GameInfo.EntityDefending;
            else
                Opponent = GameInfo.EntityAttacking;
            LightUp = false;
            CardEffect = new List<Effect>();
            CardEffect.Add(eff1);
            CardEffect.Add(eff2);
            CardEffect.Add(eff3);
        }

        // プロパティ
        /// <summary>
        /// 名前
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// コスト
        /// </summary>
        public int Cost { get; set; }
        /// <summary>
        /// 勢力
        /// </summary>
        public int Faction { get; set; }
        /// <summary>
        /// カードのインスタンスの所有者
        /// </summary>
        public Entity Owner { get; set; }
        /// <summary>
        /// 所有者にとっての対戦相手
        /// </summary>
        public Entity Opponent { get; set; }
        /// <summary>
        /// エフェクトのリスト
        /// </summary>
        public List<Effect> CardEffect { get; set; }
        /// <summary>
        /// 体力
        /// </summary>
        public int HP { get; set; }
        /// <summary>
        /// 攻撃力
        /// </summary>
        public int Attack { get; set; }
        /// <summary>
        /// Settingsの静的変数で設定すること（Monster, Sorcery, Instant）
        /// </summary>
        public int CardType { get; set; }
        /// <summary>
        /// True: フィールドに残る、False: フィールドに残らない
        /// </summary>
        public bool StaysOnField { get; set; }
        /// <summary>
        /// カードが選択可能であれば光る仕組みに使うフラグ
        /// </summary>
        public bool LightUp { get; set; }

        // public string FrameImage { get; set; }
        // public string CardImage { get; set; }

        // メソッド
        /// <summary>
        /// モンスターがSleepする
        /// </summary>
        public virtual void Sleep()
        {
        }

        /// <summary>
        /// モンスターがWakeUpする
        /// </summary>
        public virtual void WakeUp()
        {
        }
    }
}
