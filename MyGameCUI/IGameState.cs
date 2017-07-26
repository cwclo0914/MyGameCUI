using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameCUI
{
    /*
      * ゲームの状態を表すクラスのためのインターフェイス
      * その状態で行うべき処理のメソッドと、次の状態を返すメソッドを実装する
      */
    interface IGameState
    {
        void DoProcess();
        IGameState NextState();
    }

    /*
     * 以下、GameStateの実装クラス
     * 同じ状態のインスタンスが複数あっても仕方ないので、シングルトンパターンを使用
     */
    class GameStateInit : IGameState
    {
        private static GameStateInit instance = new GameStateInit();
        public static GameStateInit GetInstance()
        {
            return instance;
        }

        public void DoProcess()
        {
            CUI.ShowMessage("starting GameStateDraw phase...");
            CUI.ShowMessage("shuffling decks...");
            GameInfo.EntityAttacking.MyDeck.Shuffle();
            CUI.ShowMessage("you have drawn " + Settings.InitHand + " cards from your deck");
            GameInfo.EntityAttacking.DrawCards(Settings.InitHand);
            CUI.ShowAbstractDeck(GameInfo.EntityAttacking.MyHand);
        }

        public IGameState NextState()
        {
            return GameStateDraw.GetInstance();
        }
    }

    class GameStateDraw : IGameState
    {
        private static GameStateDraw instance = new GameStateDraw();
        public static GameStateDraw GetInstance()
        {
            return instance;
        }

        public void DoProcess()
        {
            CUI.ShowMessage("starting GameStateDraw phase...");
            CUI.ShowMessage("you have drawn 1 card.");
            GameInfo.EntityAttacking.DrawCards(1);
            CUI.ShowAbstractDeck(GameInfo.EntityAttacking.MyHand);
        }

        public IGameState NextState()
        {
            return GameStateMain.GetInstance();
        }
    }

    class GameStateMain : IGameState
    {
        private static GameStateMain instance = new GameStateMain();
        public static GameStateMain GetInstance()
        {
            return instance;
        }

        public void DoProcess()
        {
            CUI.ShowMessage("starting GameStateMain process...");
            CUI.ShowMessage("kill entity 1");
            GameInfo.EntityAttacking.Life -= 100;
        }

        public IGameState NextState()
        {
            return GameStateMain.GetInstance();
        }
    }

    class GameStateCombat : IGameState
    {
        private static GameStateCombat instance = new GameStateCombat();
        public static GameStateCombat GetInstance()
        {
            return instance;
        }

        public void DoProcess()
        {
            CUI.ShowMessage("starting GameStateCombat process...");

        }

        public IGameState NextState()
        {
            return GameStateSecondMain.GetInstance();
        }
    }

    class GameStateSecondMain : IGameState
    {
        private static GameStateSecondMain instance = new GameStateSecondMain();

        public static GameStateSecondMain GetInstance()
        {
            return instance;
        }

        public void DoProcess()
        {
            CUI.ShowMessage("starting GameStateSecondMain process...");
        }

        public IGameState NextState()
        {
            return null;
        }
    }
}
