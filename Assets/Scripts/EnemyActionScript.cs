using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyActionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       //GetComponent<Rigidbody>().velocity = (transform.forward * 50);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * 1000, ForceMode.Force);
    }
}
