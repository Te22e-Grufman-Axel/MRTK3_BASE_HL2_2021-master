using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNewMineController : MonoBehaviour
{
    [SerializeField]
    GameObject GoldMiner;
    [SerializeField]
    int Gold;


    public void OnSpawn()
    {
            Instantiate(GoldMiner);
    }
}
