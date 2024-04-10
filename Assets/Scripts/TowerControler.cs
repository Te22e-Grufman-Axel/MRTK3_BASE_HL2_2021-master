using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerControler : MonoBehaviour
{
    [SerializeField]
    Vector3 PlatePos;
        public GameObject Plate;
    void Awake() {
      Plate = GameObject.Find("ShopPlate");
      PlatePos = Plate.transform.position;
      transform.position = PlatePos;
    Vector3 pos = new Vector3(PlatePos.x,PlatePos.y,PlatePos.z-3);
    transform.position = pos;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
