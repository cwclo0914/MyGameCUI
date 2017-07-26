using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameCUI
{
    class Monster : Card
    {
        // フィールド


        // コンストラクタ
        /// <summary>
        /// エフェクトなしのモンスターカード
        /// </summary>
        /// <param name="name">名前</param>
        /// <param name="cost">コスト</param>
        /// <param name="faction">勢力</param>
        /// <param name="hp">体力</param>
        /// <param name="atk">攻撃力</param>
        public Monster(string name, int cost, int faction, int hp, int atk)
            : base(name, cost, faction)
        {
            HP = hp;
            Attack = atk;
            CardType = Settings.Monster;
            StaysOnField = true;
        }

        /// <summary>
        /// エフェクト1つのモンスターカード
        /// </summary>
        /// <param name="name">名前</param>
        /// <param name="cost">コスト</param>
        /// <param name="faction">勢力</param>
        /// <param name="hp">体力</param>
        /// <param name="atk">攻撃力</param>
        /// <param name="eff1">1つめのエフェクト（インスタンス"new xxxEffect()"で入力してください）</param>
        public Monster(string name, int cost, int faction, int hp, int atk, Effect eff1)
            : base(name, cost, faction, eff1)
        {
            HP = hp;
            Attack = atk;
            CardType = Settings.Monster;
            StaysOnField = true;
        }

        /// <summary>
        /// エフェクト2つのモンスターカード
        /// </summary>
        /// <param name="name">名前</param>
        /// <param name="cost">コスト</param>
        /// <param name="faction">勢力</param>
        /// <param name="hp">体力</param>
        /// <param name="atk">攻撃力</param>
        /// <param name="eff1">1つめのエフェクト（インスタンス"new xxxEffect()"で入力してください）</param>
        /// <param name="eff2">2つめのエフェクト（インスタンス"new xxxEffect()"で入力してください）</param>
        public Monster(string name, int cost, int faction, int hp, int atk, Effect eff1, Effect eff2)
            : base(name, cost, faction, eff1, eff2)
        {
            HP = hp;
            Attack = atk;
            CardType = Settings.Monster;
            StaysOnField = true;
        }

        /// <summary>
        /// エフェクト3つのモンスターカード
        /// </summary>
        /// <param name="name">名前</param>
        /// <param name="cost">コスト</param>
        /// <param name="faction">勢力</param>
        /// <param name="hp">体力</param>
        /// <param name="atk">攻撃力</param>
        /// <param name="eff1">1つめのエフェクト（インスタンス"new xxxEffect()"で入力してください）</param>
        /// <param name="eff2">2つめのエフェクト（インスタンス"new xxxEffect()"で入力してください）</param>
        /// <param name="eff3">3つめのエフェクト（インスタンス"new xxxEffect()"で入力してください）</param>
        public Monster(string name, int cost, int faction, int hp, int atk, Effect eff1, Effect eff2, Effect eff3)
            : base(name, cost, faction, eff1, eff2, eff3)
        {
            HP = hp;
            Attack = atk;
            CardType = Settings.Monster;
            StaysOnField = true;
        }

        // プロパティ


        // メソッド

    }
}
