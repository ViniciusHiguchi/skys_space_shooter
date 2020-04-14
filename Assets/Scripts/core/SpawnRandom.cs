using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandom : MonoBehaviour
{
    public GameObject enemy;
    [SerializeField] private float timeToSpawn = 0;
    [SerializeField] private float elapsedTime = 0;

    // Update is called once per frame
    void Update()
    {
        if(timeToSpawn == 0){
            timeToSpawn = Random.Range(2f, 2.5f);
        }

        elapsedTime = elapsedTime + Time.deltaTime;
        if(timeToSpawn < elapsedTime || timeToSpawn == elapsedTime){
            Vector3 spawnPosition = new Vector3(Random.Range(450,503),Random.Range(104,135.5f),480f);
            Instantiate(enemy, spawnPosition, Quaternion.Euler(0,180,0));
            timeToSpawn = 0;
            elapsedTime = 0;
        }
    }
}
