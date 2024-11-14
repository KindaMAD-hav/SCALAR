using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    // Method to load a specified scene instead of quitting the application
    public void QuitToScene(int sceneIndex)
    {
        // Load the specified scene by its build index
        SceneManager.LoadScene(0);
    }

    // Method to quit the application completely
    public void QuitApplication()
    {
        // Only works in a built application; does nothing in the Unity editor
        Application.Quit();
        Debug.Log("Application has quit.");
    }
}
