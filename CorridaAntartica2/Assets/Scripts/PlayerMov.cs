using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    private Transform _playerTransform;
    private GetTouchScreen _getTouch;

    [Header("Top and bottons positions")]
    [SerializeField] Transform _topPosition;
    [SerializeField] Transform _bottonPosition;

    [Header("Lerp/Launch")]
    [SerializeField] private float _speed;


   public bool OnTop, OnBotton;

    [HideInInspector] public Rigidbody2D Rigidbody2D;
    // How much to smooth out the movement
    [HideInInspector]
    [Range(0, .3f)] [SerializeField] private float _movementSmoothing = .05f;
    private Vector3 m_Velocity = Vector3.zero;

    [SerializeField]private Animator _anim;
    private void Start()
    {
        _playerTransform = transform;
        _getTouch = this.GetComponent<GetTouchScreen>();
        Rigidbody2D = this.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //Debug.Log("deltaTime"+Time.deltaTime);
        //Debug.Log("time"+Time.time);

        if (_getTouch.Pressing )
        {
             TopPos();
        }
        else if (!_getTouch.Pressing )
        {
            BottonPos();
        }

        if(!_getTouch.Pressing && !OnBotton)
        {
            _anim.SetTrigger("Descendo");
        }
        if(_getTouch.Pressing && !OnTop)
        {
            _anim.SetTrigger("Subindo");
        }
    }

    public void Move(float x)
    {
        // Move the character by finding the target velocity
        Vector3 targetVelocity = new Vector2(Rigidbody2D.velocity.x, x * 10f);
        // And then smoothing it out and applying it to the character
        Rigidbody2D.velocity = Vector3.SmoothDamp(Rigidbody2D.velocity, targetVelocity, ref m_Velocity, _movementSmoothing);
    }

    public void TopPos()
    {
        _playerTransform.position = new Vector3(_playerTransform.position.x, Mathf.Lerp(_playerTransform.position.y, _topPosition.position.y, Time.deltaTime * _speed/2), 0);

    }
    public void BottonPos()
    {
      
        _playerTransform.position = new Vector3(_playerTransform.position.x, Mathf.Lerp(_playerTransform.position.y, _bottonPosition.position.y, Time.deltaTime * _speed / 2), 0);
    }

    public void AnimBotton(bool x)
    {
        _anim.SetBool("OnBotton", x);
        _anim.ResetTrigger("Descendo");
    }
    public void AnimTop(bool x)
    {
        _anim.SetBool("OnTop", x);
        _anim.ResetTrigger("Subindo");
    }
}
