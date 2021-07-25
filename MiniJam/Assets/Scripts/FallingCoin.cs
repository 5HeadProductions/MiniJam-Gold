using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingCoin : MonoBehaviour
{
    public PlayerController pc;
    
    void Start(){
        pc = GameObject.Find("Player1").GetComponent<PlayerController>();
    }
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
        if(col.gameObject.tag == "Player"){
        pc.handRelease();
        }
    }
    
}
