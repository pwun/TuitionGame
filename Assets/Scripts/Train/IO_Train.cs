using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IO_Train : MonoBehaviour {

    Train Game;

    // Use this for initialization
    void Start() {
        Game = new Train();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Return))   { ClickNext(); }
    }

    public void ClickNext() {
        if (GameObject.Find("Button_Next").GetComponent<Button>().enabled) { AnswerQuestion(); }
        else { NextQuestion(); }
    }

    void NextQuestion() { }
    void AnswerQuestion() { }
}
