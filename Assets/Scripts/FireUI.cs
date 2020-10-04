using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireUI : MonoBehaviour
{

    public static int fireValue = 5;

    Text fire;

    // Start is called before the first frame update
    void Start()
    {
        fire = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        fire.text = "Fire left: " + fireValue;
    }
}
