using UnityEngine;
using UnityEngine.SceneManagement;

public class levelswitch : MonoBehaviour
{
    public string sceneToLoad; // Name of the scene to switch to

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Check if the colliding object is tagged as "Player"
            SwitchScene();
        }
    }

    private void SwitchScene()
    {
        // Load the specified scene
        SceneManager.LoadScene(sceneToLoad);
    }
}
