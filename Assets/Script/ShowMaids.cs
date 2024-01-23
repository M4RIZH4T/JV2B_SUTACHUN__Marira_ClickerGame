using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//using Random = UnityEngine.Random;

public class ShowMaids : MonoBehaviour
{
    //public SpriteRenderer spriteRenderer;
    public Maid maid;

    public TMP_Text nameMaid;
    public TMP_Text healthMaid;
    public Image spriteMaid;

    public float previousHP;

    public Maid[] chooseMaid; //list of all the maids 
    public Maid currentMaid;

    public bool nextMaid = false;

    //public AudioSource cryingMaid; 

    public float score; 
    public TextMeshProUGUI myUIScore;

    //Elements from script Shop 
    public Shop scriptShop; 
    
    
    

    private void Awake()
    {
        //randomly choose a maid in our list 
        ShowMaid(chooseMaid[Random.Range(0,6)]); 
        //ShowMaid(chooseMaid[6]);
    }

    public void ShowMaid(Maid maid) 
    {
        currentMaid = maid; 
        previousHP = currentMaid.maidLife;
        nameMaid.text = currentMaid.maidName;
        healthMaid.text = currentMaid.maidLife.ToString();
        spriteMaid.sprite = currentMaid.maidSprite;
    }

  

    private void Update()
    {
        //replace the previous maid by a new one 
        if (currentMaid.maidLife <= 0)
        {
            currentMaid.maidLife = previousHP;
            ShowMaid(chooseMaid[Random.Range(0, 6)]);
            nextMaid = true;
            scriptShop.catEarsObject.gameObject.SetActive(false);
            scriptShop.necklaceObject.gameObject.SetActive(false);
            scriptShop.wigObject.gameObject.SetActive(false);
            scriptShop.ribbonObject.gameObject.SetActive(false);

            //cryingMaid.Play(); 

            score += Random.Range(1, 250); 

        }

       
        
        healthMaid.text = "Mental health : " + currentMaid.maidLife.ToString();
        myUIScore.text = "Score : " + score; 
    }
}
