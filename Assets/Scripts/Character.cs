using UnityEngine;

public class Character : MonoBehaviour, IDamageable<int>, IKillable
{
    private string _name;
    private int _hp;
    private int _mana;
    private int _currentHP;
    private int _currentMana;

    public void TakeDamage(int takenDamage)
    {
        _currentHP -= takenDamage;
        if (_currentHP <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        gameObject.SetActive(false);
    }

    public void InitializeCharacter(BaseCharacter baseCharacter)
    {
        if (baseCharacter != null)
        {
            _name = baseCharacter.nameCharacter;
            _hp = baseCharacter.hp;
            _mana = baseCharacter.mana;
            _currentHP = _hp;
            _currentMana = _mana;
        }
        else return;
    }
}
