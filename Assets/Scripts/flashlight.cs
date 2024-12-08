using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlight : MonoBehaviour
{
    private GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(cam.transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z);
    }
}
