using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// バトルフィールドのカードリスト
/// </summary>
namespace MyGameCUI
{
    class BattleField : AbstractDeck
    {
        public BattleField(List<Card> cardList): base(cardList)
        {
        }

        public Card SelectSingleMonster()
        {
            return null;
        }

        public List<Card> SelectAllMonsters()
        {
            return null;
        }
    }
}
