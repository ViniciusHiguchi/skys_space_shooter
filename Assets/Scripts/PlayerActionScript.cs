using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sps.PlayerAction
{

public class PlayerActionScript : MonoBehaviour
{

    [SerializeField] private float speedDxy = 5f;

    public void Movement(Vector3 speed)
    {
        Tilt(speed);
        speed *= speedDxy * Time.deltaTime;
        transform.localPosition = transform.position + speed;
    }

    public void Tilt(Vector3 tiltInfo)
    {
        Vector3 tiltTransform = new Vector3(0,0,0);
        tiltTransform.y = -tiltInfo.x;
        tiltTransform.x = tiltInfo.y;

        transform.eulerAngles = tiltTransform * 5;
    }

}

}