using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State_StartRound : State_Base
{
    public override void OnStateEnter(BattleSystem battleSystem)
    {
        battleSystem.NewRound();
        battleSystem.ShowLists();
    }
}
