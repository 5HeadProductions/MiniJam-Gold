using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingCoin : MonoBehaviour, IPooledObject
{

    public float sideForce = -7f;
    public float upforce = .1f;
    public GameObject spawner;
    // Start is called before the first frame update
    public void OnObjectSpawn()
    {
        spawner = GameObject.Find("FallingSpawner");
        float xForce = Random.Range(-sideForce, sideForce);
        float yForce = Random.Range(upforce/2f, upforce);
        Debug.Log(xForce.ToString());
        Vector2 force = new Vector2 (xForce, yForce);

        GetComponent<Rigidbody2D>().velocity = force;

    }
    
}
