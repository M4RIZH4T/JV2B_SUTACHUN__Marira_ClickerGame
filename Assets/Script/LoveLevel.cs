using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoveLevel : MonoBehaviour
{
    public Button buttonLevelUp;

    public float levelUpPrice = 5;
    public float lovePowerLevel = 0;

    public AudioSource levelUpSound; 
   
    public TextMeshProUGUI myUILevel;
    public TextMeshProUGUI myUIPriceLevelUp;

    //Elements from script Click
    public Click scriptClick;
    public Click coin;
    public Click myUICoin;

    // Start is called before the first frame update
    void Start()
    {
        buttonLevelUp.onClick.AddListener(LevelUp);
    }

    // Update is called once per frame
    void Update()
    {
        myUILevel.text = "Love power : " + lovePowerLevel;
        myUIPriceLevelUp.text = "-" + levelUpPrice;
    }

    

    void LevelUp()
    {
        //Debug.Log("not enough !!!");
        if (scriptClick.coin >= levelUpPrice)
        {
            scriptClick.coin -= levelUpPrice; 
            lovePowerLevel += 10;
       
            //Debug.Log("Level up +1 !"); 
            scriptClick.myUICoin.text = " " + scriptClick.coin;
            levelUpPrice += Random.Range(1,5); //the price will increase randomly 

            levelUpSound.Play();

        }
    }
}
