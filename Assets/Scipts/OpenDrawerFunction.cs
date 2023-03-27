using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class OpenDrawerFunction : MonoBehaviour
{
    Vector3 pos;
    float count=0;
    //public CinemachineVirtualCamera openDrawerCam;
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
            pos.z += 0.5f;
            transform.localPosition = pos;
            //CameraManager.Register(openDrawerCam);
        }
        else if (count == 2)
        {
            pos.z -= 0.5f;
            transform.localPosition = pos;
            //CameraManager.Unregister(openDrawerCam);
            count = 0;
        }

    }

}
