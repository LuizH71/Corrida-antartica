using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool SharedInstance;
    public List<GameObject> pooledObjects;
    [Space]
    public GameObject objectToPoolOrca;
    public int amountToPoolOrca;
    [Space]
    public GameObject objectToPoolFoca;
    public int amountToPoolFoca;
    [Space]
    public GameObject objectToPoolKrill;
    public int amountToPoolKrill;
    [Space]
    public GameObject objectToPoolLula;
    public int amountToPoolLula;
    [Space]
    public GameObject objectToPoolPeixe;
    public int amountToPoolPeixe;
    [Space]
    public GameObject objectToPoolPlastic;
    public int amountToPoolPlastic;

    

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
        for (int i = 0; i < amountToPoolOrca; i++)
        {
            tmp = Instantiate(objectToPoolOrca);
            tmp.SetActive(false);
            pooledObjects.Add(tmp);
        }

        GameObject tmp2;
        for (int i = 0; i < amountToPoolKrill; i++)
        {
            tmp2 = Instantiate(objectToPoolKrill);
            tmp2.SetActive(false);
            pooledObjects.Add(tmp2);
        }

        GameObject tmp3;
        for (int i = 0; i < amountToPoolLula; i++)
        {
            tmp3 = Instantiate(objectToPoolLula);
            tmp3.SetActive(false);
            pooledObjects.Add(tmp3);
        }

        GameObject tmp4;
        for (int i = 0; i < amountToPoolPeixe; i++)
        {
            tmp4 = Instantiate(objectToPoolPeixe);
            tmp4.SetActive(false);
            pooledObjects.Add(tmp4);
        }

        GameObject tmp5;
        for (int i = 0; i < amountToPoolPlastic; i++)
        {
            tmp5 = Instantiate(objectToPoolPlastic);
            tmp5.SetActive(false);
            pooledObjects.Add(tmp5);
        }

        GameObject tmp6;
        for (int i = 0; i < amountToPoolFoca; i++)
        {
            tmp6 = Instantiate(objectToPoolFoca);
            tmp6.SetActive(false);
            pooledObjects.Add(tmp6);
        }
    }
}
