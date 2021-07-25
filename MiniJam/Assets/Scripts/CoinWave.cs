using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinWave : MonoBehaviour
{
    public float riseRate;
    Vector2 offset;

    public GameObject deathCanvas;

    // Update is called once per frame
    void Update()
    {
        

        

  transform.position += new Vector3(transform.position.x, riseRate, transform.position.z) * Time.deltaTime;

       
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Player"){
        Destroy(other.gameObject);
        deathCanvas.SetActive(true);
        }

    }
}
