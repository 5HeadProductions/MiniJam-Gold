using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingSpawner : MonoBehaviour
{
    public GameObject fallingPrefab;
    
    private float timeToFall = 0;
    private float spawnRate = .3f;

    void Update()
    {

        if(Time.time > timeToFall){
            GameObject obj = ObjectPooler.Instance.GetPooledObject();
            if(obj == null) return;

            float xPos = Random.Range(-8f, 8f);
            float zRot = Random.Range(0f, 180f);
            gameObject.transform.position = new Vector2 (xPos, gameObject.transform.position.y);
            obj.transform.position = gameObject.transform.position;
            obj.transform.rotation = gameObject.transform.rotation;
            obj.transform.Rotate(new Vector3(gameObject.transform.rotation.x, gameObject.transform.rotation.y, zRot), Space.Self);
            obj.SetActive(true);

            timeToFall = Time.time + spawnRate;
        }
    }


}
