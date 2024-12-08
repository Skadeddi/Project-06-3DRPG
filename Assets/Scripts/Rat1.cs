using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rat1 : MonoBehaviour
{
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("PlayerArmature");
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform.position);
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
    }
}
