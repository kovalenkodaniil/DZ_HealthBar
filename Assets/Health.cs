using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int _healthMax;

    private int _currentHealth;

    public int HealthMax => _healthMax;
    public int CurrentHealth => _currentHealth;


    private void Awake()
    {
        _currentHealth = _healthMax;
    }

    public void ChangeHealth(int healthChange)
    {
        if (_currentHealth > healthChange && _currentHealth + healthChange <= _healthMax) 
        {
            _currentHealth += healthChange;
        }
    }
}
