using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class SpawnPoint : MonoBehaviour
{

    [Tooltip("projectile force")]
    [SerializeField] private float _muzzleForce = 700f;

    [Tooltip("SpawnPoint")]
    [SerializeField] private Transform _muzzlePositionTop;
    [SerializeField] private Transform _muzzlePositionBotton;

    [Tooltip("Time between spawns")]
    [SerializeField] private float _cooldownWindow = 0.1f;


    private float _nextTimeToShoot;

    private void Update()
    {
        if( Time.time > _nextTimeToShoot )
        {

            GameObject bulletObject = ObjectPool.SharedInstance.GetPooledObject();
            if (bulletObject != null)
            {
                SpawnPosition currentType = bulletObject.GetComponent<ObstaculoMov>().type;
                switch (currentType)
                {
                    case SpawnPosition.Up:
                        bulletObject.transform.SetPositionAndRotation(_muzzlePositionTop.position, _muzzlePositionTop.rotation);
                        break;

                    case SpawnPosition.Botton:
                        bulletObject.transform.SetPositionAndRotation(_muzzlePositionBotton.position, _muzzlePositionBotton.rotation);
                        break;

                }
                bulletObject.SetActive(true);
                StartCoroutine(bulletObject.GetComponent<ObstaculoMov>().ReturnToPool());
            }
           
            //bulletObject.Deactive();
            _nextTimeToShoot = Time.time + _cooldownWindow;
        }
    }
  
}
