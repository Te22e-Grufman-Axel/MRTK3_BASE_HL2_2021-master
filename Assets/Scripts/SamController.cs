using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamController : MonoBehaviour
{
      float Timmer = 0;
      public int Hp = 100;
      private void OnTriggerStay(Collider other)
  {
    if (other.gameObject.tag == "TeamMicke")
    {
      Timmer += 1 * Time.deltaTime;
      if (Timmer > 1)
      {
        Hp = Hp - 5;
        Timmer = 0;
      }
    }
  }
}
