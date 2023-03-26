using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenOven : MonoBehaviour
{
    Quaternion rot;
    Vector3 curEulAng;
    float x;
    float count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        count += 1;
        if (count == 1)
        {
            x = 90f;
            curEulAng += new Vector3(x, 0, 0);
            rot.eulerAngles = curEulAng;
            transform.localRotation = rot;
        }
        else if (count == 2)
        {
            x = -90f;
            curEulAng += new Vector3(x, 0, 0);
            rot.eulerAngles = curEulAng;
            transform.localRotation = rot;
            count = 0;
        }

    }
}
