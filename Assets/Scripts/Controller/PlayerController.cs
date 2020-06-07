using UnityEngine;
using Sps.PlayerAction;
using Sps.Core;

namespace Sps.PlayerControl
{

public class PlayerController : MonoBehaviour
{
    public Vector3 speed;
    public static GameObject player;

    private void Start() {
        player = this.gameObject;
    }

    // Update is called once per frame
    private void Update() {
        if(Input.GetKeyDown("space"))
        {
            GetComponent<PlayerActionScript>().Shoot();
            Debug.Log("Space");
        }
    }
    void FixedUpdate()
    {
        speed = new Vector3(0,0,0);

        if(Input.GetKey("w"))
            speed.y += 1;
        if(Input.GetKey("s"))
            speed.y -= 1;
        if(Input.GetKey("d"))
            speed.x += 1;
        if(Input.GetKey("a"))
            speed.x -= 1;
        GetComponent<PlayerActionScript>().Movement(speed);
    }

    public void GetHit(float damage){
        Debug.Log(damage+" damage");
    }
}
}
