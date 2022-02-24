using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimator : MonoBehaviour
{
    // Start is called before the first frame update
    public void grtAnimatorBreakdance(){
        this.GetComponent<Animator>().Play("Breakdance Freeze Var 2");
    }
    public void grtAnimatorJumping(){
        this.GetComponent<Animator>().Play("Jumping");
    }
    public void grtAnimatorMixamo_com(){
        this.GetComponent<Animator>().Play("mixamo_com");
    }
}
