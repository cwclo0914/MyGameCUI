using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// デッキのカードリスト
/// </summary>
namespace MyGameCUI
{    
    class Deck : AbstractDeck
    {
        public int Faction;

        /// <summary>
        /// デッキから上からカードを１枚引く
        /// </summary>
        /// <returns>引いたカード、なければnull</returns>
        public Card Draw()
        {
            return RemoveCard(0);
        }

        /// <summary>
        /// デッキをシャッフルする
        /// </summary>
        public void Shuffle()
        {
            Random r = new Random();
            int n = CountCard() - 1;

            while (n > 0)
            {
                int w = r.Next(0, n);
                Card c = CardList[n];
                CardList[n] = CardList[w];
                CardList[w] = c;
                n--;
            }

        }

        /// <summary>
        /// 入れられたカードリストからデッキを作る
        /// </summary>
        /// <param name="list">作りたいデッキ</param>
        public void CreateDeck(List<Card> list)
        {

            for(int i = 0; i < list.Count; i++)
            {
                CardList.Add(list[i]);
            }

        }

    }
}
