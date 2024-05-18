using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRobotickArmToConveyorScript : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator robotickArmAnimator;

    void PlayRobotickArmToConveyorAnimation()
    {
        var animator = GetComponent<Animator>();
        Debug.Log("Now is animator" + animator.name);
        animator.enabled = false;
        Debug.Log("Next is RobotickArtToConveyor");
        robotickArmAnimator.SetTrigger("StartToConveyor");
    }

}
