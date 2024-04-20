using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerControler : MonoBehaviour
{
  [SerializeField]
  Vector3 PlatePos;
  public GameObject Plate;
  public int Hp = 100;
  float Timmer = 0;
  void Awake()
  {
    Plate = GameObject.Find("ShopPlate");
    PlatePos = Plate.transform.position;
    transform.position = PlatePos;
    Vector3 pos = new Vector3(PlatePos.x, PlatePos.y, PlatePos.z - 3);
    transform.position = pos;
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
