using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int _healthMax;
    [SerializeField] private HealthBar _healthBar;

    private int _currentHealth;

    private void Start()
    {
        _currentHealth = _healthMax;
        _healthBar.SetValue(_healthMax,_currentHealth);
    }

    public void ChangeHealth(int healthChange)
    {
        if (_currentHealth > healthChange && _currentHealth + healthChange <= _healthMax) 
        {
            _currentHealth += healthChange;

            _healthBar.ChangeHealthBarView(_currentHealth, healthChange);
        }
    }
}
