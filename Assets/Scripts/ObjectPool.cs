using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : SingletonTemplate<ObjectPool>
{
    

    [SerializeField]
    private GameObject objectPrefab;
    [SerializeField]
    private int initialPoolSize;

    private List<GameObject> pool;

    private void Awake()
    {
        pool = new List<GameObject>();

        for (int i = 0; i < initialPoolSize; i++)
        {
            GameObject obj = Instantiate(objectPrefab);
            obj.SetActive(false);
            pool.Add(obj);
        }
    }

    public GameObject GetObject()
    {
        foreach (GameObject obj in pool)
        {
            if (!obj.activeInHierarchy)
            {
                obj.SetActive(true);
                //obj.GetComponent<Bullet>().Init(dir);
                return obj;
            }
        }

        GameObject newObj = Instantiate(objectPrefab);
        pool.Add(newObj);
        return newObj;
    }

    public void ReturnObject(GameObject obj)
    {
        obj.SetActive(false);
    }
}
