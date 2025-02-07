using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ResetSceneAfterTrigger : MonoBehaviour
{
    private bool isResetting = false; // Empêche plusieurs resets en même temps

    void OnTriggerEnter(Collider other)
    {
        // Vérifie que c'est bien la balle qui entre en contact
        if (!isResetting && other.CompareTag("Ball"))
        {
            StartCoroutine(ResetScene());
        }
    }

    IEnumerator ResetScene()
    {
        isResetting = true; // Empêche d'autres déclenchements
        yield return new WaitForSeconds(5f); // Attente de 5 secondes
        Redemarrer();
    }

    public void Redemarrer()
    {
        Debug.Log("Redémarrage de la scène..."); // Vérification dans la console
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}