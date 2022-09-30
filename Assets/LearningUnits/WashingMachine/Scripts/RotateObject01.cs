using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject01 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }
    

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = new Vector3(0, 0, 50);
        transform.Rotate(rotation * Time.deltaTime);
        // added move direction so that it will move this distance
    }
}
