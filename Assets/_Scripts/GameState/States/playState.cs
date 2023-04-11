using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playState : GameBaseState
{
    public override void EnterState(GameStateManager game, GameController controller)
    {
        Debug.Log("load play state");
        CurrentStateData.currentState = this;
    }

    public override void ExitState(GameStateManager game, GameController controller)
    {
        base.ExitState(game, controller);
    }

    public override void OnCollisionEnter(GameStateManager game, GameController controller)
    {
        base.OnCollisionEnter(game, controller);
    }

    public override void UpdateState(GameStateManager game, GameController controller)
    {
        if (controller.toWinState == true)
        {
            game.LeaveState(game.playState);
            game.SwitchState(game.winState);
        }
    }
}
