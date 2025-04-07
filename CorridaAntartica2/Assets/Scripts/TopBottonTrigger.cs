using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopBottonTrigger : MonoBehaviour
{

    [SerializeField] private bool _top, _botton;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerMov>().OnBotton = _botton;
            collision.GetComponent<PlayerMov>().OnTop = _top;
            collision.GetComponent<PlayerMov>().AnimBotton(true);
            collision.GetComponent<PlayerMov>().AnimTop(true);

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerMov>().OnBotton = false;
            collision.GetComponent<PlayerMov>().OnTop = false;
            collision.GetComponent<PlayerMov>().AnimBotton(false);
            collision.GetComponent<PlayerMov>().AnimTop(false);
        }
    }
}
