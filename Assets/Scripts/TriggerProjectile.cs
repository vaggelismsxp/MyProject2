using System;
using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{

    [SerializeField] GameObject[] projectiles = new GameObject[0];
    private Boolean isDone;

    private void Start()
    {
        isDone = false;
        foreach (GameObject p in projectiles) {p.SetActive(false);} //this can be done by adding a function Awake into FlyAtPlayer with the line gameObject.SetActive(false);
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !isDone) 
        {
            foreach(GameObject projectile in projectiles) 
            {
                projectile.SetActive(true);
            }
            isDone = true;
        }
    }






}
