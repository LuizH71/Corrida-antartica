using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GetTouchScreen : MonoBehaviour
{
    public bool Pressing;
    private void Update()
    {
        TargetMovement();
    }
    private void TargetMovement()//Faz o movimento da sinaliza��o aonde a boia vai cair
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    Pressing = true;
                    break;
                case TouchPhase.Ended:// Caso solte da tela ou n�o faz nada em caso de estar em cima da terra ou solta a boia caso esteja em cima da �gua
                    Pressing = false;
                    break;


            }
        }
    }
}
