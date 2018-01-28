using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIClass : MonoBehaviour {

    // Use this for initialization
    void Start() {
        GetComponent<AudioSource>().Play();     
    }

    // Update is called once per frame
    void Update() {

    }

   public void StartGame() {
        SceneManager.LoadScene("Level_one");
   }
}
