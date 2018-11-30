﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifePickUp : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject begin = GameObject.Find("Player");
            Health callfunction = (Health)begin.GetComponent(typeof(Health));
            callfunction.IncreaseLives();
            Destroy(this.gameObject);
        }
    }
}