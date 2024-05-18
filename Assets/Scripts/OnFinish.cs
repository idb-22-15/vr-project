using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OnFinish : StateMachineBehaviour
{
  public string nextAnimatorTag;
  public string nextAnimation;
  public float time = 0;


  public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
  {
    Debug.Log("OnStateExit: animator " + animator.name);

    GameObject taggedObject = GameObject.FindGameObjectWithTag(nextAnimatorTag);
    if (!taggedObject)
    {
      Debug.Log("No object with tag " + nextAnimatorTag);

    }
    else
    {
      Debug.Log("Tagged object " + taggedObject.name);
      Animator nextAnimator = taggedObject.GetComponent<Animator>();
      if (nextAnimator == null)
      {
        Debug.Log("No next animator");
      }
      else
      {
        Debug.Log("Next animation " + nextAnimation);

        nextAnimator.Play(nextAnimation);
      }
    }
  }
}