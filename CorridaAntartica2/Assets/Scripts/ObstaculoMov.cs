using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoMov : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;

    private void FixedUpdate()
    {
        _rb.velocity = new Vector3(-10, 0, 0);
    }

    public IEnumerator ReturnToPool()
    {
        yield return new WaitForSeconds(2.5f);
        gameObject.SetActive(false);
        StopCoroutine(ReturnToPool());
    }
}
