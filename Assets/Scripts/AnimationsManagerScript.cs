using UnityEngine;
using System.Collections;

public class AnimationManager : MonoBehaviour
{
    public Animator[] animators;
    private string prevHashName = null;
    private int currentIndex = 0;

    void Start()
    {
        // StartCoroutine(WaitForThreeSeconds());
        StartAnimationScene();
    }

    IEnumerator WaitForThreeSeconds()
    {
        // Wait for 3 seconds
        yield return new WaitForSeconds(3f);

        // Code to execute after waiting for 3 seconds
        Debug.Log("Three seconds have passed!");
    }
    public void StartAnimationScene()
    {
        GameObject cart = GameObject.FindGameObjectWithTag("Cart");
        if (cart == null)
        {
            Debug.Log("No Cart");
        }
        else
        {
            Debug.Log("Start Animation Scene");
            Animator cartAnimator = cart.GetComponent<Animator>();
            cartAnimator.SetTrigger("Start");
        }
    }

    public void PlayNextAnimation()
    {
        // Проверяем, достигли ли мы конца массива аниматоров
        // while (currentIndex < animators.Length)
        // {
        //     var animator = animators[currentIndex];
        //     animators[currentIndex].SetTrigger("Start");

        //     AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);

        //     string currentAnimationName = stateInfo.fullPathHash.ToString();
        //     Debug.Log("Current Animation Name: " + currentAnimationName);

        //     if (prevHashName != null && prevHashName != currentAnimationName)
        //     {
        //         prevHashName = currentAnimationName;
        //         currentIndex++;

        //     }
        // }

    }
}
