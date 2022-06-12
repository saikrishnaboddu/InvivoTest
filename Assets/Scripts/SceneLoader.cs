using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public Animator transition;
    public void LoadNextScene(string sceneName) {
        StartCoroutine(LoadScene(sceneName));
    }
    IEnumerator LoadScene(string sceneName) {
        transition.SetTrigger("TransitionTrigger");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(sceneName);
    }
    public void QuitApplication() {
        Application.Quit();
    }
}
