using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
  [SerializeField] Animator transitionAnim;
  [SerializeField] AudioSource transitonSound;

    public void NextScene(string sceneName) {
      StartCoroutine(LoadScene(sceneName));
    }
    IEnumerator LoadScene(string sceneName) {

        transitionAnim.SetTrigger("End");
        transitonSound.Play();
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(sceneName);
        transitionAnim.SetTrigger("Start");
  }
}
