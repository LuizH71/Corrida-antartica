using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class SpawnPoint : MonoBehaviour
{

    [Tooltip("projectile force")]
    [SerializeField] private float _muzzleForce = 700f;

    [Tooltip("SpawnPoint")]
    [SerializeField] private List<Transform> _muzzlePosition;

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
                int i = Random.Range(0, 2);
                bulletObject.transform.SetPositionAndRotation(_muzzlePosition[i].position, _muzzlePosition[i].rotation);
                bulletObject.SetActive(true);
                StartCoroutine(bulletObject.GetComponent<ObstaculoMov>().ReturnToPool());
            }
           
            //bulletObject.Deactive();
            _nextTimeToShoot = Time.time + _cooldownWindow;
        }
    }
  
}
