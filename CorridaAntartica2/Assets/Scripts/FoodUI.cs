using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class FoodUI : MonoBehaviour
{
    [SerializeField] private Slider _healthSlider;

    public floatVariable CurrentFood;

    [SerializeField] private UnityEvent Death;
    private void Start()
    {
        UpdateLife();
    }
    public void UpdateLife()
    {
        _healthSlider.value = CurrentFood.Value;

    }
}
