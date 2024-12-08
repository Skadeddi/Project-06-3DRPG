using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        source.time = 0.6f;
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
