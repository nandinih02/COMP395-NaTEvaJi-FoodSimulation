using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFridge : MonoBehaviour
{
    Vector3 pos;
    Quaternion rot;
    Vector3 curEulAng;
    float y;
    float count = 0;
    void Start()
    {
        pos = transform.localPosition;
    }
    private void Update()
    {

    }
    private void OnMouseDown()
    {
        count += 1;
        if (count == 1)
        {
            pos.z += 0.67f;
            pos.x -= 0.35f;
            y = -90f;
            curEulAng += new Vector3(0, y, 0);
            rot.eulerAngles = curEulAng;
            transform.localPosition = pos;
            transform.localRotation = rot;
        }
        else if (count == 2)
        {
            pos.z -= 0.67f;
            pos.x += 0.35f;
            y = 90f;
            curEulAng += new Vector3(0, y, 0);
            rot.eulerAngles = curEulAng;
            transform.localPosition = pos;
            transform.localRotation = rot;
            count = 0;
        }

    }
}
