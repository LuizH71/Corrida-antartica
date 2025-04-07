using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public floatVariable CurrentFood;
    public floatVariable MaxFood;

    private void OnDisable()
    {
        CurrentFood.Value = 0;
    }
    public void TakeFood(float AmountDamageToFood)
    {
        CurrentFood.Value -= AmountDamageToFood;
           
    }
    public void GiveFood(float AmountFoodToGive)
    {
        CurrentFood.Value += AmountFoodToGive;
    }
}
