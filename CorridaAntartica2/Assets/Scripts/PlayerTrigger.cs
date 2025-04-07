using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class PlayerTrigger : MonoBehaviour
{
    [SerializeField] private UnityEvent Food;
    [SerializeField] private UnityEvent Residuo;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Food"))
        {
            Food.Invoke();
            Debug.Log("Food");
        }
        if (collision.CompareTag("Residuo"))
        {
            Residuo.Invoke();
            Debug.Log("Residuo");
        }
    }
}
