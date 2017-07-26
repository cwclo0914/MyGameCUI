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
    class GameStateDraw : IGameState
    {
        private static GameStateDraw instance = new GameStateDraw();
        public static GameStateDraw GetInstance()
        {
            return instance;
        }

        public void DoProcess()
        {
            CUI.ShowMessage("starting GameStateDraw process...");

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

    class GameMaster
    {
        private Stack<Effect> effectStack;
        private IGameState state;

        public GameMaster()
        {
            effectStack = new Stack<Effect>();
        }

        public void StartGame()
        {
            GameInfo.Init();
            state = GameStateDraw.GetInstance();
            while (!IsGameOver())
            {
                GoToNextState();
            }
            EndGame();
        }

        public void EndGame()
        {
            CUI.ShowMessage("Game Over!");
        }

        private void GoToNextState()
        {
            state.DoProcess();
            state = state.NextState();
        }

        private bool IsGameOver()
        {
            return GameInfo.EntityAttacking.Life <= 0 || GameInfo.EntityDefending.Life <= 0;
        }
    }
}