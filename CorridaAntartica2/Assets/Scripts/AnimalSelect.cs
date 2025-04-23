using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSelect : MonoBehaviour
{
    [Tooltip("1= papua. 2= Adelia, 3= Imperador")]
    [SerializeField] floatVariable animal;

    [SerializeField] private GameObject _papua;
    [SerializeField] private GameObject _adelia;
    [SerializeField] private GameObject _imperador;


    private void Start()
    {
        switch (animal.Value)
        {
            case 1:
                _papua.SetActive(true);
                _adelia.SetActive(false);
                _imperador.SetActive(false);
                break;
            case 2:
                _papua.SetActive(false);
                _adelia.SetActive(true);
                _imperador.SetActive(false);
                break;
            case 3:
                _papua.SetActive(false);
                _adelia.SetActive(false);
                _imperador.SetActive(true);
                break;
        }
    }
}
