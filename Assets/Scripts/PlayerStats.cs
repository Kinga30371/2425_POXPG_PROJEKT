using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private float maxHealth = 100;
    [SerializeField] private float health = 100;
    private Animator anim;

    public bool isDead = false;

    public float GetHealth()
    {
        return health;
    }
    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void TakeDamage(float damage)
    {
        damage = Mathf.Abs(damage); // if damage < 0 ==> damage * -1
        health = Mathf.Clamp(health - damage, 0, maxHealth);
        //if health - damage > maxHealth ==> maxHealth
        //if health - damage < 0 ==> 0
        CheckHealth();
    }

    public void Heal(float heal)
    {
        heal = Mathf.Abs(heal);
        health = Mathf.Clamp(health + heal, 0, maxHealth);
        CheckHealth(); 
    }

    public void CheckHealth()
    {
        if (health == 0)
        {
            anim.SetTrigger("isDead");
            isDead = true;
        }
    }

}
