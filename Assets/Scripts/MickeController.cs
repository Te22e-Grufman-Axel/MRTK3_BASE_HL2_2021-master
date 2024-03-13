using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MickeController : MonoBehaviour
{
  UnityEngine.AI.NavMeshAgent Micke;
  NavMeshPath navMeshPath = new NavMeshPath();

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
    Micke = GetComponent<UnityEngine.AI.NavMeshAgent>();
  }
  void Update()
  {
    // Micke.destination = target1.transform.position;
if (Micke.CalculatePath(Micke, navMeshPath) && navMeshPath.status == NavMeshPathStatus.PathComplete)
{
      //move to target
      Micke.SetPath(navMeshPath);
}
  }
}




//create path and check if it can be done
// and check if navMeshAgent can reach its target
if (navMeshAgent.CalculatePath(Target, navMeshPath) && navMeshPath.status == NavMeshPathStatus.PathComplete)
{
      //move to target
      navMeshAgent.SetPath(navMeshPath);
}

