using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class PlayerTrigger : MonoBehaviour
{
    [SerializeField] private UnityEvent Food;
    [SerializeField] private UnityEvent Residuo;
    [SerializeField] private UnityEvent Predador;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Food"))
        {
            Food.Invoke();
            collision.GetComponent<ObstaculoMov>().Return();
            Debug.Log("Food");
        }
        if (collision.CompareTag("Residuo"))
        {
            Residuo.Invoke();
            collision.GetComponent<ObstaculoMov>().Return();
            Debug.Log("Residuo");
        }
        if (collision.CompareTag("Predador"))
        {
            Predador.Invoke();
            Debug.Log("Residuo");
        }
    }
}
