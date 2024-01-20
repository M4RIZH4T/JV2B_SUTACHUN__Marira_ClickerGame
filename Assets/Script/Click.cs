using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.Events; 

public class Click : MonoBehaviour
{

    public Button buttonClick;
    
    
    public TextMeshProUGUI myUI;
    public TextMeshProUGUI myUICoin;

    public float coin = 0; 
    public float numberOfClick = 0;

    public float powerClick = 1;
    public float powerAutoClick = 0;

    public bool isAutoClick;
    public float timeClick = 1;

    public Autoclick Autoclicker; 


    // Start is called before the first frame update
    void Start()
    {
        buttonClick.onClick.AddListener(Clicker);

    }


    void Clicker()
    {
            //Debug.Log("button clicked !");
            numberOfClick += 1;
            myUI.text = "Number of clicks : " + numberOfClick;
            
            //every 5 clicks = 1 coin 
            if (numberOfClick == 5)
            {
                numberOfClick -= 5;
                coin += 1;
                //Debug.Log(coin);
                myUICoin.text = " " + coin; 
                
            }
    }

    
    void Update()
    {
        myUICoin.text = " " + coin;
        myUI.text = "Number of clicks : " + numberOfClick; //testtest
    }

}
