using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ResetSceneAfterTrigger : MonoBehaviour
{
    private bool isResetting = false; 

    void OnTriggerEnter(Collider other)
    {
        if (!isResetting && other.CompareTag("Ball"))
        {
            StartCoroutine(ResetScene());
        }
    }

    IEnumerator ResetScene()
    {
        isResetting = true;
        yield return new WaitForSeconds(5f);
        Redemarrer();
    }

    public void Redemarrer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

// Source utilisé : https://stackoverflow.com/questions/21598444/unity-function-call-after-a-certain-period-of-time , https://stackoverflow.com/questions/71889015/unity-how-to-make-something-happen-after-10-seconds-without-delaying-game, https://www.youtube.com/watch?v=hxpUk0qiRGs