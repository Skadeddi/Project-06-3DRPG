using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeIt : MonoBehaviour
{
    private Animator jermamator;
    // Start is called before the first frame update
    void Start()
    {
        jermamator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            jermamator.SetBool("Shake It", true);
        }
        if(Input.GetKeyUp(KeyCode.G))
        {
            jermamator.SetBool("Shake It", false);
        }
    }
}
