using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameCUI
{
    class Entity
    {
        public int Life { get; set; }
        public int MaxMana { get; set; }
        public int CurrentMana { get; set; }
        public Deck MyDeck { get; set; }
        public Hand MyHand { get; set; }
        public Grave MyGrave { get; set; }
        public BattleField MyBattleField { get; set; }

        public Entity()
        {
            Life = Settings.InitLife;
            MaxMana = 0;
            CurrentMana = 0;
            MyDeck = GenerateDeck();
            MyHand = new Hand(new List<Card>());
            MyGrave = new Grave(new List<Card>());
            MyBattleField = new BattleField(new List<Card>());
        }

        public void DrawCards(int drawCount)
        {
            if (drawCount <= 0) return;
            for (int i = 0; i < drawCount; i++)
            {
                Card topCard = MyDeck.DrawTopCard();
                if (topCard == null) break;
                MyHand.AddCard(topCard);
            }
        }

        /*
         * 仮のデッキ生成用メソッド。適当なカードをデッキに入れて返す
         */
        private Deck GenerateDeck()
        {
            Monster goblin = new Monster("Goblin", 1, 0, 1, 2);
            Sorcery firebolt = new Sorcery("Fire Bolt", 1, 0, null);
            List<Card> cardList = new List<Card>(new Card[] { goblin, firebolt, goblin, firebolt, goblin, firebolt});
            return new Deck(cardList);
        }
    }
}
