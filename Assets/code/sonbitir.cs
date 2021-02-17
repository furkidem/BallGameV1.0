using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class sonbitir : MonoBehaviour
{
     public GameObject daire;
     float kere = 22;
     public UnityEngine.UI.Text text;
     public UnityEngine.UI.Text text1;
     float zaman = 180f;
    float objtan = 62;

    void OnCollisionEnter(Collision collision)
    {
        string isim = collision.gameObject.name;
        if (isim.Equals("son") && objtan<=0)
        {
            
          
            SceneManager.LoadScene(0);
        }

       if (isim.Equals("uzay")) { }
        
        if(isim !="uzay" || isim!="son")
        {
            kere--;         
        }
       
        if (kere <= 0)
        {
            SceneManager.LoadScene(0);
        }
        text1.text = "CAN: " + kere;

    }
    void OnTriggerEnter(Collider other)
    {
        objtan--;
        Destroy(other.gameObject);
        
    }
    void Update()
    {
        zaman -= Time.deltaTime;
        text.text ="ZAMAN: "+ (int)zaman ;
        if (zaman <= 0)
        {
            SceneManager.LoadScene(0);
        }

        transform.Rotate(new Vector3(120, 0, 120) * Time.deltaTime);
    }
}
