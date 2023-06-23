using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballistic : MonoBehaviour
{
    public Transform SpawnTransform;
    public Transform TargetTransform;

    public float AngeleInDegrees;

    public GameObject Bullet;
    public GameObject LeftHand;
    public GameObject RightHand;
    float g = Physics.gravity.y;
    
    public void Update() { 
        SpawnTransform.localEulerAngles = new Vector3(-AngeleInDegrees, 0f, 0f);
        if (Health.p == true) {
            Shot();
            Health.p = false;
        }
    }
    public void Shot() {

        Vector3 fromTo = TargetTransform.position - transform.position;
        Vector3 fromToXZ = new Vector3(fromTo.x, 0f, fromTo.z);

        transform.rotation = Quaternion.LookRotation(fromToXZ, Vector3.up);

        float x = fromToXZ.magnitude;
        float y = fromTo.y;

        float AngeleInRadians = AngeleInDegrees * Mathf.PI / 180;

        float v2 = (g * x * x) / (2 * (y - Mathf.Tan(AngeleInRadians) * x) * Mathf.Pow(Mathf.Cos(AngeleInRadians), 2));
        float v = Mathf.Sqrt(Mathf.Abs(v2));

        GameObject newBullet = Instantiate(Bullet, SpawnTransform.position, Quaternion.identity);
        newBullet.GetComponent<Rigidbody>().velocity = SpawnTransform.forward * v;

    }
}
