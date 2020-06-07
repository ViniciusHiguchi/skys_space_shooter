using UnityEngine;
using Sps.PlayerControl;

public class Bullet1 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float bulletDamage;

    void Start()
    {
        bulletDamage = 10f;
        GetComponent<Rigidbody>().velocity = transform.up * 200;
    }

    private void FixedUpdate() 
    {
        
    }
    
    private void OnCollisionEnter(Collision colided) 
    {
        PlayerController player = colided.collider.transform.GetComponent<PlayerController>();
        if(player != null){
        player.GetHit(bulletDamage);
        }
        Destroy(this.gameObject);
    }
    
}
