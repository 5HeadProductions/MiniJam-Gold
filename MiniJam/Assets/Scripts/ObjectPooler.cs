using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{

    public static ObjectPooler Instance;
    public GameObject pooledObject;
    public int size;

    private List<GameObject> pooledObjects;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        pooledObjects = new List<GameObject>();
        for(int i = 0; i < size; i++){
            GameObject obj = Instantiate(pooledObject);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
        
    }
    public GameObject GetPooledObject(){
        for(int i = 0; i < pooledObjects.Count; i++){
            if(!pooledObjects[i].activeInHierarchy){
                return pooledObjects[i];
            }
        }

        return null;
    }

    
}
