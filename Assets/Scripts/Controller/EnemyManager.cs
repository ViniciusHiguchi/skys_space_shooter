using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sps.Enemy
{

    public class EnemyManager : MonoBehaviour
    {
        [SerializeField] private float lifetime;
        [SerializeField] private float hp;
        [SerializeField] private float armor;
        [SerializeField] private int scoreValue;
        [SerializeField] private float timeAlive;
        // Start is called before the first frame update
        void Start()
        {
            scoreValue = 10;
            hp = 25;
            armor = 10;
            lifetime = 12.5f;
            timeAlive = 0;
        }

        private void Update() {
            timeAlive = timeAlive + Time.deltaTime;
            if(timeAlive > lifetime || timeAlive == lifetime)
                GetComponent<EnemyActionScript>().TimeoutDestroy();
        }

        public void GetHit(float damage)
        {
            hp = hp - (damage * ((100 - armor) / 100));
            Debug.Log((damage * ((100 - armor) / 100)));
            if (hp <= 0)
            {
                //call score count type here
                //instantiate explosion here
                //call GetComponent<GameActionScript>().destroy(false);
                GetComponent<EnemyActionScript>().Destroy();
            }
        }
    }
}
