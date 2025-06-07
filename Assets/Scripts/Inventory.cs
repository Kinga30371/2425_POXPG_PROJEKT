using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    //public Number of apples
    [SerializeField] private float appleCount = 0;
    [SerializeField] private float minApples = 0;
    [SerializeField] private float maxApples = 100;


    public float GetAppleCount()
    {
        return appleCount;
    }

    public void Amount(float amount)
    {
        amount = Mathf.Abs(amount);
        appleCount = Mathf.Clamp(appleCount + amount, minApples, maxApples);
        CheckAppleCount();

    }

    public void CheckAppleCount()
    {

    }

}
