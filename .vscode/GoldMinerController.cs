using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoldMinerController : MonoBehaviour
{
    [SerializeField]
    Vector3 PlatePos;

    float timer = 0;

    void Awake() {
    Vector3 pos = new Vector3(PlatePos.x,PlatePos.y,PlatePos.z);

    transform.position = pos;    
    }

    void Update()
    {

        timer += Time.deltaTime;

        if(timer > 2)
        {
            
            timer = 0;
        }


    }
}
