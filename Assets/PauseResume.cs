using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseResume : MonoBehaviour
{
    // Start is called before the first frame update
    public bool ispause = true;
    void Start()
    {
        
    }
    //public Text myText;
    //myText.text = "Any srting you want";
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape)) {
            if (ispause)
            {
                resume();
            }
            else {
                pause();
            }
        }
        
    }

    public void resume() {
        ispause = false;
        Time.timeScale = 1f;
    }
    public void pause() {
        ispause = true;
        Time.timeScale = 0f;
    }
}
