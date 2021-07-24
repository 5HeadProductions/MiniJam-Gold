using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinWave : MonoBehaviour
{
    public float riseRate;
    Vector2 offset;

    private float _currentY;

    // Update is called once per frame
    void Update()
    {
        

        

        transform.position += new Vector3(transform.position.x, transform.position.y + riseRate, transform.position.z) * Time.deltaTime;

       
    }
}
