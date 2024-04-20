using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNewTowerController : MonoBehaviour
{
  [SerializeField]
  GameObject Tower;
  public GoldController GoldController2;

  public void OnSpawn()
  {
    if (GoldController2.Gold >= 20)
    {
      GoldController2.Gold = GoldController2.Gold - 20;
      Instantiate(Tower);
    }
  }
}
