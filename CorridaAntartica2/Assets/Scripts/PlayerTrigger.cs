using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class PlayerTrigger : MonoBehaviour
{
    [SerializeField] private UnityEvent Food;
    [SerializeField] private UnityEvent Residuo;
    [SerializeField] private UnityEvent Orca;
    [SerializeField] private UnityEvent Foca;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Food"))
        {
            Food.Invoke();
            collision.GetComponent<ObstaculoMov>().Return();
        }
        if (collision.CompareTag("Residuo"))
        {
            Residuo.Invoke();
            collision.GetComponent<ObstaculoMov>().Return();
        }
        if (collision.CompareTag("Orca"))
        {
            Orca.Invoke();
        }
        if (collision.CompareTag("Foca"))
        {
            Foca.Invoke();
        }
    }
}
