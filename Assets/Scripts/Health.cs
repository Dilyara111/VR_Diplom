using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public static bool p = false;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Balls"))
        {
            Destroy(other.gameObject);
            p = true;
          
        }
       
    }
}