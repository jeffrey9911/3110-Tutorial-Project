using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{

    public static ObjectPooler instance;

    public List<Pool> pools;

    Queue<GameObject> objectPool;

    public Dictionary<string, Queue<GameObject>> objectPoolDict;

    private void Awake()
    {
        if (!instance)
            instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        objectPoolDict = new Dictionary<string, Queue<GameObject>>();

        foreach(Pool pool in pools)
        {
            objectPool = new Queue<GameObject>();

            for(int i = 0; i < pool._size; i++)
            {
                GameObject obj = Instantiate(pool._prefab);
                obj.SetActive(false);
                objectPool.Enqueue(obj);
            }

            objectPoolDict.Add(pool._tag, objectPool);
        }
    }

    public GameObject SpawnFromPool(string tag, Vector3 pos, Quaternion rot)
    {
        if(!objectPoolDict.ContainsKey(tag))
        {
            Debug.LogWarning(tag + "Pool Doesn't Exist");
            return null;
        }

        GameObject objToSpawn = objectPoolDict[tag].Dequeue();

        objToSpawn.SetActive(true);
        objToSpawn.transform.position = pos;
        objToSpawn.transform.rotation = rot;

        objectPoolDict[tag].Enqueue(objToSpawn);

        return objToSpawn;
    }
}
