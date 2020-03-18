using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sps.PlayerAction;

namespace Sps.PlayerControl
{

public class PlayerController : MonoBehaviour
{
    public Vector3 speed;

    // Update is called once per frame
    void Update()
    {
        speed = new Vector3(0,0,0);

        if(Input.GetKey("up"))
            speed.y += 1;
        if(Input.GetKey("down"))
            speed.y -= 1;
        if(Input.GetKey("right"))
            speed.x += 1;
        if(Input.GetKey("left"))
            speed.x -= 1;

        if(Input.GetKeyDown("z"))
            GetComponent<PlayerActionScript>().Shoot();
        
        GetComponent<PlayerActionScript>().Movement(speed);
    }
}
}
