using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sps.Enemy;
using Sps.PlayerControl;

public class AimRay : MonoBehaviour
{
    public GameObject player;
    private void Start() {
        player = PlayerController.player;
    }
    private void OnTriggerStay(Collider colided) 
    {
        EnemyManager enemy = colided.transform.GetComponent<EnemyManager>();
        if(colided != null){
        GetComponent<Renderer>().material.color = new Color(1,0,0);
        float distance = (colided.transform.position.z - player.transform.position.z);
        distance = (distance/75) - 0.05f;
        Debug.Log(distance);
        this.transform.localScale = new Vector3(0.002f,0.002f,distance);
        this.transform.localPosition = new Vector3(0f,0f,(((distance))/2));
        }
        if(colided == null)
        GetComponent<Renderer>().material.color = new Color(0,1,0);
    }

    private void FixedUpdate() 
    {
        this.transform.localScale = new Vector3(0.002f,0.002f,6);
        this.transform.localPosition = new Vector3(0,0,3);
        GetComponent<Renderer>().material.color = new Color(0,1,0);
    }
    // private void OnTriggerExit() {
    //     GetComponent<Renderer>().material.color = new Color(0,1,0);
    // }
}
