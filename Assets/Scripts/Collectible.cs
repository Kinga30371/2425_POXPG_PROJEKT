using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Collectible : MonoBehaviour
{
    public float apples = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (!collision.gameObject.CompareTag("Player"))
        {
            return;
        }

        //TODO Send info to Player
        //TODO Check if inventory component exists

        Inventory inventory = collision.gameObject.GetComponent<Inventory>();

        if (inventory == null)
        {
            return;
        }

        inventory.Amount(apples);

        Destroy(gameObject);
    }

}
