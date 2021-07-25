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
        Invoke("Disable", 6f);
    }

    public void Disable()
    {
        GameObject.Find("AudioManager").GetComponent<AudioManager>().Play("Coin Hit");
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
