using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OpenShop : MonoBehaviour
{
    public Button buttonDuckBackpack;

    public AudioSource duckSound; 

    //Elements from script Shop
    public Shop scriptShop;
    public Shop fondShop;

    // Start is called before the first frame update
    void Start()
    {
        buttonDuckBackpack.onClick.AddListener(ClickToOpenShop);
    }

    public void ClickToOpenShop()
    {
        scriptShop.fondShop.SetActive(true);
        duckSound.Play();
    }
}
