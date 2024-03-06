using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarracksController : MonoBehaviour
{
    [SerializeField]
    Vector3 PlatePos;
    void Awake() {
    Vector3 pos = new Vector3(PlatePos.x,PlatePos.y,PlatePos.z);

    transform.position = pos;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
