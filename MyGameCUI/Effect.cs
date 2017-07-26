using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameCUI
{
    /// <summary>
    /// エフェクトの抽象クラス
    /// </summary>
    abstract class Effect
    {
        // コンストラクタ
        public Effect()
        {
            Description = string.Empty;
        }

        // プロパティ
        /// <summary>
        /// カードに表示させる文言
        /// </summary>
        public string Description { get; set; }

        // メソッド
        /// <summary>
        /// エフェクト使用
        /// </summary>
        public abstract void ApplyEffect();
    }

    /// <summary>
    /// 味方のモンスター一体の体力と攻撃力を上昇させる（！return値未完成）
    /// </summary>
    class EnchantSingleEffect : Effect
    {
        // フィールド
        private int hpIncre; // 体力上昇値
        private int atkIncre; // 攻撃力上昇値

        // コンストラクタ
        /// <summary>
        /// 自分のモンスター一体の体力と攻撃力を上昇させる
        /// </summary>
        /// <param name="hp">体力上昇値</param>
        /// <param name="atk">攻撃力上昇値</param>
        public EnchantSingleEffect(int hp, int atk)
        {
            hpIncre = hp;
            atkIncre = atk;
            Description += "召喚時、味方のモンスター一体を" + hpIncre.ToString("+#;-#;0") + "/" + atkIncre.ToString("+#;-#;0") + "する"; // +/-の符号を強制的に表示させる
        }

        // メソッド
        /// <summary>
        /// 味方のモンスターを指定させ、強化の効果を発揮する
        /// </summary>
        public override void ApplyEffect()
        {
            EnchantSingle();
        }

        /// <summary>
        /// 味方のモンスターを指定させ、強化の効果を発揮する
        /// </summary>
        private void EnchantSingle()
        {
            Card targetMonster = TargetAllyMonster(); // TargetAllyMonster()で味方のモンスター一体をreturn
            targetMonster.HP += hpIncre;
            targetMonster.Attack += atkIncre;
        }
    }

    /// <summary>
    /// 召喚されたもの以外、自分のモンスター全体の体力と攻撃力を上昇させる（！return値未完成）
    /// </summary>
    class EnchantAlliesEffect : Effect
    {
        // フィールド
        private int hpIncre; // 体力上昇値
        private int atkIncre; // 攻撃力上昇値

        // コンストラクタ
        /// <summary>
        /// 召喚されたもの以外、自分のモンスター全体の体力と攻撃力を上昇させる
        /// </summary>
        /// <param name="hp">体力上昇値</param>
        /// <param name="atk">攻撃力上昇値</param>
        public EnchantAlliesEffect(int hp, int atk)
        {
            hpIncre = hp;
            atkIncre = atk;
            Description += "召喚時、自分以外の味方のモンスター全てを" + hpIncre.ToString("+#;-#;0") + "/" + atkIncre.ToString("+#;-#;0") + "する"; // +/-の符号を強制的に表示させる
        }

        // メソッド
        /// <summary>
        /// 味方のモンスター全てに強化の効果を発揮する
        /// </summary>
        public override void ApplyEffect()
        {
            EnchantAllies();
        }

        /// <summary>
        /// 味方のモンスター全てに強化の効果を発揮する
        /// </summary>
        private void EnchantAllies()
        {
            List<Card> targetMonsters = TargetAllAllies(); // TargetAllAllies()で味方のモンスター全てをreturn（List<Card>で）
            foreach (Card monster in targetMonsters)
            {
                monster.HP += hpIncre;
                monster.Attack += atkIncre;
            }
        }
    }

    /// <summary>
    /// 相手のモンスター一体にダメージを与える（！return値未完成）
    /// </summary>
    class DamageSingleEffect : Effect
    {
        // フィールド
        private int damage; // ダメージ

        // コンストラクタ
        /// <summary>
        /// 相手のモンスター一体にダメージを与える
        /// </summary>
        /// <param name="dam">ダメージ</param>
        public DamageSingleEffect(int dam)
        {
            damage = dam;
            Description += "召喚時、相手のモンスター一体に" + damage.ToString() + "ダメージ"; // ToStringを一致させるべき？
        }

        // メソッド
        /// <summary>
        /// 相手のモンスターを指定させ、ダメージを与える
        /// </summary>
        public override void ApplyEffect()
        {
            DamageSingle();
        }

        /// <summary>
        /// 相手のモンスターを指定させ、ダメージを与える
        /// </summary>
        private void DamageSingle()
        {
            Card targetEnemy = TargetEnemyMonster(); // TargetEnemyMonster()で相手のモンスター一体をreturn
            targetEnemy.HP -= damage;
        }
    }

    /// <summary>
    /// 相手のモンスター全てにダメージを与える（！return値未完成）
    /// </summary>
    class DamageEnemiesEffect : Effect
    {
        // フィールド
        private int damage; // ダメージ

        // コンストラクタ
        /// <summary>
        /// 相手のモンスター全てにダメージを与える
        /// </summary>
        /// <param name="dam">ダメージ</param>
        public DamageEnemiesEffect(int dam)
        {
            damage = dam;
            Description += "召喚時、相手のモンスター全てに" + damage.ToString() + "ダメージ"; // ToStringを一致させるべき？
        }

        // メソッド
        /// <summary>
        /// 相手のモンスターを指定させ、ダメージを与える
        /// </summary>
        public override void ApplyEffect()
        {
            DamageEnemies();
        }

        /// <summary>
        /// 相手のモンスターを指定させ、ダメージを与える
        /// </summary>
        private void DamageEnemies()
        {
            List<Card> targetEnemies = TargetAllEnemies(); // TargetAllEnemies()で相手のモンスター全てをreturn（List<Card>で）
            foreach (Card enemy in targetEnemies)
            {
                enemy.HP -= damage;
            }
        }
    }
}
