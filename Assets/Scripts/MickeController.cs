using System.Collections;
using System.Collections.Generic;
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

  void Awake()
  {
    navMeshPath = new NavMeshPath();
    Micke = GetComponent<UnityEngine.AI.NavMeshAgent>();
  }
  void Update()
  {
    // Micke.destination = target1.transform.position;
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
      if (Micke.CalculatePath(target5.transform.position, navMeshPath) && navMeshPath.status == NavMeshPathStatus.PathComplete)
      {
        //move to target
        Micke.SetPath(navMeshPath);
      }
    }
    else
    {
      print("WTF");
    }
  }
}






