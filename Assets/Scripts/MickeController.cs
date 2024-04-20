using System;
using System.Collections;
using System.Collections.Generic;
using MixedReality.Toolkit;
using UnityEngine;
using UnityEngine.AI;

public class MickeController : MonoBehaviour
{
  UnityEngine.AI.NavMeshAgent Micke;
  NavMeshPath navMeshPath;

  [SerializeField]
  GameObject target1;
  [SerializeField]
  GameObject target2;
  [SerializeField]
  GameObject target3;
  [SerializeField]
  GameObject target4;
  [SerializeField]
  GameObject target5;
  [SerializeField]
  Vector3 TowerPos;

  public GameObject Tower;


  void Awake()
  {
    Tower = GameObject.Find("TeamMickeTower");
    TowerPos = Tower.transform.position;
    navMeshPath = new NavMeshPath();
    Micke = GetComponent<UnityEngine.AI.NavMeshAgent>();
    Vector3 pos = new Vector3(TowerPos.x + 1, TowerPos.y, TowerPos.z);
    transform.position = pos;
  }
  void Update()
  {
    if (Micke.CalculatePath(target1.transform.position, navMeshPath) && navMeshPath.status == NavMeshPathStatus.PathComplete)
    {
      //move to target
      Micke.SetPath(navMeshPath);
    }
    else if (Micke.CalculatePath(target2.transform.position, navMeshPath) && navMeshPath.status == NavMeshPathStatus.PathComplete)
    {
      //move to target
      Micke.SetPath(navMeshPath);
    }
    else if (Micke.CalculatePath(target3.transform.position, navMeshPath) && navMeshPath.status == NavMeshPathStatus.PathComplete)
    {
      //move to target
      Micke.SetPath(navMeshPath);
    }
    else if (Micke.CalculatePath(target4.transform.position, navMeshPath) && navMeshPath.status == NavMeshPathStatus.PathComplete)
    {
      //move to target
      Micke.SetPath(navMeshPath);
    }
    else if (Micke.CalculatePath(target5.transform.position, navMeshPath) && navMeshPath.status == NavMeshPathStatus.PathComplete)
    {
      //move to target
      Micke.SetPath(navMeshPath);
    }
    else
    {
      print("Cant reatch anything");
    }
  }
}






