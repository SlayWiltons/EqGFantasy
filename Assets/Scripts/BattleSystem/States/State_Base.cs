using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State_Base
{
    public virtual void OnStateEnter(BattleSystem battleSystem)
    {
       
    }

    public virtual void OnStateProceed(BattleSystem battleSystem)
    {

    }

    public virtual void OnStateFinished(BattleSystem battleSystem)
    {

    }
}