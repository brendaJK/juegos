using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{

    public void QuitVideogame() 
    { 
        Application.Quit();
        Debug.Log("Saliste del juego que feos modos :(");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
