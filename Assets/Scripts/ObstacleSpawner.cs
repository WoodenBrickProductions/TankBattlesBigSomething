using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstacle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    float timer = 0;
    float respawn = 5;

    // Update is called once per frame
    void Update()
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime;
            return;
        }

        timer = respawn;
        var obs = Instantiate(obstacle[Random.Range(0, obstacle.Length - 1)], null);
        obs.transform.position = transform.position;
        obs.SetActive(true);
    }
}
