using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MickeTowerController : MonoBehaviour
{
    [SerializeField]
    float timeSineLastSpawn = 0;
    [SerializeField]
    float LevelTimmer = 0;
    [SerializeField]
    GameObject EnemyPrefab;
    void Start()
    {

    }


    void Update()
    {
        timeSineLastSpawn += 1 * Time.deltaTime;
        LevelTimmer += 1 * Time.deltaTime;

        if (LevelTimmer < 60)
        {
            if (timeSineLastSpawn > 20)
            {
                Instantiate(EnemyPrefab);
                timeSineLastSpawn = 0;
            }
        }
        else if (LevelTimmer > 60 && LevelTimmer < 120)
        {
            if (timeSineLastSpawn > 10)
            {
                Instantiate(EnemyPrefab);
                timeSineLastSpawn = 0;
            }
        }
        else if (LevelTimmer > 120 && LevelTimmer < 150)
        {
            if (timeSineLastSpawn > 5)
            {
                Instantiate(EnemyPrefab);
                timeSineLastSpawn = 0;
            }

        }
        else if (LevelTimmer > 150)
        {
            if (timeSineLastSpawn > 1)
            {
                Instantiate(EnemyPrefab);
                timeSineLastSpawn = 0;
            }
        }
    }
}

