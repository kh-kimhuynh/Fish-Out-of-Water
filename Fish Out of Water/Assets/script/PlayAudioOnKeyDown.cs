using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnKeyDown : MonoBehaviour
{
    public KeyCode Key;
    public AudioSource TargetAudioSource;
    public float InDelay = 1f;
    public bool OneShot = true;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(InDelay);

        while (!Input.GetKeyDown(Key))
        {
            yield return null;
        }
        TargetAudioSource.Play();

        if (OneShot)
        {
            enabled = false;
        }
    }
}
