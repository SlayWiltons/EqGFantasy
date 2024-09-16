using UnityEngine;

public class Character : MonoBehaviour, IDamageable<int>, IKillable
{
    [SerializeField] private BaseCharacter _baseCharacter;
    private string _name;
    private int _hp;
    private int _mana;
    private int _currentHP;

    public void Start()
    {
        if (_baseCharacter != null)
        {
            _name = _baseCharacter.nameCharacter;
            _hp = _baseCharacter.hp;
            _mana = _baseCharacter.mana;
            _currentHP = _hp;
        }
    }

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
}
