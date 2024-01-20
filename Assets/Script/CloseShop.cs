using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CloseShop : MonoBehaviour
{

    public Button buttonExitShop;

    //Elements from script Shop
    public Shop scriptShop;
    public Shop fondShop;

    // Start is called before the first frame update
    void Start()
    {
        buttonExitShop.onClick.AddListener(ClickToCloseShop);
    }

 

    public void ClickToCloseShop()
    {
        scriptShop.fondShop.SetActive(false);
    }
}
