using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sps.Core;

namespace Sps.Enemy
{

    public class EnemyManager : MonoBehaviour
    {
        public GameObject thisSceneController;
        [SerializeField] private float lifetime;
        [SerializeField] private float hp;
        [SerializeField] private float armor;
        [SerializeField] private int scoreValue;
        [SerializeField] private float timeAlive;
        // Start is called before the first frame update
        void Start()
        {
            thisSceneController = SceneController.sceneController;
            scoreValue = 10;
            hp = 25;
            armor = 10;
            lifetime = 12.5f;
            timeAlive = 0;
        }

        private void Update() {
            // timeAlive = timeAlive + Time.deltaTime;
            // if(timeAlive > lifetime || timeAlive == lifetime)
            // {
            //     GetComponent<EnemyActionScript>().Destroy();
            //     thisSceneController.GetComponent<SceneController>().EnemyMissed(10);
            // }
             if(Random.Range(0.01f, 1f) < 0.02){
                 GetComponent<EnemyActionScript>().Shoot();
             }
        }

        public void GetHit(float damage)
        {
            hp = hp - (damage * ((100 - armor) / 100));
            Debug.Log((damage * ((100 - armor) / 100)));
            if (hp <= 0)
            {
                thisSceneController.GetComponent<SceneController>().ScoreCounter(10);
                //instantiate explosion here
                GetComponent<EnemyActionScript>().Destroy();
            }
        }
    }
}
