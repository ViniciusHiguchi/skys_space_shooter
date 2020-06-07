using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sps.Core;

namespace Sps.Core{

    public class SceneController : MonoBehaviour
    {
        private int missedEnemies;
        private int score;
        private int negativeScore;
        public static GameObject sceneController;
        private GameObject thisScoreController;
        // Start is called before the first frame update
        void Start()
        {
            thisScoreController = scoredisplaycontroller.scoreController;
            sceneController = this.gameObject;
            score = 0;
            negativeScore = 0;
            missedEnemies = 0;
        }

        public void ScoreCounter(int scoreValue){
            score = score + scoreValue;
            thisScoreController.GetComponent<scoredisplaycontroller>().SetValue(score);
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
