using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sps.Enemy;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float bulletDamage;

    void Start()
    {
        bulletDamage = 10f;
        GetComponent<Rigidbody>().velocity = new Vector3(0,0,100);
    }

    private void FixedUpdate() 
    {
        
    }
    
    private void OnCollisionEnter(Collision colided) 
    {
        EnemyManager enemy = colided.collider.transform.GetComponent<EnemyManager>();
        if(enemy != null)
        enemy.GetHit(bulletDamage);
        Destroy(this.gameObject);
    }
    
}
