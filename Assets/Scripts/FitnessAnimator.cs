using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FitnessAnimator : MonoBehaviour
{
    Animator mob_animator;
    float speed = 10f;
    IEnumerator Start()
    {
        mob_animator = GetComponent<Animator>();
        yield return new WaitForSeconds(4);
        mob_animator.SetTrigger("Go");
    }



    // Update is called once per frame
    public void set_animator_int(int a)
    {
        mob_animator.SetInteger("squatting", a);
    }
}
