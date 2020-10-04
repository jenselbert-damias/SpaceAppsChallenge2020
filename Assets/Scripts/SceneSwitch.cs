using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{

       private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Forest"))
        {
            SceneManager.LoadScene(2);
        } else if (other.CompareTag("Ocean"))
        {
            SceneManager.LoadScene(3);
        }
    }
}
