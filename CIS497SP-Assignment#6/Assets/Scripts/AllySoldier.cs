/* 
 * John Mordi
 * AllySoldier.cs
 * Assignment #6
 * necessary stats and functions for a ally soldier unit
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllySoldier : Entity
{
    string title = "Ally Soldier";
    string weapon = "Gun";
    int dmg = 30;
    int cost = 20;
    // Start is called before the first frame update
    void Awake()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
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
