using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TaskComplete : MonoBehaviour
{
    public float nextDelay = 3f;

    public GameObject completeLevelUI;
    
    void Start(){
        completeLevelUI.SetActive(false);
    }

    void Update(){
        if (FarmerUI.farmerValue == 0 && FireUI.fireValue == 0){
            completeLevelUI.SetActive(true);
            Invoke("NextScene", nextDelay);
        }
    }

    void NextScene(){
        SceneManager.LoadScene("SpaceshipScene");
    }


}
