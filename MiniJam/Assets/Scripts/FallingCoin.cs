using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FallingCoin : MonoBehaviour
{
    public PlayerController pc;
    
    void Start(){
        if(SceneManager.GetActiveScene().name == "PlayScene")
        {
            pc = GameObject.Find("Player1").GetComponent<PlayerController>();
        }
    }
    public void OnEnable()
    {
        Invoke("Disable", 3f);
    }

    public void Disable()
    {
        if(pc != null){
        GameObject.Find("AudioManager").GetComponent<AudioManager>().Play("Coin Hit");
        gameObject.SetActive(false);
        }
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
