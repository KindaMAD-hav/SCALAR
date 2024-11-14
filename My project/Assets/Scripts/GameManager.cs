using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
 
{
    public GameObject mainMenuCanvas;
    public GameObject settingsMenuCanvas;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Awake()
    {
        settingsMenuCanvas.SetActive(false);
        mainMenuCanvas.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
