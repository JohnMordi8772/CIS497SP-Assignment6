/* 
 * John Mordi
 * EnemyBlob.cs
 * Assignment #6
 * necessary stats and functions for a enemy blob unit
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBlob : Entity
{
    string title = "Enemy Blob";
    string weapon = "Goo";
    int dmg = 50;
    int cost = 30;
    // Start is called before the first frame update
    void Awake()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
    }

    public override int GetCost()
    {
        return cost;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override string GetTitle()
    {
        return title;
    }

    public override string GetWeapon()
    {
        return weapon;
    }

    public override int GetDmg()
    {
        return dmg;
    }
}
