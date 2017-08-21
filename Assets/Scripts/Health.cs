﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;



public class Health : MonoBehaviour
{
    //add more stuff to the array from the inspector if you want more hearts
    public int startingHealth = 3;
    public int currentHealth;
    public GameObject[] heartsLeft;


    void Start()
    {
        //Give the player 3 hearts
        currentHealth = startingHealth;
        for (int i = 0; i < currentHealth; i++)
        {
            heartsLeft[i].GetComponent<SpriteRenderer>().enabled = true;
        }
    }


    void Update()
    {

    }

    //Deletes hearts based on amount of health lost
    public void ChangeHealth(int amount)
    {
        currentHealth += amount;

        for (int i = startingHealth - 1; i > currentHealth - 1; i--)
        {
            GameObject heartObj = heartsLeft[i];
            heartObj.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}