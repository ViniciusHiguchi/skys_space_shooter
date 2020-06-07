using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Sps.Core
{
    public class scoredisplaycontroller : MonoBehaviour
    { 
        int scoretest = 0;
        public static GameObject scoreController;
        public TextMeshPro text;
        private void Start() {
            scoreController = this.gameObject;
            text = FindObjectOfType<TextMeshPro>();
            if(text == null)
             Debug.Log("null");
            }
        public void SetValue(int scoreText)
        {
            text.text = (""+scoreText);
            Debug.Log("score set");
        }
    }

}
