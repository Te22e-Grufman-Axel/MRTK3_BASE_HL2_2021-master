using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNewMineController : MonoBehaviour
{
    [SerializeField]
    GameObject GoldMiner;
    public GoldController GoldController2;


    public void OnSpawn()
    {
        if (GoldController2.Gold >= 10)
        {
            GoldController2.Gold = GoldController2.Gold - 10;
            Instantiate(GoldMiner);
        }
    }
}
