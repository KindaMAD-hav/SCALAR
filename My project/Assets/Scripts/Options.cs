using UnityEngine;

public class Options: MonoBehaviour
{
    
    public GameObject mainMenuCanvas;
    public GameObject settingsMenuCanvas;

    
    public void OnBackButtonPressed()
    {
        
        settingsMenuCanvas.SetActive(true);
        mainMenuCanvas.SetActive(false);      
    }
   
}
