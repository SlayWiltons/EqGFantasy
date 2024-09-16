using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "BaseCharacter", menuName = "BaseCharacter")]
public class BaseCharacter : ScriptableObject
{
    public string nameCharacter;
    public int hp;
    public int mana;
}
