using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNewBarracksController : MonoBehaviour
{
    [SerializeField]
    GameObject Barracks;
    public GoldController GoldController2;

    public void OnSpawn()
    {
        if (GoldController2.Gold >= 15)
        {
            GoldController2.Gold = GoldController2.Gold - 15;
            Instantiate(Barracks);
        }
    }
}
