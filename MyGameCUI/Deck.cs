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


    }
}
