using UnityEngine;

public class Back: MonoBehaviour
{
   
    public GameObject mainMenuCanvas;
    public GameObject settingsMenuCanvas;

  
    public void OnBackButtonPressed()
    {
       
        settingsMenuCanvas.SetActive(false);  
        mainMenuCanvas.SetActive(true);      
    }
  
}
