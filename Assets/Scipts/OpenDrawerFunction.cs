using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDrawerFunction : MonoBehaviour
{
    Vector3 pos;
    float count=0;
    void Start()
    {
        pos = transform.localPosition;
    }
    private void Update()
    {
       
    }
    private void OnMouseDown()
    {
        count+=1;
        if (count == 1)
        {
            pos.z += 0.38f;
            transform.localPosition = pos;
        }
        else if (count == 2)
        {
            pos.z -= 0.38f;
            transform.localPosition = pos;
            count = 0;
        }

    }

}
