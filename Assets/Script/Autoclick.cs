using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Autoclick : MonoBehaviour
{
    //UI 
    public Button buttonAutoClick;
    public TextMeshProUGUI myUIPriceAutoClick;
    public TextMeshProUGUI myUILevelAutoClick;

    public float powerClick = 1;
    public float powerAutoClick = 0;
    public float priceAutoClick = 2; //starting price for the autoclicker
    public float levelAutoClick = 0;

    public bool isAutoClick = false;
    public float timeClick = 0.5f; //time 

    //Elements from script Click
    public Click scriptClick;
    public Click coin;
    public Click myUICoin;
    public Click numberOfClick;

    // Start is called before the first frame update
    void Start()
    {
        buttonAutoClick.onClick.AddListener(AutoClickCondition);

    }

    private void Update()
    {
        myUIPriceAutoClick.text = "" + priceAutoClick;
        myUILevelAutoClick.text = "LEVEL " + levelAutoClick;
    }


    void AutoClickCondition()
    {
        //Debug.Log("Autoclick clicked"); 
        if (scriptClick.coin >= priceAutoClick)
        {
            StartCoroutine(AutoClicker());
            scriptClick.coin -= priceAutoClick;
            powerAutoClick += 1;
            //Debug.Log("Autoclick ok ! power is " + powerAutoClick);

            isAutoClick = true;
            priceAutoClick += Random.Range(1, 4);
            levelAutoClick += 1;
        }
    }

    private IEnumerator AutoClicker()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeClick);
            //Debug.Log("AUTOCLICKER !");
            scriptClick.numberOfClick += (1 * powerAutoClick);


            if (scriptClick.numberOfClick >= 5)
            {
                scriptClick.numberOfClick -= 5;
                scriptClick.coin += 1;
                //Debug.Log(coin);


            }
        }
    }

}
    
    