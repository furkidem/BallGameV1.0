using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objetopla : MonoBehaviour
{
   
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(new Vector3(20, 45, 65) * Time.deltaTime);
    }
   
}
