using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneswitch2 : MonoBehaviour
{
    public string sceneToLoad; // Name of the scene to switch to

    void Update()
    {
        // Check if the space key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SwitchScene();
        }
    }

    private void SwitchScene()
    {
        // Load the specified scene
        SceneManager.LoadScene(sceneToLoad);
    }
}

