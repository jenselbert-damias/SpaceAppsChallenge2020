using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FarmerUI : MonoBehaviour
{

    public static int farmerValue = 6;

    Text farmer;

    // Start is called before the first frame update
    void Start()
    {
        farmer = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        farmer.text = "Farmers left: " + farmerValue;
    }
}
