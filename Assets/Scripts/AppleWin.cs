using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(Collider2D))]
public class Winner : MonoBehaviour
{
    public int applesToWin = 15;
    public Inventory inventory;
    public TextMeshProUGUI winText;

    private void Start()
    {
        winText.text = "";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && inventory.GetAppleCount() >= applesToWin)
        {
            winText.text = "You completed Apple Hunt!";
        }
    }

}