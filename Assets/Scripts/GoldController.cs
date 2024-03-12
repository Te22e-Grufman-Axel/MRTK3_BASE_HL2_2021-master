using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoldController : MonoBehaviour
{
        [SerializeField]
    TMP_Text GuldText;
    public int Gold;

    // Update is called once per frame
    void Update()
    {
                GuldText.text = "Guld:" + Gold;
    }
}
