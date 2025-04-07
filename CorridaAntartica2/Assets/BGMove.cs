using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMove : MonoBehaviour
{
    public Transform End;
    public float Speed;
    [SerializeField]private Vector3 _startPos;


    private void Start()
    {
        _startPos = End.position;
    }

    private void Update()
    {

        transform.Translate((Vector3.right * -1) * Speed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Wall"))
        {
            transform.position = new Vector3( _startPos.x,_startPos.y,_startPos.z);
            Debug.Log("ahhhhh");
        }

    }
}
