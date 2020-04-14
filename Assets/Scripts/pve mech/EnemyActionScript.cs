using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sps.Core;

namespace Sps.Enemy{

    public class EnemyActionScript : MonoBehaviour
    {
        public GameObject thisSceneController;
        public GameObject player;
        [SerializeField] bool behind = false;
        // Start is called before the first frame update
        void Start()
        {
            player = PlayerControl.PlayerController.player;
            thisSceneController = SceneController.sceneController;
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

        // Update is called once per frame
        void FixedUpdate()
        {
            //GetComponent<Rigidbody>().AddForce(transform.transform.forward* 750, ForceMode.Force);
            
        }

        public void Destroy()
        {
            //insert score variable
            thisSceneController.GetComponent<SceneController>().ScoreCounter(10);
            Destroy(this.gameObject);
        }

        public void TimeoutDestroy()
        {
            thisSceneController.GetComponent<SceneController>().EnemyMissed(10);
            Destroy(this.gameObject);
        }
    }
}
