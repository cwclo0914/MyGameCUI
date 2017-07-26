using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameCUI
{
 

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
            state = GameStateInit.GetInstance();
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