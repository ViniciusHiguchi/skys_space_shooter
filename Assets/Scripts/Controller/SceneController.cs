using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sps.Core{

    public class SceneController : MonoBehaviour
    {
        private float missedEnemies;
        private float score;
        private float negativeScore;
        public static GameObject sceneController;
        // Start is called before the first frame update
        void Start()
        {
            sceneController = this.gameObject;
            score = 0;
            negativeScore = 0;
            missedEnemies = 0;
        }

        // void Update()
        // {
        // 
        // }

        public void ScoreCounter(int scoreValue){
            score = score + scoreValue;
            Debug.Log(score);
            Debug.Log("-"+negativeScore);
            Debug.Log(missedEnemies);
        }

        public void EnemyMissed(int scoreValue){
            missedEnemies = missedEnemies + 1;
            negativeScore = negativeScore + (scoreValue);
            Debug.Log(score);
            Debug.Log("-"+negativeScore);
            Debug.Log(missedEnemies);
        }
    }
}
