using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    private State_Base currentState;
    [SerializeField] private List<BaseCharacter> heroes;
    [SerializeField] private List<BaseCharacter> enemies;
    public State_StartRound StartRound = new State_StartRound();
    public List<BaseCharacter> HeroesList = new List<BaseCharacter>();
    public List<BaseCharacter> EnemiesList = new List<BaseCharacter>();
    public List<BaseCharacter> ActiveHeroes = new List<BaseCharacter>();
    public List<BaseCharacter> ActiveEnemies = new List<BaseCharacter>();

    private void Awake()
    {
        for (int i = 0; i < heroes.Count; i++)
        {
            HeroesList.Add(heroes[i]);
        }
        for (int i = 0; i < enemies.Count; i++)
        {
            EnemiesList.Add(heroes[i]);
        }
    }

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
