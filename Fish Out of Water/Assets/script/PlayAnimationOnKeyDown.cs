using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimationOnKeyDown : MonoBehaviour
{
    public KeyCode Key;
    public string TriggerName;
    public Animator targetAnimator;
    public float InDeley = 1f;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(InDeley);

        while (!Input.GetKeyDown(Key))
        {
            yield return null;
        }

        targetAnimator.SetTrigger(TriggerName);
    }
}
