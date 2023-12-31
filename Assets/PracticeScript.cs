using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cude;
    public Rigidbody rd;
    public AudioSource re;
    void Start()
    {
        cubescript.staticIneteger = 0;
        rd = cude.GetComponent<Rigidbody>();
        rd.useGravity = true;
        re = cude.GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.V)) {
            re.Play();

        }
        if (Input.GetKey(KeyCode.UpArrow)) {
            cude.transform.Translate(-0.5f, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            cude.transform.Translate(0, 0, -0.5f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            cude.transform.Translate(0, 0, 0.5f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            cude.transform.Translate(0.5f, 0, 0);
        }
        if (Input.GetKey(KeyCode.Space)) {
            //Vector3 position1 = new Vector3(6.416f, 1.8f, 1.086f);
            //print("I am in spce");
            //cude.transform.localPosition = position1;
            cude.transform.Translate(0, 0.5f, 0);
        }
    }


}
