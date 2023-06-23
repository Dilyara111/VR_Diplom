using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private float _speed;
    public void Init(float speed)
    {
        _speed = speed;
    }

    void Update()
    {
        transform.Translate(Vector3.right * _speed * Time.deltaTime);
    }
}
