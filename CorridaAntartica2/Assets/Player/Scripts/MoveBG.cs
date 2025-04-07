using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBG : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _offset;

    private Vector2 _startPos;
    private float _newXPos;
    void Start()
    {
        _startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        _newXPos = Mathf.Repeat(Time.time * -_moveSpeed, _offset);

        transform.position = Vector2.right * _newXPos;
    }
}
