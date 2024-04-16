using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamController : MonoBehaviour
{
      float Timmer = 0;
      public int Hp = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
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
