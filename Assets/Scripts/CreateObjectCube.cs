using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObjectCube : MonoBehaviour
{
    public Cube[] obj;
    float speed = 6.9f;
    private void Start()
    {
        StartCoroutine(waiter());
    }
    IEnumerator waiter()
    {
        for (int i = 0; i < 10; i++)
        {
            Cube newObj = Instantiate(obj[Random.Range(0, obj.Length)], 
                new Vector3(-1.0f, 0.2f, 30.0f), Quaternion.Euler(0, 90, 0));
            newObj.Init(speed);
            yield return new WaitForSeconds(5);
        }
    }
    void Update()
    {
    }
    public int RundomNumber()
    {
        return Random.Range(0, 3);
    }
    }
