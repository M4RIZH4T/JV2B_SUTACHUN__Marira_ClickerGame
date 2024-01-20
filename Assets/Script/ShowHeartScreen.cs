using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ShowHeartScreen : MonoBehaviour
{
    public GameObject HeartScreen;

    //Elements from script LoveAttack
    public LoveAttack scriptLoveAttack;
    public LoveAttack heartParticles;


    // Update is called once per frame
    void Update()
    {
        //show hearts while particles are playing 
        if (scriptLoveAttack.heartParticles.isPlaying)  
        {
            HeartScreen.gameObject.SetActive(true);
        }
        else
        {
            HeartScreen.gameObject.SetActive(false);
        }
    }
}
