using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

[CreateAssetMenu(fileName = "New Maid", menuName = "Maid", order = 0)]
public class Maid : ScriptableObject
{
    // Start is called before the first frame update
    public string maidName;
    public float maidLife;
    public Sprite maidSprite;
}
