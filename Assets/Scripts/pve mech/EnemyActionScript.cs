using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sps.Core;

namespace Sps.Enemy{

    public class EnemyActionScript : MonoBehaviour
    {
        public GameObject player;
        public GameObject bullet;
        public Transform bulletSpawn;
        public Transform bulletSpawn2;
        public Transform thisEnemy;
        public GameObject explosion;
        [SerializeField] bool behind = false;
        // Start is called before the first frame update
        void Start()
        {
            thisEnemy = this.transform;
            player = PlayerControl.PlayerController.player;
        //GetComponent<Rigidbody>().velocity = (transform.forward * 50);
        }

        private void Update() {
            Vector3 magnitude = player.transform.position - this.transform.position;
            if(magnitude.magnitude > 75  && behind == false)
            {
                this.transform.LookAt(player.transform);
            }
            else
                behind = true;
            this.transform.Translate(this.transform.forward * 100 * Time.deltaTime, Space.World);
        }

        public void Shoot(){
            if(behind == false){
                Instantiate(bullet, bulletSpawn.position, Quaternion.Euler(new Vector3(90 + thisEnemy.rotation.eulerAngles.x, thisEnemy.rotation.eulerAngles.y, thisEnemy.rotation.eulerAngles.z)));
                Instantiate(bullet, bulletSpawn2.position, Quaternion.Euler(new Vector3(90 + thisEnemy.rotation.eulerAngles.x, thisEnemy.rotation.eulerAngles.y, thisEnemy.rotation.eulerAngles.z)));
            }
        }

        // Update is called once per frame
        // void FixedUpdate()
        // {
        //     //GetComponent<Rigidbody>().AddForce(transform.transform.forward* 750, ForceMode.Force);
            
        // }

        public void Destroy()
        {
            Instantiate(explosion, this.transform.position, this.transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
