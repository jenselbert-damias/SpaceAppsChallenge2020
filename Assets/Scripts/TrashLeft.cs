using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TrashLeft : MonoBehaviour
{
    public static int trashValue = 10;

    Text trash;

    public GameObject completeLevelUI;

    public float nextDelay = 3f;

    // Start is called before the first frame update
    void Start()
    {
        trash = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        trash.text = "Trash left: " + trashValue;
        if (trashValue == 0){
            completeLevelUI.SetActive(true);
            Invoke("NextScene", nextDelay);
        }
    }

    void NextScene(){
        SceneManager.LoadScene("SpaceshipScene");
    }

}
