using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Healer : MonoBehaviour
{
    public float heal = 40;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collisionObject = collision.gameObject;
        HandleGetHealth(collisionObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collisionObject = collision.gameObject;
        HandleGetHealth(collisionObject);
    }

    private void HandleGetHealth(GameObject collisionObject)
    {
        if (!collisionObject.CompareTag("Player"))
        {
            return;
        }

        PlayerStats stats = collisionObject.GetComponent<PlayerStats>();

        if (stats == null)
        {
            return;
        }

        stats.GetHealth(heal);

        Destroy(gameObject);
    }
}

