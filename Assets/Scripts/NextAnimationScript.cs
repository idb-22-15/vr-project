using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartWay : MonoBehaviour
{

    public Animator nextAnimator;

    public delegate void CallbackFn();
    public event CallbackFn cb;

    void PlayNextAnimation()
    {
        var animator = GetComponent<Animator>();
        animator.enabled = false;
        Debug.Log("Play next animation " + animator.name);
        bool isName = animator.GetCurrentAnimatorStateInfo(0).IsName("Base Layer.Cart Animation");
        if (cb != null) cb();
        if (nextAnimator)
            nextAnimator.SetTrigger("Start");

    }

}
