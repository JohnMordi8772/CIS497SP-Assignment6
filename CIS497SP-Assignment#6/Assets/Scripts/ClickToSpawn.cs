/* 
 * John Mordi
 * ClickToSpawn.cs
 * Assignment #6
 * manages spawning, costs, and scene resets
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickToSpawn : MonoBehaviour
{
    public EnemyFactory eFactory;
    public AllyFactory aFactory;
    GameObject toSpawn;
    public Text allyCashText, enemyCashText;
    int allyCash = 500, enemyCash = 500;

    // Update is called once per frame
    void Update()
    {
        allyCashText.text = "Ally Cash: $" + allyCash;
        enemyCashText.text = "Enemy Cash: $" + enemyCash;
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(rayOrigin, out hitInfo))
            {
                if (hitInfo.collider.gameObject.tag == "AllyZone")
                {
                    toSpawn = aFactory.CreateEntity();
                    if (toSpawn.GetComponent<Entity>().GetCost() <= allyCash)
                    {
                        Instantiate(toSpawn, hitInfo.point, toSpawn.transform.rotation, null);
                        allyCash -= toSpawn.GetComponent<Entity>().GetCost();
                    }
                }
                else if(hitInfo.collider.gameObject.tag == "EnemyZone")
                {
                    toSpawn = eFactory.CreateEntity();
                    if (toSpawn.GetComponent<Entity>().GetCost() <= enemyCash)
                    {
                        Instantiate(toSpawn, hitInfo.point, toSpawn.transform.rotation, null);
                        enemyCash -= toSpawn.GetComponent<Entity>().GetCost();
                    }
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

