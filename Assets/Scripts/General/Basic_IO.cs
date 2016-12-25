using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Basic_IO : MonoBehaviour {

    public void ChangeScene(string _sceneName)
        {
            //Save Game
            SceneManager.LoadScene(_sceneName);
        }
}
