using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool SharedInstance;
    public List<GameObject> pooledObjects;
    [Space]
    public GameObject objectToPoolPredador;
    public GameObject objectToPoolFood;
    public GameObject objectToPoolPlastic;

    public int amountToPool;

    void Awake()
    {
        SharedInstance = this;
    }

    void Start()
    {
        InstantiatePrefabsOfPool();
    }

    public GameObject GetPooledObject()
    {
        int i = Random.Range(0, pooledObjects.Count);
        if (!pooledObjects[i].activeInHierarchy)
        {
            return pooledObjects[i];
        }
        else
        {
            return null;
        }
    }


    private void InstantiatePrefabsOfPool()
    {
        pooledObjects = new List<GameObject>();
        GameObject tmp;
        for (int i = 0; i < amountToPool; i++)
        {
            tmp = Instantiate(objectToPoolPredador);
            tmp.SetActive(false);
            pooledObjects.Add(tmp);
        }

        GameObject tmp2;
        for (int i = 0; i < amountToPool; i++)
        {
            tmp2 = Instantiate(objectToPoolFood);
            tmp2.SetActive(false);
            pooledObjects.Add(tmp2);
        }

        GameObject tmp3;
        for (int i = 0; i < amountToPool; i++)
        {
            tmp3 = Instantiate(objectToPoolPlastic);
            tmp3.SetActive(false);
            pooledObjects.Add(tmp3);
        }
    }
}
