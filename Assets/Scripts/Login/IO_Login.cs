using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IO_Login : MonoBehaviour {

    Button loginButton;

	// Use this for initialization
	void Start () {
        loginButton = GameObject.Find("Button_Login").GetComponent<Button>();
        loginButton.onClick.AddListener(ClickLogin);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void ClickLogin() {
        //CheckUsername & Password
        //Log to Server
        //Load Userdata
        SceneManager.LoadScene("Main");
    }
}
