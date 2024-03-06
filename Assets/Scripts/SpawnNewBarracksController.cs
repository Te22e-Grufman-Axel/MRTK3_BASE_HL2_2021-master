using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNewBarracksController : MonoBehaviour
{
    [SerializeField]
    GameObject Barracks;


public void OnSpawn() 
{
    Instantiate(Barracks);
}
}
