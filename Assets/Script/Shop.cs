using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Shop : MonoBehaviour
{
    public GameObject catEarsObject;
    public GameObject necklaceObject;
    public GameObject wigObject;
    public GameObject ribbonObject;

    public GameObject fondShop; //shop

    public Button catEarButton;
    public Button necklaceButton;
    public Button wigButton;
    public Button ribbonButton;

    public float priceCatEars = 20;
    public float priceNecklace = 30;
    public float priceWig = 50;
    public float priceRibbon = 40;

    public bool owningCatEars = false;
    public bool owningNecklace = false; 
    public bool owningWig = false;  
    public bool owningRibbon = false;


    

    //Elements from script Click
    public Click scriptClick;
    public Click coin;
    public Click myUICoin;

    //Elements from script LoveLevel
    public LoveLevel scriptLoveLevel;
    public LoveLevel lovePowerLevel;

    //Elements from scrip Showmaids 
    public ShowMaids scriptShowMaids;
    public ShowMaids nextMaid; 

    // Start is called before the first frame update
    void Start()
    {
        //hide the objects when game starts 
        catEarsObject.gameObject.SetActive(false);
        necklaceObject.gameObject.SetActive(false);
        wigObject.gameObject.SetActive(false);
        ribbonObject.gameObject.SetActive(false);

        catEarButton.onClick.AddListener(CatEarOwned);
        necklaceButton.onClick.AddListener(NecklaceOwned);
        wigButton.onClick.AddListener(WigOwned);
        ribbonButton.onClick.AddListener(RibbonOwned);

        //hide the shop 
        fondShop.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        RemoveObjects();
        
    }

    public void RemoveObjects()
    {
        if (scriptShowMaids.nextMaid == true)
        {
            owningCatEars = false;
            owningNecklace = false;
            owningRibbon = false;
            owningWig = false;

           
        }

        
        
    }

    public void CatEarOwned()
    {
        if (owningCatEars == false)
        {
            if (scriptClick.coin >= priceCatEars)
            {
                //Debug.Log("Oreilles possédées"); 
                catEarsObject.gameObject.SetActive(true);
                scriptClick.coin -= priceCatEars; 
                owningCatEars = true;
                scriptLoveLevel.lovePowerLevel *= 3f;
            }
        }
        
    }

    public void NecklaceOwned()
    {
        if (owningNecklace == false)
        {
            if (scriptClick.coin >= priceNecklace)
            {
                //Debug.Log("Collier possédé");
                necklaceObject.gameObject.SetActive(true);
                scriptClick.coin -= priceNecklace; 
                owningNecklace = true;
                scriptLoveLevel.lovePowerLevel *= 4f;
            }
        }
    }

    public void WigOwned()
    {
        

        if (owningWig == false)
        {
            if (scriptClick.coin >= priceWig)
            {
                //Debug.Log("Perruque possédée");
                wigObject.gameObject.SetActive(true);
                scriptClick.coin -= priceWig; 
                owningWig = true;
                scriptLoveLevel.lovePowerLevel *= 6f;
            }
        }
    }
    public void RibbonOwned()
    {
        if (owningRibbon == false)
        {
            if (scriptClick.coin >= priceRibbon)
            {
                //Debug.Log("Ruban possédée !!");
                ribbonObject.gameObject.SetActive(true);
                scriptClick.coin -= priceRibbon; 
                owningRibbon= true;
                scriptLoveLevel.lovePowerLevel *= 5f;
            }
        }
    }
}


