using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playState : GameBaseState
{
    public override void EnterState(GameStateManager game, GameController controller)
    {
        Debug.Log("load play state");
        CurrentStateData.currentState = this;
        SceneManager.LoadScene(GameData.selectedLevel);
    }

    public override void ExitState(GameStateManager game, GameController controller)
    {
        base.ExitState(game, controller);
        CurrentStateData.toPlayState= false;
    }

    public override void UpdateState(GameStateManager game, GameController controller)
    {
        if (CurrentStateData.toWinState == true)
        {
            ExitState(game, controller);
            game.SwitchState(game.winState);
        }
    }
}
