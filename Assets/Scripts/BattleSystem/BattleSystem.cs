using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    private State_Base currentState;
    private Character hero;
    private Character enemy;
    private int round = 0;
    [SerializeField] private List<BaseCharacter> heroes;
    [SerializeField] private List<BaseCharacter> enemies;
    public State_StartRound StartRound = new State_StartRound();
    private List<Character> HeroesList = new List<Character>();
    private List<Character> EnemiesList = new List<Character>();
    private List<Character> ActiveHeroes = new List<Character>();
    private List<Character> ActiveEnemies = new List<Character>();

    private void Awake()
    {
        Debug.Log(hero);
        for (int i = 0; i < heroes.Count; i++)
        {            
            hero.InitializeCharacter(heroes[i]);//пока не работает
            HeroesList.Add(hero);
        }
        for (int i = 0; i < enemies.Count; i++)
        {            
            enemy.InitializeCharacter(enemies[i]);
            EnemiesList.Add(enemy);
        }
    }

    private void Start()
    {        
        currentState = StartRound;
        currentState.OnStateEnter(this);
    }

    public void NewRound()
    {
        round++;
        Debug.Log("Round " + round);
    }

    public void ShowLists()
    {
        for (int i = 0; i < HeroesList.Count; i++)
        {
            Debug.Log(HeroesList[i]);
        }
    }
}
