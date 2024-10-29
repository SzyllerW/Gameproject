using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Dodaj tê liniê, aby u¿ywaæ UI

public class HitPointsController : MonoBehaviour
{
    [SerializeField] private int _currentHP;
    [SerializeField] public int maxHP;
    [SerializeField] private Slider healthSlider; // Dodaj referencjê do Slidera

    private void Start()
    {
        _currentHP = maxHP;
        if (healthSlider != null)
        {
            healthSlider.maxValue = maxHP;
            healthSlider.value = _currentHP;
            Debug.Log("Slider initialized. Max HP: " + maxHP + ", Current HP: " + _currentHP);
        }
        else
        {
            Debug.LogError("Health slider is not assigned!");
        }
    }

    public void TakeDamage(int dmg)
    {
        _currentHP -= dmg;
        if (_currentHP <= 0)
        {
            _currentHP = 0;
            Die();
        }

        if (healthSlider != null)
        {
            healthSlider.value = _currentHP;
            Debug.Log("Damage taken. Current HP: " + _currentHP);
        }
        else
        {
            Debug.LogError("Health slider is not assigned!");
        }
    }

    public void Die()
    {
        Debug.Log("Enemy died.");
        Destroy(gameObject);
    }
}
