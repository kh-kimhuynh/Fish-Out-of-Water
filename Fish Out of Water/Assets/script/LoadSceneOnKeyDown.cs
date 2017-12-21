using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnKeyDown : MonoBehaviour
{
    public string SceneToload;
    public float PreKeyDeley = 1f;
    public float PostKeyDelay = 1f;
    public KeyCode Key = KeyCode.Return;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(PreKeyDeley);

        while (!Input.GetKeyDown(Key))
        {
            yield return null;
        }
        yield return new WaitForSeconds(PostKeyDelay);

        SceneManager.LoadScene(SceneToload);
    }
}
