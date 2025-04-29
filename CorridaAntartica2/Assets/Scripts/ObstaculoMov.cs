using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SpawnPosition { Up, Botton }
public class ObstaculoMov : MonoBehaviour
{

    [Header("type of object")]
    public SpawnPosition type;

    [SerializeField] private Rigidbody2D _rb;
    [SerializeField]private float _speed;
    public float Speed = 10;



    private void FixedUpdate()
    {
        if (_speed > Speed)
        {
            //transform.Translate((Vector3.right * -1) * speed * Time.deltaTime);
            _rb.velocity = new Vector3(-_speed, 0, 0);
        }
        else
        {
            //transform.Translate((Vector3.right * -1) * Speed * Time.deltaTime);
            _rb.velocity = new Vector3(-Speed, 0, 0);
        }


        if (_speed < 25f)
        {
            _speed = (Time.timeSinceLevelLoad + Speed) / 3;

        }
        else
        {
            _speed = 25f;
        }
    }
   
    public IEnumerator ReturnToPool()
    {
        yield return new WaitForSeconds(6f);
        gameObject.SetActive(false);
        StopCoroutine(ReturnToPool());
    }

    public void Return()
    {
        gameObject.SetActive(false);
        StopCoroutine(ReturnToPool());
    }
}
