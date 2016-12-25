using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IO_TrainSettings : MonoBehaviour {


    Button startButton;

    // Use this for initialization
    void Start()
    {
        startButton = GameObject.Find("Button_Start").GetComponent<Button>();
        startButton.onClick.AddListener(ClickStart);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ClickStart()
    {
        //Read Selection
            //Handle missfilled Formula
        //Apply to Userdata
        //Save Userdata
        SceneManager.LoadScene("Train");
    }
}
