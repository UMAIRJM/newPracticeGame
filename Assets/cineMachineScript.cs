using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cineMachineScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject camera1;
    public GameObject camera2;
    void Start()
    {
        camera1.gameObject.SetActive(false);
        camera2.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.C)) {
            camera1.gameObject.SetActive(true);
            camera2.gameObject.SetActive(false);
        }
        if (Input.GetKey(KeyCode.S)) {
            camera1.gameObject.SetActive(false);
            camera2.gameObject.SetActive(true);

        }

    }
}
