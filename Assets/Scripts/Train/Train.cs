using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Train {

    Exercises E;
    int CorrectCounter;
    int TotalExercises;
    int ActiveExercise;
    bool Running = false;
    public string Question = "Frage";
    public string Task = "Aufgabe";
    

    public Train() {
        CorrectCounter = 0;
        ActiveExercise = 0;
        
    }


}
