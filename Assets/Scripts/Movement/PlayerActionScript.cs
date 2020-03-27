using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sps.PlayerAction
{

public class PlayerActionScript : MonoBehaviour
{

    public Transform bulletSpawn1;
    public Transform bulletSpawn2;

    public GameObject bullet;

    [SerializeField] private float speedDxy;
    private void Start() 
    {
        speedDxy = 6000f;
    }

    public void Movement(Vector3 speed)
    {
        // Tilt(speed);
        // speed *= speedDxy * Time.deltaTime;
        // transform.localPosition = transform.position + speed;
        GetComponent<Rigidbody>().AddForce(speedDxy * speed);
    }

    public void Shoot()
    {
        
        Instantiate(bullet, bulletSpawn1.position, Quaternion.Euler(90,0,0));
        Instantiate(bullet, bulletSpawn2.position, Quaternion.Euler(90,0,0));
    }

    // public void Tilt(Vector3 tiltInfo)
    // {
    //     Vector3 tiltTransform = new Vector3(0,0,0);
    //     tiltTransform.y = -tiltInfo.x;
    //     tiltTransform.x = tiltInfo.y;
        
    //     transform.eulerAngles = tiltTransform * 10;
    // }

}

}