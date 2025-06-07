using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class GameController : MonoBehaviour
{
    public TextMeshProUGUI TextLivesCount;
    public TextMeshProUGUI TextApplesCount;
    
    public Inventory inventory;
    public PlayerStats stats;
    
    public void Update()
    {
        TextLivesCount.text = stats.GetHealth().ToString();
        TextApplesCount.text = inventory.GetAppleCount().ToString();
    }
}
