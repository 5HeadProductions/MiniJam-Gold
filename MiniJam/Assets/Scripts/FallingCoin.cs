using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingCoin : MonoBehaviour
{
    public void OnEnable()
    {
        Invoke("Disable", 2f);
    }

    public void Disable()
    {
        gameObject.SetActive(false);
    }

    public void OnDisable()
    {
        CancelInvoke();
    }
    public void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag == "Player") Debug.Log("hit");
    }
    
}
