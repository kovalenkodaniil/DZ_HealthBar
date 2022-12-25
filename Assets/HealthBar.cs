using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]

public class HealthBar : MonoBehaviour
{
    [SerializeField] private float _healthChangeTime;
    [SerializeField] private Health _health;

    private Slider _healthBar;

    private void Start()
    {
        _healthBar = GetComponent<Slider>();

        _healthBar.maxValue = _health.HealthMax;
        _healthBar.value = _health.CurrentHealth;
    }

    public void ChangeHealthBarView()
    {
        float currentHealht = _health.CurrentHealth;
        float healthChange = Mathf.Abs(currentHealht - _healthBar.value);

        StartCoroutine(ChangeHealthBarValue(currentHealht, healthChange));
    }

    private IEnumerator ChangeHealthBarValue(float currentHealht, float healthChange)
    {
        while (_healthBar.value != currentHealht) 
        {
            _healthBar.value = Mathf.MoveTowards(_healthBar.value, currentHealht, healthChange * _healthChangeTime * Time.deltaTime);

            yield return null;
        }
    }
}
