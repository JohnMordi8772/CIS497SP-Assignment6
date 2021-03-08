/* 
 * John Mordi
 * EnemyFactory.cs
 * Assignment #6
 * manages the creation of enemy units
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    public GameObject[] entities;
    public int toInstantiate = 0;

    public GameObject CreateEntity()
    {
        GameObject obj;
        if (toInstantiate == 0)
        {
            obj = entities[0];
            if (obj.GetComponent<Entity>() != null)
                DestroyImmediate(obj.GetComponent<Entity>(), true);
            obj.AddComponent<EnemyDog>();
        }
        else if (toInstantiate == 1)
        {
            obj = entities[1];
            if (obj.GetComponent<Entity>() != null)
                DestroyImmediate(obj.GetComponent<Entity>(), true);
            obj.AddComponent<EnemySoldier>();
        }
        else
        {
            obj = entities[2];
            if (obj.GetComponent<Entity>() != null)
                DestroyImmediate(obj.GetComponent<Entity>(), true);
            obj.AddComponent<EnemyBlob>();
        }
        return obj;
    }

    public void DogChoice()
    {
        toInstantiate = 0;
    }

    public void SoldierChoice()
    {
        toInstantiate = 1;
    }

    public void BlobChoice()
    {
        toInstantiate = 2;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
