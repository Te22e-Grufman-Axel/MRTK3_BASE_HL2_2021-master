using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoldController : MonoBehaviour
{
        [SerializeField]
    TMP_Text GuldText;
    [SerializeField]
    int gold;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
                GuldText.text = "Guld:" + gold;
    }
}
