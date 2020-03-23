using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sps.Enemy;

public class AimRay : MonoBehaviour
{
    private void OnTriggerStay(Collider colided) 
    {
        EnemyManager enemy = colided.transform.GetComponent<EnemyManager>();
        if(enemy != null)
        GetComponent<Renderer>().material.color = new Color(1,0,0);
        if(enemy == null)
        GetComponent<Renderer>().material.color = new Color(0,1,0);
    }

    private void FixedUpdate() 
    {
        GetComponent<Renderer>().material.color = new Color(0,1,0);
    }
    // private void OnTriggerExit() {
    //     GetComponent<Renderer>().material.color = new Color(0,1,0);
    // }
}
