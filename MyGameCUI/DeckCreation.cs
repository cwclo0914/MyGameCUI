using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameCUI
{
    class DeckCreation
    {
        // フィールド


        // メソッド
        /// <summary>
        /// 最大枚数のデッキを生成する
        /// （最終的にはデータベースから引っ張ってきたい）
        /// </summary>
        /// <returns>デッキ"List<Card>"を返す</returns>
        public void Create(Entity owner)
        {
            owner.MyDeck.AddCard(new Monster("ゴブリン", 1, Settings.Aggro, 1, 1, new EnchantSingleEffect(owner, 2, 1)));
        }

    }
}
