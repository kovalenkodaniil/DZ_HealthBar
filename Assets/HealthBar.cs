using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]

public class HealthBar : MonoBehaviour
{
    [SerializeField] private float _healthChangeTime;

    private Slider _healthBar;

    private void Start()
    {
        _healthBar = GetComponent<Slider>();
    }

    public void ChangeHealthBarView(int currentHealht, int healthChange)
    {
        healthChange = Mathf.Abs(healthChange);

        StartCoroutine(ChangeHealthBarValue(currentHealht, healthChange));
    }

    public void SetValue(int healhtMax,int currentHealht)
    {
        _healthBar.maxValue = healhtMax;
        _healthBar.value = currentHealht;
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
