using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapToRemove : MonoBehaviour
{
    void OnMouseDown() {
        if (gameObject.tag.Equals ("Enemy"))
            FarmerUI.farmerValue -= 1;
            Destroy(gameObject);
        if (gameObject.tag.Equals ("Fire"))
            FireUI.fireValue -= 1;
            Destroy(gameObject);
 
    }
}
