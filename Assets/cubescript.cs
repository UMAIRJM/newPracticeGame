using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubescript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject parentChild;
    public GameObject childObject;
    public GameObject[] myArray;
    public GameObject intantationObject;
    Vector3 childObjectPosition;
    public static int staticIneteger = 15;
    public int simpleInteger = 5;
    public int[] array;
    void Start()
    {
        array = new int[] { 1, 2, 3, 4, 5 };
        childObjectPosition = childObject.transform.position;
        int arrayLength = array.Length;
        for (int i = 0; i < 3; i++) {
            int rand = Random.Range(0,arrayLength-1);
            print(array[rand]);
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.I)) {
            Instantiate(intantationObject, childObjectPosition,Quaternion.identity);
        }
        if (Input.GetKey(KeyCode.Q)) {
            childObject.transform.parent = null;
        }
        parentChild.transform.Translate(0, 0, 0.05f);
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.StartsWith("otherCube")) {
            print("collision is detected");
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.StartsWith("Ground") || other.gameObject.name.StartsWith("otherCube")) {
            print("triggered");
            Destroy(other.transform.gameObject);
        
        }
    }
}
