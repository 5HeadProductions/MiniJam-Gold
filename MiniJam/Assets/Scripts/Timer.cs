using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    private float timerVal = 60;
    public TextMeshProUGUI text;

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
            case 0: text.fontSize = 180;         
                    text.text = seconds.ToString("0");
                break;
            case 1: text.fontSize = 160;
                    text.text = seconds.ToString("0");
                break;
            case 2: text.fontSize = 150;
                    text.text = seconds.ToString("0");
                break;
            case 3: text.fontSize = 140;
                    text.text = seconds.ToString("0");
                break;
            case 4: text.fontSize = 130;
                    text.text = seconds.ToString("0");
                break;
            case 5: text.fontSize = 110;
                    text.text = seconds.ToString("0");
                break;
            case 6: text.fontSize = 100;
                    text.text = seconds.ToString("0");
                break;
            case 7: text.fontSize = 90;
                    text.text = seconds.ToString("0");
                break;
            case 8: text.fontSize = 80;
                    text.text = seconds.ToString("0");
                break;
            case 9: text.fontSize = 70;
                    text.text = seconds.ToString("0");
                break;
            case 10: text.fontSize = 60;
                    text.color = Color.red;
                    text.text = seconds.ToString("0");
                break;
            default : 
                    text.fontSize = 50;
                    text.text = seconds.ToString("0");
                break;
        }
    }
}
