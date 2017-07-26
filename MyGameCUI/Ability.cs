using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameCUI
{
    class Ability
    {
        // コンストラクタ
        public Ability()
        {

        }

        // プロパティ
        /// <summary>
        /// 速攻
        /// </summary>
        public bool InstantAttack { get; set; }
        /// <summary>
        /// 貫通
        /// </summary>
        public bool Penetrate { get; set; }
        /// <summary>
        /// モンスター以外をターゲットにできない
        /// </summary>
        public bool TargetMonsterOnly { get; set; }
        /// <summary>
        /// 二回攻撃
        /// </summary>
        public bool DoubleAttack { get; set; }
    }
}
