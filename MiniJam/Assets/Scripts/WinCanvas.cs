using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCanvas : MonoBehaviour
{
    public GameObject winCanvas;
    
    public GameObject camera;
    public void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag == "Player"){
        winCanvas.SetActive(true);
        camera.GetComponent<AudioListener>().enabled = false;
        
        }
    }
}
