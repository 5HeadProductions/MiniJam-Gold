using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingSpawner : MonoBehaviour
{
    public GameObject fallingPrefab;
    // Start is called before the first frame update
    void FixedUpdate(){
        ObjectPooler.Instance.SpawnFromPool("falling", transform.position, Quaternion.identity);
    }
}
