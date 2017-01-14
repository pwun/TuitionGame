using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Train {

    Exercises E;
    int CorrectCounter;
    int TotalExercises;
    int ActiveExercise;
    bool Running = false;
    public string Question = "Frage";
    public string Task = "Aufgabe";
    

    public Train(string _Subject) {
        CorrectCounter = 0;
        ActiveExercise = 0;
        if (_Subject.Equals("english"))
        {
            //Load English Questions
            E.GetTrainExercises("e", 6, 1, 1);//(Game.current.hero.Subject, Game.current.hero.ClassLevel, 1, Game.current.hero.Level);
        }
        else if (_Subject.Equals("math"))
        {
            //Load Math Questions
        }
        
    }


}
