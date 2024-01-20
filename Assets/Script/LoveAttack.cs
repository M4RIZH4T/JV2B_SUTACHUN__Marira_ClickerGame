using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor.UIElements;
using Unity.VisualScripting;

public class LoveAttack : MonoBehaviour
{
    public float loveAttackValue = 0; //valeur de départ de l'attaque 

    public Button boutonLoveAttack;
    public TextMeshProUGUI myUIAttackValue;

    public ParticleSystem heartParticles;
    public GameObject HeartScreen;
    public AudioSource loveAttackSoundEffect; 

    

    //Elements from script LoveLevel 
    public LoveLevel scriptLoveLevel;
    public LoveLevel lovePowerLevel;
    public LoveLevel myUILevel;

    

    //Elements from script ShowMaids 
    public ShowMaids scriptShowMaids;
    public ShowMaids currentMaid; 
    

    
    void Start()
    {
        boutonLoveAttack.onClick.AddListener(LoveAttackClick);


    }
    
    void LoveAttackClick()
    {
        

        if (scriptShowMaids.currentMaid.maidLife >= 1)
        {
            loveAttackValue = scriptLoveLevel.lovePowerLevel;
            scriptShowMaids.currentMaid.maidLife -= loveAttackValue;
            scriptLoveLevel.lovePowerLevel -= loveAttackValue;
            Debug.Log("la serveuse a pris des dégats !!");

            heartParticles.Play();


        }

        
    }
    
    void Update()
    {
        
        
        scriptLoveLevel.myUILevel.text = "Love power : " + scriptLoveLevel.lovePowerLevel;
        myUIAttackValue.text = "Send luuv  " + (scriptLoveLevel.lovePowerLevel); 

        if (heartParticles.isPlaying)
        {
            HeartScreen.gameObject.SetActive(true);
            loveAttackSoundEffect.Play();
        }
        
        else
        {
            HeartScreen.gameObject.SetActive(false);
            
        }
    }

    
}   
    
