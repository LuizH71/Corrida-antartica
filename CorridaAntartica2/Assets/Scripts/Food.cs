using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Food : MonoBehaviour
{
    public floatVariable CurrentFood;
    public floatVariable MaxFood;

    public UnityEvent GoodEndingEvent;
    private void OnDisable()
    {
        CurrentFood.Value = 0;
    }
    public void TakeFood(float AmountDamageToFood)
    {
        if(CurrentFood.Value > 0)
        {
            CurrentFood.Value -= AmountDamageToFood;
        }
        else
        {
            CurrentFood.Value = 0;
        }

    }
    public void GiveFood(float AmountFoodToGive)
    {
        if((CurrentFood.Value + AmountFoodToGive) >= MaxFood.Value)
        {
            GoodEndingEvent.Invoke();
        }
        else
        {
            CurrentFood.Value += AmountFoodToGive;
        }
    }
}
