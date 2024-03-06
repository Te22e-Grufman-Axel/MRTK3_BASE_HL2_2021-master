using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNewTowerController : MonoBehaviour
{
    [SerializeField]
    GameObject Tower;


public void OnSpawn() 
{
    Instantiate(Tower);
}
}
