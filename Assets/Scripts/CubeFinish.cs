using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFinish : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            Destroy(other.gameObject);
        }
    }
}
