using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rat3 : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spin());
    }

    private IEnumerator Spin()
    {
        while (true)
        {
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + speed, 0);
            if(transform.eulerAngles.y > 360)
            {
                transform.eulerAngles = new Vector3(0, transform.eulerAngles.y - 360, 0);
            }
            yield return new WaitForEndOfFrame();
        }
    }
}
