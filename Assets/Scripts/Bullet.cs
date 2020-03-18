using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0,0,100);
    }
    
    private void OnCollisionEnter(Collision colided) 
    {
        Destroy(colided.collider.gameObject);
        Destroy(this.gameObject);
      
    }
    
}
