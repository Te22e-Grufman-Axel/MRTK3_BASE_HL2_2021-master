using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoldMinerController : MonoBehaviour
{
    [SerializeField]
    Vector3 PlatePos;
    public GameObject Plate;

    float timer = 0;

  public GoldController GoldController2;

    void Awake() {
      Plate = GameObject.Find("ShopPlate");
      PlatePos = Plate.transform.position;
      transform.position = PlatePos;
    Vector3 pos = new Vector3(PlatePos.x,PlatePos.y,PlatePos.z-3);
    transform.position = pos;    
    }

    void Update()
    {

        timer += Time.deltaTime;

        if(timer > 2)
        {
      GoldController2.Gold++;
            timer = 0;
        }


    }
}
