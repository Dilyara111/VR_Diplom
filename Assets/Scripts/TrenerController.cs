using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrenerController : MonoBehaviour
{
    public Animator animator;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            animator.SetTrigger("HandsUp");
        }
        if (other.gameObject.CompareTag("Wall2"))
        {
            animator.SetTrigger("Go");
        }
        if (other.gameObject.CompareTag("Wall3"))
        {
            animator.SetTrigger("Squatting");
        }
    }
}
