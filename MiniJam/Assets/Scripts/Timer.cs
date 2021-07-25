using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    private float timerVal = 60;
    public TextMeshProUGUI text;
    private AudioManager instance;
    bool ten = false;
    void Start(){
        instance = GameObject.Find("AudioManager").GetComponent<AudioManager>();
    }
    // Update is called once per frame
    void Update()
    {
        if(timerVal > 0)timerVal -= Time.deltaTime;
        else timerVal = 0;
        if(timerVal < 0) timerVal = 0;

//float minutes = Mathf.FloorToInt(timerVal/60);
        float seconds = Mathf.FloorToInt(timerVal % 60);  
        UpdateCounter(seconds);      
    }

    public void UpdateCounter(float seconds){
        switch(seconds){
            case 0:
                    if(ten == false){
                    text.fontSize = 160;         
                    text.text = seconds.ToString("0");
                    instance.Play("0");
                    }
                    ten = true;
                break;
            case 1: 
                    if(ten == true){
                    text.fontSize = 160;
                    text.text = seconds.ToString("0");
                    instance.Play("1");
                    }
                    ten = false;
                break;
            case 2: 
                    if(ten == false){
                    text.fontSize = 150;
                    text.text = seconds.ToString("0");
                    instance.Play("2");
                    }
                    ten = true;
                break;
            case 3:
                    if(ten == true){
                    text.text = seconds.ToString("0");
                    instance.Play("3");
                    text.fontSize = 140;
                    }
                    ten = false;
                break;
            case 4: 
                    if(ten == false){
                    text.fontSize = 130;
                    text.text = seconds.ToString("0");
                    instance.Play("4");
                    }
                    ten = true;
                break;
            case 5: 
                    if(ten == true){
                    text.fontSize = 110;
                    text.text = seconds.ToString("0");
                    instance.Play("5");
                    }
                    ten = false;
                break;
            case 6:
                    if(ten == false){
                    text.fontSize = 100;
                    text.text = seconds.ToString("0");
                    instance.Play("6");
                    }
                    ten = true;
                break;
            case 7: 
                    if(ten == true){
                    text.fontSize = 90;
                    text.text = seconds.ToString("0");
                    instance.Play("7");
                    }
                    ten = false;
                break;
            case 8: 
                    if(ten == false){
                    text.fontSize = 80;
                    text.text = seconds.ToString("0");
                    instance.Play("8");
                    }
                    ten = true;
                break;
            case 9: 
                    if(ten == true){
                    text.fontSize = 70;
                    text.text = seconds.ToString("0");
                    instance.Play("9");
                    }
                    ten = false;
                break;
            case 10:
                    if(ten == false){
                    text.fontSize = 60;
                    text.color = Color.red;
                    text.text = seconds.ToString("0");
                    instance.Play("10");
                    }
                    ten = true;
                    
                break;
            default : 
                    text.fontSize = 50;
                    text.text = seconds.ToString("0");
                    
                break;
        }
    }
}
