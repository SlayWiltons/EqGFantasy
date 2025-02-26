using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    private State_Base currentState;
    public State_StartRound StartRound = new State_StartRound();

    private void Start()
    {
        currentState = StartRound;
        currentState.OnStateEnter(this);
    }

    public void GetNumber()
    {
        Debug.Log("1");
    }
}
