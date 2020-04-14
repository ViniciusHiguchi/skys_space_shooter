using UnityEngine;
using Sps.PlayerAction;

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
        if(Input.GetKeyDown("z"))
        {
            GetComponent<PlayerActionScript>().Shoot();
            Debug.Log("z");
        }
    }
    void FixedUpdate()
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
        GetComponent<PlayerActionScript>().Movement(speed);
    }
}
}
