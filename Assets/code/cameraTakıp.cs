using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraTakıp : MonoBehaviour
{
    public GameObject top;
    Vector3 mesafe;
    void Start()
    {
        mesafe = transform.position - top.transform.position;
    }

   
    void LateUpdate()
    {
        transform.position = top.transform.position + mesafe;

        
    }
}
