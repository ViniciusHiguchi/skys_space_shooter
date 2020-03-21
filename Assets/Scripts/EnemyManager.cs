using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sps.Enemy
{

    public class EnemyManager : MonoBehaviour
    {

        [SerializeField] private float hp;
        [SerializeField] private float armor;
        [SerializeField] private int scoreValue;
        // Start is called before the first frame update
        void Start()
        {
            //scoreValue
            hp = 25;
            armor = 10;
        }
        public void GetHit(float damage)
        {
            hp = hp - (damage * ((100 - armor) / 100));
            Debug.Log((damage * ((100 - armor) / 100)));
            if (hp <= 0)
            {
                //call score count type here
                //instantiate explosion here
                Destroy(this.gameObject);
            }
        }
    }
}
